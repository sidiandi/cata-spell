$param1=$args[0]
$hash = @{}

$content = Get-Content -Path $param1
$content.Split([Environment]::NewLine) | ForEach-Object {
    $entry = $_.Split("`t")
    $hash[$entry[0].ToUpper()] = $entry[1]   
}

$userInput = Read-Host
$output = ""
foreach($c in [char[]]$userInput.ToUpper()){
    if($hash.Contains([string]$c)){
        $output = $output + $hash[[string]$c] + " "
    }
}

$output