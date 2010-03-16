<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="9008000">
	<Item Name="Poste de travail" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">Poste de travail/VI Serveur</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">Poste de travail/VI Serveur</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Movies renamer.vi" Type="VI" URL="/&lt;userlib&gt;/LV_users_dev/LuL_dev/renamer/Movies renamer.vi"/>
		<Item Name="LL32.ico" Type="Document" URL="/&lt;userlib&gt;/LV_LABOLEM/LABOLEM_UTILITY/GRAPHICS/images/LuL/LL32.ico"/>
		<Item Name="Dépendances" Type="Dependencies">
			<Item Name="vi.lib" Type="Folder">
				<Item Name="Recursive File List.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Recursive File List.vi"/>
				<Item Name="List Directory and LLBs.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/List Directory and LLBs.vi"/>
				<Item Name="Get File Extension.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Get File Extension.vi"/>
				<Item Name="Check if File or Folder Exists.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/libraryn.llb/Check if File or Folder Exists.vi"/>
				<Item Name="NI_FileType.lvlib" Type="Library" URL="/&lt;vilib&gt;/Utility/lvfile.llb/NI_FileType.lvlib"/>
				<Item Name="whitespace.ctl" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/whitespace.ctl"/>
				<Item Name="Trim Whitespace.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Trim Whitespace.vi"/>
				<Item Name="Error Cluster From Error Code.vi" Type="VI" URL="/&lt;vilib&gt;/Utility/error.llb/Error Cluster From Error Code.vi"/>
				<Item Name="Open URL in Default Browser.vi" Type="VI" URL="/&lt;vilib&gt;/Platform/browser.llb/Open URL in Default Browser.vi"/>
				<Item Name="Open URL in Default Browser (string).vi" Type="VI" URL="/&lt;vilib&gt;/Platform/browser.llb/Open URL in Default Browser (string).vi"/>
				<Item Name="Open URL in Default Browser core.vi" Type="VI" URL="/&lt;vilib&gt;/Platform/browser.llb/Open URL in Default Browser core.vi"/>
				<Item Name="Open URL in Default Browser (path).vi" Type="VI" URL="/&lt;vilib&gt;/Platform/browser.llb/Open URL in Default Browser (path).vi"/>
				<Item Name="Path to URL.vi" Type="VI" URL="/&lt;vilib&gt;/printing/PathToURL.llb/Path to URL.vi"/>
				<Item Name="Escape Characters for HTTP.vi" Type="VI" URL="/&lt;vilib&gt;/printing/PathToURL.llb/Escape Characters for HTTP.vi"/>
				<Item Name="subDisplayMessage.vi" Type="VI" URL="/&lt;vilib&gt;/express/express output/DisplayMessageBlock.llb/subDisplayMessage.vi"/>
				<Item Name="ex_CorrectErrorChain.vi" Type="VI" URL="/&lt;vilib&gt;/express/express shared/ex_CorrectErrorChain.vi"/>
			</Item>
		</Item>
		<Item Name="Spécifications de construction" Type="Build">
			<Item Name="Movies renamer" Type="EXE">
				<Property Name="App_applicationGUID" Type="Str">{92588A62-85BD-4700-AC76-409D2D71FCBE}</Property>
				<Property Name="App_applicationName" Type="Str">Movies renamer.exe</Property>
				<Property Name="App_autoIncrement" Type="Bool">true</Property>
				<Property Name="App_companyName" Type="Str">LEM S.A.</Property>
				<Property Name="App_fileDescription" Type="Str">Movies renamer</Property>
				<Property Name="App_fileVersion.build" Type="Int">1</Property>
				<Property Name="App_fileVersion.major" Type="Int">1</Property>
				<Property Name="App_INI_aliasGUID" Type="Str">{3129EAF5-66B1-4EAE-BE86-424D92922FC0}</Property>
				<Property Name="App_INI_GUID" Type="Str">{F5435931-2F1B-4CC8-AF9F-88F7D8023582}</Property>
				<Property Name="App_internalName" Type="Str">Movies renamer</Property>
				<Property Name="App_legalCopyright" Type="Str">Ludovic LAVY Copyright © 2010 LEM S.A.</Property>
				<Property Name="App_productName" Type="Str">Movies renamer</Property>
				<Property Name="Bld_buildSpecName" Type="Str">Movies renamer</Property>
				<Property Name="Bld_defaultLanguage" Type="Str">French</Property>
				<Property Name="Destination[0].destName" Type="Str">Movies renamer.exe</Property>
				<Property Name="Destination[0].path" Type="Path">../builds/NI_AB_PROJECTNAME/Movies renamer/Movies renamer.exe</Property>
				<Property Name="Destination[0].preserveHierarchy" Type="Bool">true</Property>
				<Property Name="Destination[0].type" Type="Str">App</Property>
				<Property Name="Destination[1].destName" Type="Str">Répertoire de support</Property>
				<Property Name="Destination[1].path" Type="Path">../builds/NI_AB_PROJECTNAME/Movies renamer/data</Property>
				<Property Name="DestinationCount" Type="Int">2</Property>
				<Property Name="Exe_iconItemID" Type="Ref">/Poste de travail/LL32.ico</Property>
				<Property Name="Source[0].Container.applyDestination" Type="Bool">true</Property>
				<Property Name="Source[0].Container.applyProperties" Type="Bool">true</Property>
				<Property Name="Source[0].Container.applySaveSettings" Type="Bool">true</Property>
				<Property Name="Source[0].destinationIndex" Type="Int">1</Property>
				<Property Name="Source[0].itemID" Type="Str">{14B094F7-32A4-4EE5-8B83-08A261612D26}</Property>
				<Property Name="Source[0].type" Type="Str">Container</Property>
				<Property Name="Source[1].destinationIndex" Type="Int">0</Property>
				<Property Name="Source[1].itemID" Type="Ref">/Poste de travail/Movies renamer.vi</Property>
				<Property Name="Source[1].sourceInclusion" Type="Str">TopLevel</Property>
				<Property Name="Source[1].type" Type="Str">VI</Property>
				<Property Name="SourceCount" Type="Int">2</Property>
			</Item>
			<Item Name="Setup movies renamer" Type="Installer">
				<Property Name="arpCompany" Type="Str">LEM S.A.</Property>
				<Property Name="arpContact" Type="Str">Ludovic LAVY</Property>
				<Property Name="arpURL" Type="Str">http://www.LEM.com</Property>
				<Property Name="AutoIncrement" Type="Bool">true</Property>
				<Property Name="BldInfo.Count" Type="Int">1</Property>
				<Property Name="BldInfo[0].Dir" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="BldInfo[0].Tag" Type="Ref">/Poste de travail/Spécifications de construction/Movies renamer</Property>
				<Property Name="BuildLabel" Type="Str">Setup movies renamer</Property>
				<Property Name="BuildLocation" Type="Path">../../builds/movies renamer/Setup movies renamer</Property>
				<Property Name="DirInfo.Count" Type="Int">2</Property>
				<Property Name="DirInfo.DefaultDir" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="DirInfo[0].DirName" Type="Str">movies renamer</Property>
				<Property Name="DirInfo[0].DirTag" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="DirInfo[0].ParentTag" Type="Str">{3912416A-D2E5-411B-AFEE-B63654D690C0}</Property>
				<Property Name="DirInfo[1].DirName" Type="Str">data</Property>
				<Property Name="DirInfo[1].DirTag" Type="Str">{F10B33AB-1109-4747-AB41-8C20D6EFDB9A}</Property>
				<Property Name="DirInfo[1].ParentTag" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="DistID" Type="Str">{94A86908-AF92-49CD-BC49-B6C9C1434819}</Property>
				<Property Name="DistParts.Count" Type="Int">1</Property>
				<Property Name="DistPartsInfo[0].FlavorID" Type="Str">DefaultFull</Property>
				<Property Name="DistPartsInfo[0].ProductID" Type="Str">{61912EB3-0D1B-4EDB-AD88-E96A3B851403}</Property>
				<Property Name="DistPartsInfo[0].ProductName" Type="Str">NI Moteur d'exécution de LabVIEW 2009</Property>
				<Property Name="DistPartsInfo[0].UpgradeCode" Type="Str">{1DA01FF3-1E36-4A14-802B-D195819E159B}</Property>
				<Property Name="FileInfo.Count" Type="Int">3</Property>
				<Property Name="FileInfo[0].DirTag" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="FileInfo[0].FileName" Type="Str">Movies renamer.exe</Property>
				<Property Name="FileInfo[0].FileTag" Type="Str">{92588A62-85BD-4700-AC76-409D2D71FCBE}</Property>
				<Property Name="FileInfo[0].Type" Type="Int">3</Property>
				<Property Name="FileInfo[0].TypeID" Type="Ref">/Poste de travail/Spécifications de construction/Movies renamer</Property>
				<Property Name="FileInfo[1].DirTag" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="FileInfo[1].FileName" Type="Str">Movies renamer.aliases</Property>
				<Property Name="FileInfo[1].FileTag" Type="Str">{3129EAF5-66B1-4EAE-BE86-424D92922FC0}</Property>
				<Property Name="FileInfo[1].Type" Type="Int">3</Property>
				<Property Name="FileInfo[1].TypeID" Type="Ref">/Poste de travail/Spécifications de construction/Movies renamer</Property>
				<Property Name="FileInfo[2].DirTag" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="FileInfo[2].FileName" Type="Str">Movies renamer.ini</Property>
				<Property Name="FileInfo[2].FileTag" Type="Str">{F5435931-2F1B-4CC8-AF9F-88F7D8023582}</Property>
				<Property Name="FileInfo[2].Type" Type="Int">3</Property>
				<Property Name="FileInfo[2].TypeID" Type="Ref">/Poste de travail/Spécifications de construction/Movies renamer</Property>
				<Property Name="InstSpecVersion" Type="Str">9008024</Property>
				<Property Name="Language" Type="Int">12</Property>
				<Property Name="LicenseFile" Type="Ref"></Property>
				<Property Name="OSCheck" Type="Int">1</Property>
				<Property Name="OSCheck_Vista" Type="Bool">false</Property>
				<Property Name="ProductName" Type="Str">movies renamer</Property>
				<Property Name="ProductVersion" Type="Str">1.0.4</Property>
				<Property Name="ReadmeFile" Type="Ref"></Property>
				<Property Name="ShortcutInfo.Count" Type="Int">1</Property>
				<Property Name="ShortcutInfo[0].DirTag" Type="Str">{B9E310F1-839C-48B7-8CAE-33000780C26E}</Property>
				<Property Name="ShortcutInfo[0].FileTag" Type="Str">{92588A62-85BD-4700-AC76-409D2D71FCBE}</Property>
				<Property Name="ShortcutInfo[0].FileTagDir" Type="Str">{7E4090D1-3234-4125-961B-A5CB2009DF63}</Property>
				<Property Name="ShortcutInfo[0].Name" Type="Str">Movies renamer</Property>
				<Property Name="ShortcutInfo[0].SubDir" Type="Str">movies renamer</Property>
				<Property Name="UpgradeCode" Type="Str">{B3A551D5-048E-4194-8CBA-01812CE6067D}</Property>
			</Item>
		</Item>
	</Item>
</Project>
