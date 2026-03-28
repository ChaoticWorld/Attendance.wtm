@echo off
setlocal enabledelayedexpansion  
 
for /r . %%a in (Debug) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

REM for /r . %%a in (.vs) do (  
  REM if exist %%a (
  REM echo "delete" %%a
  REM rd /s /q "%%a" 
 REM )
REM )

for /r . %%a in (Release) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (Win32) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (x64) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (ipch) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (*.sdf) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)

::É¾³ýCMake cache
for /r . %%a in (CMakeFiles) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (Testing) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (_CPack_Packages) do (  
  if exist %%a (
  echo "delete" %%a
  rd /s /q "%%a" 
 )
)

for /r . %%a in (CMakeCache.txt) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)

for /r . %%a in (Makefile) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)

for /r . %%a in (*.cmake) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)

REM for /r . %%a in (*.exe) do (  
  REM if exist %%a (
  REM echo "delete" %%a
  REM del "%%a" 
 REM )
REM )

for /r . %%a in (*.a) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)

for /r . %%a in (install_manifest.txt) do (  
  if exist %%a (
  echo "delete" %%a
  del "%%a" 
 )
)
pause
