CC=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

.PHONY: all clean pack install 

all: CalculatorIVS.exe 

install:
	msiexec /i CalculatorIVS/CalculatorSetup/Debug/CalculatorSetup.msi /quiet

CalculatorIVS.exe: 
	$(CC) CalculatorIVS/CalculatorIVS.sln

clean: 
	del *.cache *.exe

pack:
	powershell.exe -nologo -noprofile -command "& { Get-ChildItem -Path ../ -force | Compress-Archive -force -DestinationPath ../xkrizm06_xkucer92_xkunic01.zip }"
