gc $args[0].Split("`n")|%{$e=$_.Split("`t");$h[[char]$e[0].ToUpper()]=$e[1]}
[char[]](Read-Host).ToUpper()|%{Write-Host -n $h[$_] ""}