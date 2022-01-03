
=====Fortnite AES Grabber: NuGet=====

Grabs AES keys for Fortnite (The Video Game).

AESGrabber.GetKeys()
-Returns ALL keys with some extra json data. Outdated, GetData() is better to use.

AESGrabber.GetData()
-Returns the raw data from https://benbot.app/api/v1/aes with no editing done, ready to be parsed.

AESGrabber.GetMainKey()
-Returns the main AES key.

AESGrabber.GetKey(string FileName)
-Returns the AES key of a specified pak file.

AESHistory.GetOldKeys(string version)
-Returns ALL keys with some extra json data. Outdated, GetData() is better to use.

AESGrabber.GetOldData()
-Returns the raw data from the AES page of benbot.app for the specified Fortnite version with no editing done, ready to be parsed.

AESHistory.GetOldMainKey(string version)
-Returns the main AES key of a specified Fortnite version.

AESHistory.GetOldKey(string version, string FileName)
-Returns the AES key of a specified pak file of a specified Fortnite version.

Fortnite is a trademark and is a copyrighted work of Epic Games, Inc. All rights reserved by Epic Games, Inc. This material is not official and is not
endorsed by Epic Games, Inc.

Used: 
- BenBot API: https://benbot.app/api/v1/aes
- Newtonsoft.Json (JSON.NET): (License, MIT) https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md

Thanks!