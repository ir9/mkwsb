<#
.SYNOPSIS
Create the conifigure file of Windows SandBox

.PARAMETER vGPU
Enable or disable the virtualized GPU.
If vGPU is disabled, the sandbox uses Windows Advanced Rasterization Platform (WARP).

.PARAMETER Networking
Enable or disable network access within the sandbox.

.PARAMETER AudioInput
Shares the host's microphone input into the sandbox.

.PARAMETER VideoInput
Shares the host's webcam input into the sandbox.

.PARAMETER ProtectedClient
Places increased security settings on the Remote Desktop Protocol (RDP) session to the sandbox.

.PARAMETER PrinterRedirection
Shares printers from the host into the sandbox.

.PARAMETER ClipboardRedirection
Shares the host clipboard with the sandbox so that text and files can be pasted back and forth.

.PARAMETER MappedFolders
Share folders from the host with *read or write* permissions.
Exposing host directories might allow malicious software to affect the system or steal data.

Syntax:
-MappedFolders c:\path\to\host::c:\sandbox\path
-MappedFolders c:\path\to\host
-MappedFolders c:\path\to\host1::c:\sandbox\path1,c:\path\to\host2::c:\sandbox\path2
-MappedFolders "c:\pa th\to\ho st1::c:\sandbox\pa th1","c:\p a t h\to\host2::c:\s a n d b o x\path2"

.PARAMETER MappedFoldersReadonly
Share folders from the host with *read only* permissions.
Exposing host directories might allow malicious software to affect the system or steal data.

Syntax:
-MappedFolders c:\path\to\host::c:\sandbox\path
-MappedFolders c:\path\to\host
-MappedFolders c:\path\to\host1::c:\sandbox\path1,c:\path\to\host2::c:\sandbox\path2
-MappedFolders "c:\pa th\to\ho st1::c:\sandbox\pa th1","c:\p a t h\to\host2::c:\s a n d b o x\path2"

.PARAMETER MemoryInMB
The amount of memory, in megabytes, to assign to the sandbox.

.PARAMETER LogonCommand
A command to execute when Windows Sandbox starts.
#>


param (
    [switch]$vGPU,
    [switch]$Networking,
    [string[]]$MappedFolders,
    [string[]]$MappedFoldersReadonly,
    [string]$LogonCommand,
    [switch]$AudioInput,
    [switch]$VideoInput,
    [switch]$ProtectedClient,
    [switch]$PrinterRedirection,
    [switch]$ClipboardRedirection,
    [int]$MemoryInMB,
    [switch]$returnXmlDocumentObject
)
$scriptParam = $PSBoundParameters


# === util functions ===
function createElement()
{
    param (
        [string]$elementName,
        [string]$value
    )
    return "<${elementName}>${value}</${elementName}>"
}

function getFileName() {
    param (
        [string]$path
    )

    if($path.EndsWith("\")) {
        $path = $path[0..($path.Length - 1)]
    }

    $fileName = [System.IO.Path]::GetFileName($path)
    if($fileName) {
        # unc path はココに落ちる
        return $fileName
    }
    elseif($path -like "?:*") {
        $drive = $path[0]
        return "drive_${drive}"
    } else {
        return (Get-Date).ToString("yyyyMMdd_hhmmss")
    }
}

function parseMappedFolders()
{
    [CmdletBinding()]
    param (
        [string[]]$pathList,
        [bool]$readOnly
    )

    $ret = foreach($path in $pathList)
    {
        $arr = $path -split '::'
        $hostPath = $null
        $sndBoxPath = $null

        if($arr.length -eq 1) {
            $hostPath   = $arr[0]
            $name       = getFileName $hostPath
            $sndBoxPath = [System.IO.Path]::Combine("c:\", $name)
        }
        elseif($arr.length -ge 2) {
            $hostPath   = $arr[0]
            $sndBoxPath = $arr[1]
        }

        if($hostPath -and $sndBoxPath) {
            $obj = [PSCustomObject]@{
                host=$hostPath
                guest=$sndBoxPath
                readonly=$readOnly
            }
            $obj
        }
    }
    return $ret
}

function createMappedFoldersElement()
{
    param (
        [PSCustomObject[]]$mapRecords
    )

    if($mapRecords.Length -eq 0) {
        return ""
    }

    $MappedFolderList = foreach($r in $mapRecords) {
        $ro = if($r.readonly) { "true" } else { "false" }

        $HostFolder = createElement "HostFolder" $r.host
        $SandboxFolder = createElement "SandboxFoldert" $r.guest
        $ReadOnly = createElement "ReadOnlyt" $ro

        $cat = $HostFolder + $SandboxFolder + $ReadOnly
        createElement "MappedFolder" $cat
    }

    $cat = $MappedFolderList -join ""
    return createElement "MappedFolders" $cat
}

function makeElementTri()
{
    [CmdletBinding()]
    param (
        [string]$name,
        [bool]$value
    )

    if(-not $scriptParam.ContainsKey($name)) {
        return ""
    }

    $v = if($value) { "Enable" } else { "Disable"}
    return createElement ${name} ${v}
}

function prettyXMLDocument()
{
    param (
        [Parameter()]
        [xml]$xml
    )

    $stringWriter = New-Object System.IO.StringWriter
    $xmlWriter = New-Object System.XMl.XmlTextWriter $stringWriter
    $xmlWriter.Formatting =“indented”
    $xmlWriter.Indentation = 2
    $xml.WriteContentTo($xmlWriter)
    $xmlWriter.Flush()
    $stringWriter.Flush()
    return $stringWriter.ToString()
}

# === main ===

$vGPU_Element = makeElementTri "vGPU" $vGPU.ToBool()
$Networking_Element = makeElementTri "Networking" $Networking.ToBool()
$AudioInput_Element = makeElementTri "AudioInput" $AudioInput.ToBool()
$VideoInput_Element = makeElementTri "VideoInput" $VideoInput.ToBool()
$ProtectedClient_Element = makeElementTri "ProtectedClient" $ProtectedClient.ToBool()
$PrinterRedirection_Element = makeElementTri "PrinterRedirection" $PrinterRedirection.ToBool()
$ClipboardRedirection_Element = makeElementTri "ClipboardRedirection" $ClipboardRedirection.ToBool()

if($LogonCommand)
{
    $LogonCommand_Element = createElement "Command" $LogonCommand
    $LogonCommand_Element = createElement "LogonCommand" ${LogonCommand_Element}
}

if($MemoryInMB -gt 0) {
    $MemoryInMB_Element = createElement "MemoryInMB" ${MemoryInMB}
}

$mapWritable = parseMappedFolders $MappedFolders $false
$mapReadonly = parseMappedFolders $MappedFoldersReadonly $true
$mapFolderList = @($mapWritable) + @($mapReadonly)
$MappedFolders_Element = createMappedFoldersElement $mapFolderList

$elementList = @(
    $vGPU_Element
    $Networking_Element
    $AudioInput_Element
    $VideoInput_Element
    $ProtectedClient_Element
    $PrinterRedirection_Element
    $ClipboardRedirection_Element
    $LogonCommand_Element
    $MemoryInMB_Element
    $MappedFolders_Element
)
$innerElementList = $elementList -join ""
$root = createElement "Configuration" $innerElementList
$xml = [xml]$root

if($returnXmlDocumentObject) {
    $xml
} else {
    prettyXMLDocument $xml
}

