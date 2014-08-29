if Exist TestResults.trx del TestResults.trx 

"%ProgramFiles%\Microsoft Visual Studio 10.0\Common7\IDE\mstest.exe" /testcontainer:MarieCurieTests\bin\debug\MarieCurieTests.dll  /resultsfile:TestResults.trx 

"C:\specflow\SpecFlow.1.9.0\tools\Specflow.exe" mstestexecutionreport MarieCurieTests\MarieCurieTests.csproj /testResult:TestResults.trx /out:TestResults.html

pause



//To filter using feature tags  /category:"wip"