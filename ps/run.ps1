Param($url)
Write-Host $url

Add-Type -path "..\wget.cs" `
	-ReferencedAssemblies System.Web, System.Windows.Forms

[Program]::Main($url)

Read-Host "何かキーを押してください"
