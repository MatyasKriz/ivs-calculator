CC=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

.PHONY: run clean pack install doc all

all:
	echo "Use the Visual Studio solution located in CalculatorIVS subdirectory for compiling the program."

run: all
	CalculatorIVS/CalculatorIVS/bin/Debug/CalculatorIVS.exe

install:
	powershell.exe -nologo -noprofile -command "&{ msiexec /i CalculatorIVS\CalculatorSetup\Release\CalculatorIVS.msi }"

doc: docclean
	doxygen Doxyfile

clean: 
	powershell.exe -nologo -noprofile -command "& { Get-ChildItem ../ obj -Directory -recurse | Remove-Item -Recurse ; Get-ChildItem ../ bin -Directory -recurse | Remove-Item -Recurse }"

docclean:
	powershell.exe -nologo -noprofile -command "& { Remove-Item -Recurse -Force ../doc }"

pack: doc
	powershell.exe -nologo -noprofile -command "& {md -Force ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/doc ; md -Force ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/install ; md -Force ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/repo ; cp -recurse -force .\CalculatorIVS\CalculatorSetup\ ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/install/ ; cp -force -recurse ../doc ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/doc; gci -force ../ | where FullName -notlike "*tmp" | cp -recurse -force -Destination ../tmp/xkrizm06_xkucer92_xkulha08_xkunic01/repo ; Compress-Archive -force -Path ../tmp/* -DestinationPath ../xkrizm06_xkucer92_xkulha08_xkunic01.zip ; Remove-Item -Recurse -Force ../tmp }"

