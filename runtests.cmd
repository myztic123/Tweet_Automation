@echo off
start cmd.exe /c && cd packages\NUnit.ConsoleRunner.3.10.0\tools && nunit3-console.exe --labels=All --out="..\..\..\Tweet_automation\TestResults\TestResult.txt" "--result=..\..\..\Tweet_automation\TestResults\TestResult.xml;format=nunit2" "..\..\..\Tweet_automation\bin\Debug\Tweet_automation.dll" & cd ..\..\SpecFlow.2.4.1\tools && specflow.exe nunitexecutionreport -p "..\..\..\Tweet_automation\Tweet_automation.csproj" --xmlTestResult "..\..\..\Tweet_automation\TestResults\TestResult.xml" --testOutput "..\..\..\Tweet_automation\TestResults\TestResult.txt" --OutputFile "..\..\..\Tweet_automation\TestResults\TestResult.html"