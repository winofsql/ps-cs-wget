Add-Type -path "..\wget.cs" `
	-ReferencedAssemblies System.Web, System.Windows.Forms `
	-OutputAssembly my_wget.exe `
	-OutputType ConsoleApplication

Read-Host "何かキーを押してください"
