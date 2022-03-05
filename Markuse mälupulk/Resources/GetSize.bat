@echo off
setlocal EnableDelayedExpansion
set /a IDX=1
set "full="
for /f "delims=" %%a in ('dir "%*"') do (
	set /a IDX+=1
	if !IDX! == 5 (
		for /f "tokens=3 delims= " %%A in ("%%a") do (
			for %%i in (%%A) do (
				set "full=!full!%%i"
			)
		)
	)
)
echo !full!