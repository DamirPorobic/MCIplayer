using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mp3_Player
{
    public partial class frmMain : Form
    {
        Player player;
        Font font;
        Color color;
        bool scroling;
        int minut;
        int second;
        int tried;

        public frmMain()
        {
            InitializeComponent();
        }

        public void SetEnviroment()
        {
            if (player.IsPlaying())
            {
                Text = lstPlaylist.Items[player.NowPlaying].SubItems[2].Text + " - " + lstPlaylist.Items[player.NowPlaying].SubItems[4].Text;
                lblPlaying.Text = lstPlaylist.Items[player.NowPlaying].SubItems[6].Text + " | " + GetTimeMinutsAndSeconds(player.GetSongLenght()) + " | " + lstPlaylist.Items[player.NowPlaying].SubItems[0].Text;
            }
            else
            {
                lblPlaying.Text = "";
                Text = "MCIplayer";
            }
            
        }

        public string GetTimeMinutsAndSeconds(int miliseconds)
        {
            second = miliseconds / 1000;
            minut = second / 60;
            return String.Format("{0:00}", (float)minut) + ":" + String.Format("{0:00}", (float)(second % 60));
        }

        public void InputItem(string s)
        {
            if (s.Length > 0)
            {
                MP3 workingMp3;
                FileInfo fFileInfo = new FileInfo(s);
                workingMp3 = new MP3(fFileInfo.DirectoryName, fFileInfo.Name);
                FileCommands.readMP3Tag(ref workingMp3);

                ListViewItem itm = new ListViewItem();
                itm.Text = workingMp3.fileFileName;
                itm.SubItems.Add(s);
                itm.SubItems.Add(workingMp3.id3Artist);
                itm.SubItems.Add(workingMp3.id3Title);
                itm.SubItems.Add(workingMp3.id3Album);
                itm.SubItems.Add(workingMp3.id3TrackNumber.ToString());
                itm.SubItems.Add(workingMp3.fileType);
                // TODO Implement: genre, duration

                lstPlaylist.Items.Add(itm);
            }
        }

        private bool play(int track)
        {
            player.Stop();
            player.Paused = false;
            if (player.Play(track))
            {
                tried = 0;
                trackBar.Maximum = player.GetSongLenght();
                timer.Enabled = true;
                lstPlaylist.Items[player.NowPlaying].Selected = true;
                SetEnviroment();
                return true;
            }
            else
            {
                tried++;
                return false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player = new Player(lstPlaylist);
            scroling = false;
            minut = 0;
            second = 0;
            timer.Enabled = false;
            tried = 0;

            if (player.Loop == true)
                btnLoop.Image = Properties.Resources.selected;
            if (player.Shuffle == true)
                btnShuffle.Image = Properties.Resources.selected;

            CheckColumnSize();
        }

#region SetEnviroment

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void CheckColumnSize()
        {
            if (lstPlaylist.Columns[0].Width > 0)
                btnFileName.Image = Properties.Resources.selected;
            else
                btnFileName.Image = null;

            if (lstPlaylist.Columns[1].Width > 0)
                btnPath.Image = Properties.Resources.selected;
            else
                btnPath.Image = null;

            if (lstPlaylist.Columns[2].Width > 0)
                btnArtist.Image = Properties.Resources.selected;
            else
                btnArtist.Image = null;

            if (lstPlaylist.Columns[3].Width > 0)
                btnTitle.Image = Properties.Resources.selected;
            else
                btnTitle.Image = null;

            if (lstPlaylist.Columns[4].Width > 0)
                btnAlbum.Image = Properties.Resources.selected;
            else
                btnAlbum.Image = null;

        }

        private void btnPlay_MouseHover(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play_on;
        }

        private void btnPlay_MouseLeave(object sender, EventArgs e)
        {
            btnPlay.BackgroundImage = Properties.Resources.play_off;
        }

        private void btnPause_MouseHover(object sender, EventArgs e)
        {
            btnPause.BackgroundImage = Properties.Resources.pause_on;
        }

        private void btnPause_MouseLeave(object sender, EventArgs e)
        {
            btnPause.BackgroundImage = Properties.Resources.pause_off;
        }

        private void btnStop_MouseHover(object sender, EventArgs e)
        {
            btnStop.BackgroundImage = Properties.Resources.stop_on;
        }

        private void btnStop_MouseLeave(object sender, EventArgs e)
        {
            btnStop.BackgroundImage = Properties.Resources.stop_off;
        }

        private void btnPrevious_MouseHover(object sender, EventArgs e)
        {
            btnPrevious.BackgroundImage = Properties.Resources.previus_on;
        }

        private void btnPrevious_MouseLeave(object sender, EventArgs e)
        {
            btnPrevious.BackgroundImage = Properties.Resources.previus_off;
        }

        private void btnNext_MouseHover(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Properties.Resources.next_on;
        }

        private void btnNext_MouseLeave(object sender, EventArgs e)
        {
            btnNext.BackgroundImage = Properties.Resources.next_off;
        }

        private void btnFileName_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[0].Width == 0)
            {
                lstPlaylist.Columns[0].Width = 60;
                btnFileName.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[0].Width = 0;
                btnFileName.Image = null;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[1].Width == 0)
            {
                lstPlaylist.Columns[1].Width = 60;
                btnPath.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[1].Width = 0;
                btnPath.Image = null;
            }
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[2].Width == 0)
            {
                lstPlaylist.Columns[2].Width = 60;
                btnArtist.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[2].Width = 0;
                btnArtist.Image = null;
            }
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[3].Width == 0)
            {
                lstPlaylist.Columns[3].Width = 60;
                btnTitle.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[3].Width = 0;
                btnTitle.Image = null;
            }
        }

        private void btnAlbum_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[4].Width == 0)
            {
                lstPlaylist.Columns[4].Width = 60;
                btnAlbum.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[4].Width = 0;
                btnAlbum.Image = null;
            }
        }

        private void btnTrackNumber_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[5].Width == 0)
            {
                lstPlaylist.Columns[5].Width = 60;
                btnTrackNumber.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[5].Width = 0;
                btnTrackNumber.Image = null;
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            if (lstPlaylist.Columns[6].Width == 0)
            {
                lstPlaylist.Columns[6].Width = 60;
                btnType.Image = Properties.Resources.selected;
            }
            else
            {
                lstPlaylist.Columns[6].Width = 0;
                btnType.Image = null;
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            if (player.Shuffle == false)
            {
                player.Shuffle = true;
                btnShuffle.Image = Properties.Resources.selected;
            }
            else
            {
                player.Shuffle = false;
                btnShuffle.Image = null;
            }
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (player.Loop == false)
            {
                player.Loop = true;
                btnLoop.Image = Properties.Resources.selected;
            }
            else
            {
                player.Loop = false;
                btnLoop.Image = null;
            }
        }

#endregion

        private void btnPlay_Click(object sender, EventArgs e)
        {
            tried = 0;
            if (player.Paused)
            {
                player.Pause();
                SetEnviroment();
            }
            else
            {
                for (int i = 0; i < lstPlaylist.Items.Count; i++)
                {
                    if (lstPlaylist.Items[i].Selected == true)
                    {
                        play(i);
                        break;
                    }
                }
                if (lstPlaylist.Items.Count != 0 && !player.IsPlaying())
                {
                    play(0);
                }
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            player.Pause();
            if(player.Paused)
            {
                lblPlaying.Text = "Paused";
                Text = "MCIplayer";
            }
            else
                SetEnviroment();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int track;
            player.Stop();
            if (lstPlaylist.Items.Count > 0)
            {
                // Not the best solution for this problem, guess i have to change 
                // the whole GetSong method to make it work 
                track = player.GetSong(true);
                while (play(track) != true && tried < lstPlaylist.Items.Count)
                {
                    if (player.Shuffle)
                        track = player.GetSong(true);
                    else
                    {
                        if (track != 0)
                            play(track--);
                        else
                        {
                            track = lstPlaylist.Items.Count - 1;
                            play(track);
                        }
                    }

                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int track;
            player.Stop();
            if (lstPlaylist.Items.Count > 0)
            {
                // Not the best solution for this problem, guess i have to change 
                // the whole GetSong method to make it work 
                // Here the same problem, I could make a method for this part 
                // because I'm using the same code, but this problem must be solved 
                // somehow different
                track = player.GetSong(false);
                while (play(track) != true && tried < lstPlaylist.Items.Count)
                {
                    if (player.Shuffle)
                        track = player.GetSong(true);
                    else
                    {
                        if (track != lstPlaylist.Items.Count - 1)
                            play(track++);
                        else
                        {
                            track = 0;
                            play(track);
                        }
                    }

                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Stop();
            tried = 0;
            timer.Enabled = false;
            txtTime.Text = "00:00 / 00:00";
            trackBar.Value = 0;
            SetEnviroment();
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);

                for (int i = 0; i < s.Length; i++)
                {
                    InputItem(s[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Your input was not in the appropriate form. \nError: " + ex.Message, "Wrong input", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void lstPlaylist_DoubleClick(object sender, EventArgs e)
        {
            for (int i = 0; i < lstPlaylist.Items.Count; i++)
            {
                if (lstPlaylist.Items[i].Selected == true)
                {
                    player.Stop();
                    play(i);
                }
            }
        }


        private void lstPlaylist_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            CheckColumnSize();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstPlaylist.Font = fontDialog1.Font;
                font = fontDialog1.Font;
            }
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                lstPlaylist.ForeColor = colorDialog1.Color;
                color = colorDialog1.Color;
            }
        }

        private void addSongsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";
            openFileDialog1.Filter = "mp3 (*mp3)|*mp3|wma (*wma)|*.wma|wav (*wav)|*.wav|All (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 0;

            openFileDialog1.InitialDirectory = "MyDocuments";

            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                InputItem(openFileDialog1.FileName);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!player.IsStopped() && player.IsPlaying())
            {
                if (player.IsPlaying() || player.Paused)
                {
                    try
                    {
                        txtTime.Text = GetTimeMinutsAndSeconds(player.GetCurentMilisecond()) + " / " + GetTimeMinutsAndSeconds(player.GetSongLenght());
                        if (scroling != true)
                            trackBar.Value = player.GetCurentMilisecond();
                    }
                    catch (Exception ex)
                    {
                        player.Stop();
                    }
                }
                else if (!player.Paused)
                {
                    txtTime.Text = "00:00 / 00:00";
                    trackBar.Value = 0;
                }
            }
            else if (!player.Paused)
                btnNext_Click(sender, e);
        }

        private void trackBar_MouseDown(object sender, MouseEventArgs e)
        {
            scroling = true;
        }

        private void trackBar_MouseUp(object sender, MouseEventArgs e)
        {
            scroling = false;
            player.SetPosition(trackBar.Value);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Close();
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            player.SetVolume(trbVolume.Value);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.SetBalance(trbBalance.Value);
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMute.Checked)
            {
                trbVolume.Enabled = false;
                trbBalance.Enabled = false;
                player.SetVolume(0);
            }
            else
            {
                trbVolume.Enabled = true;
                trbBalance.Enabled = true;
                player.SetVolume(trbVolume.Value);
            }

        }
    }

}
