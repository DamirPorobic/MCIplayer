# MCIplayer
A simple MCI player for playing music with the appropriate environment written in C# and Visual Studio. 

### Introduction  
This is a very simple music player that uses the MCI multimedia command string to interact with the device. The MCI interface is fairly 
powerful, and can be very useful. You can play almost any audio file (video files too, but I haven't covered this part in my player)
including MP3, Wave, MIDI, ASF, and more.

### Background  
Very useful link to get started with MCI:  
http://www.vbforfree.com/mci-multimedia-command-string-tutorial-a-step-by-step-guide/

You can find the commands used in this application here:  
https://msdn.microsoft.com/en-us/library/ms712587(VS.85).aspx

### Using the code  
The application has a player class that handles all the interactions with the MCI device. A tag reader class reads specific information
about the sound file (title, artist, album, and so on). And, the environment file handles the main form.

For more details of this project, please visit:   
http://www.codeproject.com/Articles/63094/Simple-MCI-Player
