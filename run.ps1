Add-Type -path "wget.cs" `
	-ReferencedAssemblies System.Web, System.Windows.Forms

[Program]::Main("https://winofsql.jp/image/planet.jpg")

Read-Host "何かキーを押してください"
