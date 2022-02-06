@echo off
rem Пакетный файл для приложения SimpleCSharpApp
rem в котором захватывается возвращаемое им значение

.\"SimpleCSharpApp_ chapter3"\bin\Debug\"SimpleCSharpApp_ chapter3.exe"
@if "%ERRORLEVEL%" == 0 goto succes
:fail
rem Приложение потерпело неудачу
echo This application has failed!
echo return value = %ERRORLEVEL%
goto end
:success 
rem Приложение успешно завершено
echo This application has succeeded!
echo return value = %ERRORLEVEL%
goto end
:end
rem Работа сделанаю
echo All done!