@echo off
cd /D "%~dp0"
:hardrestart
mode 90,27
title Palun oodake...
choice /C Markusen /n /t 1 /d n
::use the line below if you have your own choice.exe for Windows XP/2000
::choice /C:Markuse /n /t:n,1
cls
if %errorlevel%==1 goto check2
if %errorlevel%==2 goto nuldot
if %errorlevel%==3 goto recover
if %errorlevel%==4 goto quiet
if %errorlevel%==5 goto und
if %errorlevel%==6 goto safe
if %errorlevel%==7 exit
:start
color 07
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" Echo.
if not "%qmode%"=="yes" call :c 07 "                                     "
if "%nulmode%"=="yes" ping localhost -n 2 >nul
if not "%qmode%"=="yes" call :c 01 "M"
if exist guestmode.txt set /p "guestsetting="<guestmode.txt
if not "%qmode%"=="yes" call :c 02 "a"
if not exist markuse_asjade_seaded.cmd set selectedcol=07
if not "%qmode%"=="yes" call :c 03 "r"
if not exist markuse_asjade_seaded.cmd set rightpass=password
if not "%qmode%"=="yes" call :c 04 "k"
if not exist markuse_asjade_seaded.cmd set ads=n
if not "%qmode%"=="yes" call :c 05 "u"
if not exist markuse_asjade_seaded.cmd title Markuse asjade seaded seatakse vaikesäteteks
if not "%qmode%"=="yes" call :c 06 "s"
if "%developer%"=="no" goto skips
if not exist "guestmode.txt" goto developer
:skips
if not "%qmode%"=="yes" call :c 07 "e"
if "%developer%"=="no" goto skipe
if "%guestsetting%"=="" goto retire
:skipe
if not "%qmode%"=="yes" call :c 08 " "
if not "%qmode%"=="yes" call :c 09 "a"
if "%developer%"=="no" goto skipa
if "%guestsetting%" NEQ "true" goto retired
:skipa
if not "%qmode%"=="yes" call :c 0A "s"
if exist markuse_asjade_seaded.cmd call markuse_asjade_seaded.cmd
if not "%qmode%"=="yes" call :c 0B "j"
title Markuse asjad
if "%recovery%"=="yes" goto recrev
if not "%qmode%"=="yes" call :c 0C "a"
if exist "K:\markuse asjad\Abi ja info\toel6pp.txt" goto endsupport
if not "%qmode%"=="yes" call :c 0D "d"
if "%nulmode%"=="" goto dgasaifjipfaspfhasopfhsopafhopashfopasfhopashfopasfhasopfh
:dgasaifjipfaspfhasopfhsopafhopashfopasfhopashfopasfhasopfh
if "%slpmode%"=="yes" echo.
if "%slpmode%"=="yes" echo.
if "%slpmode%"=="yes" cmd
if "%slpmode%"=="yes" set slpmode=&cls&goto start
if "%sfmode%"=="yes" goto safemenu
if "%nulmode%"=="yes" goto askold
if "%reziim%"=="%rightpass%" goto menu
if "%guestsetting%"=="true" goto view
Echo.
Echo.
set /p reziim=Parool oli vale, sisestage see uuesti:
cls
if %reziim%==%rightpass% goto menu
Echo.
Echo Parool oli vale.
Echo.
Echo Vajutage suvalist klahvi tavavaatele naasmiseks...
Pause>nul
goto view

:askold
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
Echo.
call :c 07 "                                     "
call :c 01 "M"
call :c 02 "a"
call :c 03 "r"
call :c 04 "k"
call :c 05 "u"
call :c 06 "s"
call :c 07 "e"
call :c 08 " "
call :c 09 "a"
call :c 0A "s"
call :c 0B "j"
call :c 0C "a"
call :c 0D "d"
if "%nulmode%"=="yes" ping localhost -n 5 >nul
Echo.
Echo.
set /p reziim=Sisestage parool redigeerimiseks. Kui sisestate vale parooli siis avate selle vaatamis      reziimis:
if "%reziim%"=="%rightpass%" goto menu
goto view

:safe
set sfmode=yes
goto start

