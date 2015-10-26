@echo OFF
echo RootCasesDirectory=C:\Users\daniel.berry\Desktop\deletion-widget
echo OutputDirectory=C:\Users\daniel.berry\Desktop\deletion-widget\test-deletion-output
echo CollectorExecutable=C:\Program Files (x86)\Nuix\Nuix Collector\Modules\Nuix Collector.exe
echo Scope=flag:physical_file
echo VerificationOne=True
echo Username=daniel.berry
echo Domain=nuix-philly
echo Password(Encrypted)=Q2hlNHU1YWMm
echo ScrambleCreationDate=True
echo ScrambleAccessDate=False
echo ScrambleModificationDate=False
echo DeleteFolders=True
echo OverwriteCount=4
echo VerificationTwo=True
echo VerifyCreationDate=True
echo VerifySize=True
echo VerifyModificationDate=True
echo VerifyMD5Hash=True
echo VerifyAccessDate=False
echo ValidateJobFileXML=True
echo SendNotifications=True
echo NotificationTargets=daniel.berry@nuix.com
"C:\Program Files\Nuix\Nuix 6.2\jre\bin\java.exe" -cp "C:\development\projects\github\nuix-nase\c#.net\daniel.berry\NuixCommandConsole\bin\Debug";.\nuix-command-console.jar;"C:\Development\Nuix-Engine\6.2\lib\*"  com.nuix.cc.collector.PhysicalFileDeletion "C:\Users\daniel.berry\Desktop\deletion-widget" "C:\Users\daniel.berry\Desktop\deletion-widget\test-deletion-output" "dongle" "USNX1147" "ultimate-workstation" "codemonkey" "codemonkey" "20151022230521" "flag:physical_file" "C:\Program Files (x86)\Nuix\Nuix Collector\Modules\Nuix Collector.exe" "C:\development\projects\github\nuix-nase\c#.net\daniel.berry\NuixCommandConsole\bin\Debug\ActivityTemplates\PhysicalFileDeletionNode\DefensibleForensicDeletion20151022230521.xml" " -Dnuix.registry.servers="" -Djava.io.tmpdir="C:\Users\daniel.berry\AppData\Local\Temp\Nuix" -Dnuix.logdir="C:\Users\daniel.berry\AppData\Local\Nuix\Logs" -Dnuix.loglevel="INFO"
