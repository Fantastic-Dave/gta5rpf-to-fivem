![image|690x364](upload://52IPTyXq889jC3SxmmKNxp8LkgG.png) 
<b>Info</b>
We've all been through this, you started working on your FiveM server and started adding vehicles, but, you got tired of switching back and forth between OpenIV and 100 notepads open. I made this tool for you.

<b>System Requirements</b>
- Microsoft .NET Framework 4.8
https://dotnet.microsoft.com/download/dotnet-framework/net48

<b>Warning</b>
If you ever used GTAUtil or GTAUtil based tools, you need to run the program then click Reset and follow the steps shown on screen.


<b>How to use</b>
<ul>
<li>Firstly, make a list of the vehicles you want to add. </li>
<li>You must search for (AddOn/Replace) vehicles. Click the first download button and then right click the second one (if it's there) and hit Copy link address. I'm attaching a GIF to help you. ![https://i.gyazo.com/e4ca91f4a962513b336b9ee41383d2a5.gif](https://i.gyazo.com/e4ca91f4a962513b336b9ee41383d2a5.gif)
<li>You must copy the DIRECT link, else the script won't work!</li>
<li>The link must look something like this:</li>
<li><b>https://files.gta5-mods.com/uploads/xxxxxxxxxxxx/yyyyyyyyyyyyyy.zip</b></li>
<li>If the link looks like this you've done something wrong:</li>
<li><i>https://www.gta5-mods.com/vehicles/2009-acura-tl-replace</i></li>
<li>Run the executable (no admin privileges needed)</li>
<li>Add a link and change resource name to your liking, or don't change anything for random numbers.</li>
<li>Wait for the program to unpack and do everything for you.</li>
<li><b>You're done!</b></li>
</ul>
Most of the people use vMenu for their server, and I setup a quick little helper for you. After each conversion, a new entry is added in vmenu.txt. You can copy all those lines and add them to your addons.json in vMenu configuration. Also, a "ensure <resourcename>" is also added in server.txt so if you add many vehicles at once you don't have to go over each one again.

<b>Credits</b>
- vickynescu (Developer)
- indilo53 (GTAUtil - https://github.com/indilo53/gtautil) without this great tool I couldn't have made this other great tool! :D

<b>Known issues</b>
- 7z decompression is known to take double the time (2x5s -10s) it should because of a bug in SharpCompress I couldn't fix
- If you ever used GTAUtil or GTAUtil based tools, you need to run the program then click Reset and follow the steps shown on screen.
- Running the program then moving it and running again breaks some GTAUtil saving (if you want to move the program after running it once, click Reset button next to GTAUtil

GitHub:
https://github.com/vscorpio/gta5rpf-to-fivem
Download link:
https://github.com/vscorpio/gta5rpf-to-fivem/releases/tag/beta_cobra4

Note for mods: I created another topic because I couldn't re-flag the locked, hidden one.