:check2
setlocal EnableDelayedExpansion EnableExtensions
set key=^^!ERRORLEVEL^^!
title 3 sammu arendajani
:cj
Bg Kbd
set /a attempting=%attempting%+1
title Palun oodake...
if %attempting% GTR 10 goto start
if %key% == 335 goto check3
title 3 sammu arendajani
goto cj

:check3
title 2 sammu arendajani
Bg Kbd
set /a attempting=%attempting%+1
title Palun oodake
if %attempting% GTR 20 goto start
if %key% == 327 goto check4
title 2 sammu arendajani
goto check3

:check4
title 1 samm arendajani
set /p reziim=
if exist guestmode.txt del guestmode.txt
cls
title Palun oodake...
goto start

:nuldot
Ping localhost -n 1 >nul
set nulmode=yes
set qmode=yes
goto start

:und
set slpmode=yes
goto start

:recover
cls
set recovery=yes
goto start
:recrev
cls
set /p reziim=Sisestage parool:
if "%reziim%"=="%rightpass%" goto tts
set recovery=
cls
goto start
:tts
set /p scode=Sisestage turvakood:
if "%scode%"=="52720901" goto surerecover
cls
goto start

:surerecover
if not "%scode%"=="52720901" goto start
attrib -h markuse_asjade_seaded.cmd
del markuse_asjade_seaded.cmd
if exist guestmode.txt del guestmode.txt
set rightpass=password
set uudis1=
set uudis2=
set uudis3=
set uudis4=
set uudis5=
set recovery=
set u1=
set u2=
set u3=
set u4=
set u5=
set video1=
set video2=
set video3=
set reziim=password
set ads=
set adtext=
set nomoreads=
set adapp=
set nulmode=
goto hardrestart

:quiet
set qmode=yes
goto start

:retire
Echo.
Echo.
Echo K„sk puudub.
Echo.
Pause
exit

:retired
Echo.
Echo.
Echo Esitatud k„sk ei ole saadaval.
Echo.
Pause
exit

:view
if "%sfmode%"=="yes" goto safemenu
if "%nomoreads%"=="yes" goto viewn
if "%ads%"=="Y" goto viewads
if "%ads%"=="y" goto viewads
:viewn
cls
Color %selectedcol%
Echo.
Echo Praegune kuup„ev : %date%
Echo.
Echo Uudised:
Echo.
Echo. %uudis1%
if "%nulmode%"=="yes" goto skipview1
if "%u1%"=="" goto skipview1
Echo. Uudise kohta vaatamiseks kirjutage u1
:skipview1
Echo. %uudis2%
if "%nulmode%"=="yes" goto skipview2
if "%u2%"=="" goto skipview2
Echo. Uudise kohta vaatamiseks kirjutage u2
:skipview2
Echo. %uudis3%
if "%nulmode%"=="yes" goto skipview3
if "%u3%"=="" goto skipview3
Echo. Uudise kohta vaatamiseks kirjutage u3
:skipview3
Echo. %uudis4%
if "%nulmode%"=="yes" goto skipview4
if "%u4%"=="" goto skipview4
Echo. Uudise kohta vaatamiseks kirjutage u4
:skipview4
Echo. %uudis5%
if "%nulmode%"=="yes" goto skipview5
if "%u5%"=="" goto skipview5
Echo. Uudise kohta vaatamiseks kirjutage u5
:skipview5
Echo.
Echo Uusimad videod
Echo.
Echo. %video1%
Echo. video vaatamiseks kirjutage 1
Echo. %video2%
Echo. video vaatamiseks kirjutage 2
Echo. %video3% 
Echo. video vaatamiseks kirjutage 3
Echo.
if "%ads%"=="n" goto inputstuff
if "%nulmode%"=="yes" goto inputstuff
Echo Reklaami vaatamiseks kirjutage "r"
:inputstuff
set/panswer=Lahkumiseks kirjutage "l" :
if "%nulmode%"=="yes" goto reallyguys
if %answer%==1 start "" "%1\Markuse_videod\1. %video1%"
if %answer%==2 start "" "%1\Markuse_videod\2. %video2%"
if %answer%==3 start "" "%1\Markuse_videod\3. %video3%"
if %answer%==u1 goto readnews
if %answer%==u2 goto readnews
if %answer%==u3 goto readnews
if %answer%==u4 goto readnews
if %answer%==u5 goto readnews
set nomoreads=no
if %answer%==r view
if %answer%==r view
:skpskggg
if %answer%==l exit
if %answer%==L exit
goto viewn

