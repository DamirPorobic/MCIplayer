using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mp3_Player
{
    public class Player
    {
        Random randomNumber = new Random();
        private StringBuilder msg;  // MCI Error message
        private StringBuilder returnData;  // MCI return data
        private int error;
        private string Pcommand;  // String that holds the MCI command
        private ListView playlist;  // ListView as a playlist with the song path
        public int NowPlaying { get; set; }
        public bool Paused { get; set; }
        public bool Loop { get; set; }
        public bool Shuffle { get; set; }

        [DllImport("winmm.dll")]
        private static extern int mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        [DllImport("winmm.dll")]
        public static extern int mciGetErrorString(int errCode, StringBuilder errMsg, int buflen);

        // When creating a new player object you have to pass to it a ListView object
        // that will hold all the information about the songs in the playlist
        public Player(ListView pl)
        {
            playlist = pl;
            NowPlaying = 0;
            Loop = false;
            Shuffle = true;
            Paused= false;
            msg = new StringBuilder(128);
            returnData = new StringBuilder(128);
        }

        #region Buttons

        public void Close()
        {
            Pcommand = "close MediaFile";
            mciSendString(Pcommand, null, 0, IntPtr.Zero);
        }


        public bool Open(string sFileName)
        {
            Close();
            // Try to open as mpegvideo 
            Pcommand = "open \"" + sFileName + "\" type mpegvideo alias MediaFile";
            error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
            if (error != 0)
            {
                // Let MCI deside which file type the song is
                Pcommand = "open \"" + sFileName + "\" alias MediaFile";
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                if (error == 0)
                    return true;
                else
                    return false;
            }
            else
                return true;      
        }


        public bool Play(int track)
        {
            if (Open(playlist.Items[track].SubItems[1].Text))
            {
                Pcommand = "play MediaFile";
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                if (error == 0)
                {
                    NowPlaying = track;
                    return true;
                }
                else
                {
                    Close();
                    return false;
                }
            }
            else
                return false;
        }

        public void Pause()
        {
            if (Paused)
            {
                Resume();
                Paused = false;
            }
            else if(IsPlaying())
            {
                Pcommand = "pause MediaFile";
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                Paused = true;
            }
        }

        public void Stop()
        {
            Pcommand = "stop MediaFile";
            error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
            Paused = false;
            Close();
        }

        public void Resume()
        {
            Pcommand = "resume MediaFile";
            error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
        }
        #endregion 

        #region Status

        public bool IsPlaying()
        {
            Pcommand = "status MediaFile mode";
            error = mciSendString(Pcommand, returnData, 128, IntPtr.Zero);
            if (returnData.Length == 7 && returnData.ToString().Substring(0, 7) == "playing")
                return true;
            else
                return false;
        }

        public bool IsOpen()
        {
            Pcommand = "status MediaFile mode";
            error = mciSendString(Pcommand, returnData, 128, IntPtr.Zero);
            if (returnData.Length == 4 && returnData.ToString().Substring(0, 4) == "open")
                return true;
            else
                return false;
        }

        public bool IsPaused()
        {
            Pcommand = "status MediaFile mode";
            error = mciSendString(Pcommand, returnData, 128, IntPtr.Zero);
            if (returnData.Length == 6 && returnData.ToString().Substring(0, 6) == "paused")
                return true;
            else
                return false;
        }

        public bool IsStopped()
        {
            Pcommand = "status MediaFile mode";
            error = mciSendString(Pcommand, returnData, 128, IntPtr.Zero);
            if (returnData.Length == 7 && returnData.ToString().Substring(0, 7) == "stopped")
                return true;
            else
                return false;
        }
        #endregion

        #region Logic

        public int GetCurentMilisecond()
        {
            Pcommand = "status MediaFile position";
            error = mciSendString(Pcommand, returnData, returnData.Capacity, IntPtr.Zero);
            return int.Parse(returnData.ToString());
        }

        public void SetPosition(int miliseconds)
        {
            if (IsPlaying())
            {
                Pcommand = "play MediaFile from " + miliseconds.ToString();
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
            else
            {
                Pcommand = "seek MediaFile to " + miliseconds.ToString();
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
            }
        }

        public int GetSongLenght()
        {
            if (IsPlaying())
            {
                Pcommand = "status MediaFile length";
                error = mciSendString(Pcommand, returnData, returnData.Capacity, IntPtr.Zero);
                return int.Parse(returnData.ToString());
            }
            else
                return 0;
        }

        #endregion

        #region Audio
        public bool SetVolume(int volume)
        {
            if (volume >= 0 && volume <= 1000)
            {
                Pcommand = "setaudio MediaFile volume to " + volume.ToString();
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                return true;
            }
            else
                return false;
        }

        public bool SetBalance(int balance)
        {
            if (balance >= 0 && balance <= 1000)
            {
                Pcommand = "setaudio MediaFile left volume to " + (1000 - balance).ToString();
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                Pcommand = "setaudio MediaFile right volume to " + balance.ToString();
                error = mciSendString(Pcommand, null, 0, IntPtr.Zero);
                return true;
            }
            else
                return false;
        }

        #endregion

        public int GetSong(bool previous)
        {
            if (Shuffle)
            {
                int i;
                if (playlist.Items.Count == 1)
                    return 0;
                while (true)
                {
                    i = randomNumber.Next(playlist.Items.Count);
                    if (i != NowPlaying)
                        return i;
                }
            }
            else if (Loop && !previous)
            {
                if (NowPlaying == playlist.Items.Count - 1)
                    return 0;
                else
                    return NowPlaying + 1;
            }
            else if (Loop && previous)
            {
                if (NowPlaying == 0)
                    return playlist.Items.Count - 1;
                else
                    return NowPlaying - 1;
            }
            else
            {
                if (previous)
                {
                    if (NowPlaying != 0)
                        return NowPlaying - 1;
                    else
                        return 0;
                }
                else
                {
                    if (NowPlaying != playlist.Items.Count - 1)
                        return NowPlaying + 1;
                    else
                        return 0;
                }
            }
        }

    }
}
