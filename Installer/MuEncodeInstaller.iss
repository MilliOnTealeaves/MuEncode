; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "MuEncode"
#define MyAppVersion "2.2"
#define MyAppPublisher "MilliOnTealeaves"
#define MyAppURL "https://github.com/MilliOnTealeaves/MuEncode/"
#define MyAppExeName "MuEncode.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{4D0007F1-E451-4511-AD0F-3CADB8B67BEF}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputBaseFilename=MuEncodeSetup_v{#myAppVersion}
SetupIconFile="C:\Users\emila\OneDrive\Pictures\Saved Pictures\greenMu.ico"
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\MuEncode.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\MuEncode.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\MuEncode.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\MuEncode.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\Help\HelpPage.html"; DestDir: "{app}\Help"; Flags: ignoreversion
Source: "C:\Users\emila\OneDrive\Documents\Programming\source\repos\MuEncode\bin\Release\net6.0-windows7.0\Help\MainStyle.css"; DestDir: "{app}\Help"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