:reallyguys
cls
Echo Sulgege aktiivne programm, et j„tkata
if %answer%==1 start /wait "" "%1\Markuse_videod\1. %video1%"
if %answer%==2 start /wait "" "%1\Markuse_videod\2. %video2%"
if %answer%==3 start /wait "" "%1\Markuse_videod\3. %video3%"
goto skpskggg

:safemenu
cls
Echo.
Echo Uudised:
Echo.
Echo. %uudis1%
if "%u1%"=="" goto skipvieww1
Echo. Uudise kohta vaatamiseks kirjutage u1
:skipvieww1
Echo. %uudis2%
if "%u2%"=="" goto skipvieww2
Echo. Uudise kohta vaatamiseks kirjutage u2
:skipvieww2
Echo. %uudis3%
if "%u3%"=="" goto skipvieww3
Echo. Uudise kohta vaatamiseks kirjutage u3
:skipvieww3
Echo. %uudis4%
if "%u4%"=="" goto skipvieww4
Echo. Uudise kohta vaatamiseks kirjutage u4
:skipvieww4
Echo. %uudis5%
if "%u5%"=="" goto skipvieww5
Echo. Uudise kohta vaatamiseks kirjutage u5
:skipvieww5
Echo.
Echo Taask„ivitamiseks tavareziimis kirjutage "t"
set /p answer=Lahkumiseks kirjutage "l" :
if %answer%==u1 goto readnews
if %answer%==u2 goto readnews
if %answer%==u3 goto readnews
if %answer%==u4 goto readnews
if %answer%==u5 goto readnews
if %answer%==l exit
if %answer%==t goto eb
goto safemenu

:eb
cls
set sfmode=
goto start

:viewads
cls
Echo %adtext%
if %adpp%==y start "" %adapp%
if %adpp%==Y start "" %adapp%
Pause
set nomoreads=yes
goto view
:whatsnew
cls
mode 1000,1000
type "K:\markuse asjad\Abi ja info\Mis on uus markuse kaustas.txt"
pause>nul
mode 90,27
goto view

:readnews
cls
Echo Uudiste otsimine
if %answer%==u1 goto new1
if %answer%==u2 goto new2
if %answer%==u3 goto new3
if %answer%==u4 goto new4
if %answer%==u5 goto new5

:new1
if "%u1%"=="" goto view
cls
Echo.
Echo %uudis1%
Echo.
Echo %u1%
Echo.
Pause>nul
goto view

:new2
if "%u2%"=="" goto view
cls
Echo.
Echo %uudis2%
Echo.
Echo %u2%
Echo.
Pause>nul
goto view

:new3
if "%u3%"=="" goto view
cls
Echo.
Echo %uudis3%
Echo.
Echo %u3%
Echo.
Pause>nul
goto view

:new4
if "%u4%"=="" goto view
cls
Echo.
Echo %uudis4%
Echo.
Echo %u4%
Echo.
Pause>nul
goto view

:new5
if "%u5%"=="" goto view
cls
Echo.
Echo %uudis5%
Echo.
Echo %u5%
Echo.
Pause>nul
goto view

