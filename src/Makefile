CC=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

.PHONY: all clean pack install doc

all: CalculatorIVS.exe 

install:
	msiexec /i CalculatorIVS/CalculatorSetup/Debug/CalculatorSetup.msi /quiet

doc: docclean
	doxygen Doxyfile

CalculatorIVS.exe: 
	$(CC) CalculatorIVS/CalculatorIVS.sln

clean: 
	powershell.exe -nologo -noprofile -command "& { Get-ChildItem ../ obj -Directory -recurse | Remove-Item -Recurse ; Get-ChildItem ../ bin -Directory -recurse | Remove-Item -Recurse }"

docclean:
	powershell.exe -nologo -noprofile -command "& { Remove-Item -Recurse -Force ../doc }"

pack: doc
	powershell.exe -nologo -noprofile -command "& { Get-ChildItem -Path ../ -force | Compress-Archive -force -DestinationPath ../xkrizm06_xkucer92_xkunic01.zip }"

