REM https://ferritedog.wordpress.com/2011/05/27/1-hour-guide-to-continuous-integration-setup-jenkins-meets-net/
REM Path variables
SET JENKINSWORKSPACE=C:\Program Files (x86)\Jenkins\workspace
SET FolderPath=%JENKINSWORKSPACE%\MVCTesting
SET ResultsPath=%JENKINSWORKSPACE%\MVCTesting\UnitTestResults
SET CoverageHistoryPath=%JENKINSWORKSPACE%\\MVCTesting\CoverageHistory
 
SET NunitPath=%FolderPath%\MVCApp\packages\NUnit.ConsoleRunner.3.7.0\tools
SET ReportUnitPath=%FolderPath%\MVCApp\packages\ReportUnit.1.2.1\tools
SET OpenCoverPath=%FolderPath%\MVCApp\packages\OpenCover.4.6.519\tools
SET ReportGeneratorPath=%FolderPath%\MVCApp\packages\ReportGenerator.3.1.0-beta4\tools
SET UnitTestProj=%FolderPath%\MVCAppTests\MVCAppTests.csproj


echo JENKINSWORKSPACE %JENKINSWORKSPACE%
echo FolderPath %FolderPath%
echo ResultsPath %ResultsPath%
echo CoverageHistoryPath %CoverageHistoryPath%
echo %NunitPath%
echo %ReportUnitPath%
echo %OpenCoverPath%
echo %ReportGeneratorPath%
echo %UnitTestProj%

 
REM Recreate Results Folder
rd /S /Q "%ResultsPath%"
md "%ResultsPath%"

REM Create coverage history folder if not exists
if not exist "%CoverageHistoryPath%" mkdir "%CoverageHistoryPath%"

REM Run Nunit3 for tests, it produces TestResult.xml report
REM  "%NunitPath%"\nunit3-console.exe %UnitTestProj% --result="%ResultsPath%"\TestResult.xml

REM Get nunit command errorlevel
REM SET NunitError=%ERRORLEVEL%

REM Run ReportUnit to create HTML Report from Nunit XML report
"%ReportUnitPath%"\ReportUnit.exe "%ResultsPath%"\TestResult.xml


REM Run OpenCover to create coverage XML report
"%OpenCoverPath%"\OpenCover.Console.exe -register:user -register:user -target:%NunitPath%\nunit3-console.exe -targetargs:%UnitTestProj% -output:%ResultsPath%\opencovertests.xml

REM Run ReportGenerator to create coverage HTML report from coverage XML
%ReportGeneratorPath%\ReportGenerator.exe -reports:%ResultsPath%\opencovertests.xml -targetDir:%ResultsPath% -historydir:%CoverageHistoryPath%

REM Fail if Nunit has found an error on tests
exit /b %NunitError%