:menu
cls
Color %selectedcol%
Echo.
Echo Praegune kuup„ev : %date%
Echo.
Echo Uudised:
Echo.
Echo. %uudis1%
Echo. %uudis2%
Echo. %uudis3%
Echo. %uudis4%
Echo. %uudis5%
Echo.
Echo. Uudiste lisamiseks kirjutage "uu"
Echo.
Echo Uusimad videod
Echo.
Echo. %video1% ^>^> video katsetamiseks kirjutage 1
Echo. %video2% ^>^> video katsetamiseks kirjutage 2
Echo. %video3% ^>^> video katsetamiseks kirjutage 3
Echo.
Echo. Video lisamiseks kirjutage "lv"
Echo. Isikliku parooli muutmiseks kirjutage "ms" ja v„rvi muutmiseks "mv"
if "%nulmode%"=="yes" goto iputthing
Echo. Reklaami lisamiseks väi eemaldamiseks kirjutage "lr"
:iputthing
set/panswer=Lahkumiseks kirjutage "l" :
cls
Echo. Palun sulgege aktiivne programm ,et j„tkata
if %answer%==uu goto addnews
if %answer%==Uu goto addnews
if %answer%==UU goto addnews
if %answer%==uU goto addnews
if %answer%==lv goto addvids
if %answer%==Lv goto addvids
if %answer%==lV goto addvids
if %answer%==LV goto addvids
if %answer%==mv goto changecolor
if %answer%==Mv goto changecolor
if %answer%==mV goto changecolor
if %answer%==MV goto changecolor
if %answer%==ms goto changepass
if %answer%==Ms goto changepass
if %answer%==mS goto changepass
if %answer%==MS goto changepass
if %answer%==l goto saveandexit
if %answer%==L goto saveandexit
if "%nulmode%"=="yes" goto reallyguys1
if %answer%==lr goto addads
if %answer%==lR goto addads
if %answer%==LR goto addads
if %answer%==Lr goto addads
if not "%nulmode%"=="yes" goto sssosss
:reallyguys1
cls
Echo Sulgege aktiivne programm, et j„tkata
if %answer%==1 start /wait "" "%1\Markuse_videod\1. %video1%"
if %answer%==2 start /wait "" "%1\Markuse_videod\2. %video2%"
if %answer%==3 start /wait "" "%1\Markuse_videod\3. %video3%"
goto menu
:sssosss
if %answer%==1 start "" "%1\Markuse_videod\1. %video1%"
if %answer%==2 start "" "%1\Markuse_videod\2. %video2%"
if %answer%==3 start "" "%1\Markuse_videod\3. %video3%"
goto menu

:addads
cls
Echo.
Echo Reklaami lisamine
Echo.
set /p ads=Kas soovite lubada reklaamid (Y/N)
if %ads%==n goto menu
if %ads%==N goto menu
cls
Echo Lisage reklaamile tekst:
set /p adtext=
cls
set /p adpp=Kas soovite lisada otsetee mingile failile (Y/N)
if %adpp%==n goto menu
if %adpp%==N goto menu
cls
set /p adapp=Lisage otsetee:
goto menu

:changecolor
cls
Color /?
Echo.
Echo. Muuda v„rvi
Echo.
set/pselectedcol=Sisesta v„rvikood:
goto menu

:addnews
cls
Echo.
Echo. Lisa uudiseid
Echo.
Echo. 1. Uudis 1
Echo. 2. Uudis 2
Echo. 3. Uudis 3
Echo. 4. Uudis 4
Echo. 5. Uudis 5
set/pnewnumber= 6. Tagasi :
cls
if %newnumber%==6 goto menu
:change
cls
Echo Uudise %newnumber% lisamiseks kirjutage selle pealkiri :
set /pnew=
cls
cls
set uudis%newnumber%=%new%
if "%nulmode%"=="yes" goto menu
echo Kirjutage uudise sisu:
set /p u%newnumber%=
set spfka=%u%newnumber%%
if %answer%==Y goto change
if %answer%==N goto menu
if %answer%==y goto change
if %answer%==n goto menu
goto menu

:changepass
cls
Echo.
Echo. Muuda salasäna
Echo.
set/prightpass=Sisestage uus salasäna :
:changepass2
cls
Echo.
Echo. Muuda salasäna
Echo.
set/pconfirm=Sisestage uus salasäna uuesti :
if %confirm%==%rightpass% goto menu
goto wrong

:wrong
cls
Echo.
Echo. Vale salasäna
Echo.
set/pconfirm=Sisestage uus salasäna uuesti :
if %confirm%==%rightpass% goto menu
goto wrong

:addvids
set /pvid=Video lisamiseks lisamiseks kirjutage selle nimi koos formaadiga :
cls
cls
set video3=%video2%
set video2=%video1%
set video1=%vid%
goto menu

