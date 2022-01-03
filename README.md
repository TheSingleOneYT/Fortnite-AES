# =====Fortnite AES Grabber: NuGet=====

[![Nuget](https://img.shields.io/nuget/v/Fortnite.AES?style=flat-square)](https://www.nuget.org/packages/Fortnite.AES)

Grabs AES keys for Fortnite (The Video Game).

# Use

AESGrabber.GetKeys()<br>
-Returns ALL keys with some extra json data. Outdated, GetData() is better to use.

AESGrabber.GetData()<br>
-Returns the raw data from https://benbot.app/api/v1/aes with no editing done, ready to be parsed.

AESGrabber.GetMainKey()<br>
-Returns the main AES key.

AESGrabber.GetKey(string FileName)<br>
-Returns the AES key of a specified pak file.

AESHistory.GetOldKeys(string version)<br>
-Returns ALL keys with some extra json data. Outdated, GetData() is better to use.

AESGrabber.GetOldData()<br>
-Returns the raw data from the AES page of benbot.app for the specified Fortnite version with no editing done, ready to be parsed.

AESHistory.GetOldMainKey(string version)<br>
-Returns the main AES key of a specified Fortnite version.

AESHistory.GetOldKey(string version, string FileName)<br>
-Returns the AES key of a specified pak file of a specified Fortnite version.

Fortnite is a trademark and is a copyrighted work of Epic Games, Inc. All rights reserved by Epic Games, Inc. This material is not official and is not
endorsed by Epic Games, Inc.

# Used 
- BenBot API: https://benbot.app/api/v1/aes
- Newtonsoft.Json (JSON.NET): (License, MIT) https://github.com/JamesNK/Newtonsoft.Json/blob/master/LICENSE.md

Thanks!