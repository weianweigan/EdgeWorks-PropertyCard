set path=%~d0
cd %path%
cd /d %~dp0

RegAsm.exe EdgeWorks.PropertyCard.EdgeAddin.dll /u

pause