:saveandexit
cls
attrib -h markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
if exist markuse_asjade_seaded.cmd del markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo true>>guestmode.txt
if not "%nulmode%"=="yes" cls
@echo SET rightpass=%rightpass%>>markuse_asjade_seaded.cmd
@echo SET uudis1=%uudis1%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET uudis2=%uudis2%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET uudis3=%uudis3%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET uudis4=%uudis4%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET uudis5=%uudis5%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
if "%nulmode%"=="yes" goto skipsomething
@echo SET u1=%u1%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET u2=%u2%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET u3=%u3%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET u4=%u4%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET u5=%u5%>>markuse_asjade_seaded.cmd
:skipsomething
if not "%nulmode%"=="yes" cls
@echo SET video1=%video1%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET video2=%video2%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET video3=%video3%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET selectedcol=%selectedcol%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
if "%nulmode%"=="yes" exit
@echo SET adapp=%adapp%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET adpp=%adpp%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET ads=%ads%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
@echo SET adtext=%adtext%>>markuse_asjade_seaded.cmd
if not "%nulmode%"=="yes" cls
attrib +h markuse_asjade_seaded.cmd
exit

:endsupport
cls
Color CE
Echo.
Echo. Ert
Echo.
Echo. Uudised pole saadaval kuna Erti tugi
Echo. on läppenud.
Echo.
call :c CE "Vajutage suvalist klahvi lahkumiseks..."
Pause>nul
Echo.
exit/b

:developer
cls
color 4F
Echo.
call :c CF "Kas hakata arendajakas?"
Echo.
Echo.
Echo Arendajaks hakkamine väimaldab teil muuta uudiseid, videosid
Echo ja uudiste sisu. Kasutades arendaja äigust valesti, väite
Echo kahjustada uudiste partiifaili. Kasutage väimalust omal
Echo riskil.
Echo.
Echo Kas olete kindel ,et soovite j„tkata?
Echo.
Echo 1. Jah
Echo. Lubab teil muuta selle partiifaili seadeid. Kontrollib
Echo. ka parooli äigsust.
Echo 2. Ei
Echo. Vätab käik muudatused tagasi ja k„ivitab selle partii-
Echo. faili tavaliselt
set /p answer=
cls
color 07
if "%answer%"=="1" set developer=no&goto start
if "%answer%"=="2" goto renableguest
goto developer

:renableguest
cls
@echo true>>guestmode.txt
Echo.
Echo Markuse asjade partiifail k„ivitub normaalselt
Echo.
call :c 07 "Vajutage suvalist klahvi j„tkamiseks..."
Pause>nul
cls
goto start

:colorPrint
Color  Str  [/n]
setlocal
set "s=%~2"
call :colorPrintVar %1 s %3
exit /b
:c
setlocal enableDelayedExpansion

:colorPrint Color  Str  [/n]
setlocal
set "s=%~2"
call :colorPrintVar %1 s %3
exit /b

:colorPrintVar  Color  StrVar  [/n]
if not defined DEL call :initColorPrint
setlocal enableDelayedExpansion
pushd .
':
cd \
set "s=!%~2!"
:: The single blank line within the following IN() clause is critical - DO NOT REMOVE
for %%n in (^"^

^") do (
  set "s=!s:\=%%~n\%%~n!"
  set "s=!s:/=%%~n/%%~n!"
  set "s=!s::=%%~n:%%~n!"
)
for /f delims^=^ eol^= %%s in ("!s!") do (
  if "!" equ "" setlocal disableDelayedExpansion
  if %%s==\ (
    findstr /a:%~1 "." "\'" nul
    <nul set /p "=%DEL%%DEL%%DEL%"
  ) else if %%s==/ (
    findstr /a:%~1 "." "/.\'" nul
    <nul set /p "=%DEL%%DEL%%DEL%%DEL%%DEL%"
  ) else (
    >colorPrint.txt (echo %%s\..\')
    findstr /a:%~1 /f:colorPrint.txt "."
    <nul set /p "=%DEL%%DEL%%DEL%%DEL%%DEL%%DEL%%DEL%"
  )
)
if /i "%~3"=="/n" echo(
popd
exit /b


:initColorPrint
for /f %%A in ('"prompt $H&for %%B in (1) do rem"') do set "DEL=%%A %%A"
<nul >"%temp%\'" set /p "=."
subst ': "%temp%" >nul
exit /b


:cleanupColorPrint
2>nul del "%temp%\'"
2>nul del "%temp%\colorPrint.txt"
>nul subst ': /d
exit /b
