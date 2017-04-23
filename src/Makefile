CC=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

.PHONY: run clean pack install doc all

all:

run:
	CalculatorIVS/CalculatorIVS/bin/Debug/CalculatorIVS.exe

install:
	msiexec /i CalculatorIVS/CalculatorSetup/Debug/CalculatorSetup.msi /quiet

doc: docclean
	doxygen Doxyfile

clean: 
	powershell.exe -nologo -noprofile -command "& { Get-ChildItem ../ obj -Directory -recurse | Remove-Item -Recurse ; Get-ChildItem ../ bin -Directory -recurse | Remove-Item -Recurse }"

docclean:
	powershell.exe -nologo -noprofile -command "& { Remove-Item -Recurse -Force ../doc }"

pack: doc
	powershell.exe -nologo -noprofile -command "& {md -Force ../tmp/doc ; md -Force ../tmp/install ; md -Force ../tmp/repo ; cp -recurse -force .\CalculatorIVS\CalculatorSetup\ ../tmp/install/ ; cp -force -recurse ../doc ../tmp/doc; gci -force ../ | where FullName -notlike "*tmp" | cp -recurse -force -Destination ../tmp/repo ; Compress-Archive -force -Path ../tmp/* -DestinationPath ../xkrizm06_xkucer92_xkunic01.zip ; Remove-Item -Recurse -Force ../tmp }"

