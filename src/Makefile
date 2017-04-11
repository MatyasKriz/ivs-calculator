CC=C:\Windows\Microsoft.NET\Framework\v4.0.30319\msbuild.exe

.PHONY: all clean pack install 

all: CalculatorIVS.exe 

install:
	msiexec /i CalculatorIVS/CalculatorSetup/Debug/CalculatorSetup.msi /quiet

CalculatorIVS.exe: 
	$(CC) CalculatorIVS/CalculatorIVS.sln

clean: 
	del *.cache *.exe
