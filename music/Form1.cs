using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            volume.Value = 100;
            axWindowsMediaPlayer1.settings.volume = volume.Value;

        }

        static List<string> paths, files;
        static bool play = false;
        static bool shuffle = false;
        static bool repeat = false;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //selected a song from the song list
        private void songs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (songs.SelectedIndex >= 0 & songs.SelectedIndex < paths.Count) 
            {
                axWindowsMediaPlayer1.URL = paths[songs.SelectedIndex];
                scroll.Value = 0; //reset the seekbar
                play = true;
            }
        }

        //play/pause button
        private void playPause_Click(object sender, EventArgs e)
        {
            if (play)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                play = false;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                play = true;
            }
        }

        //volume bar
        private void volume_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = volume.Value;
        }

        //seekbar
        private void scroll_Scroll(object sender, EventArgs e)
        {
            //scroll.Value goes from 0 - 5000
            if (songs.SelectedIndex >= 0)
            {
                double songLength = axWindowsMediaPlayer1.currentMedia.duration;
                axWindowsMediaPlayer1.Ctlcontrols.currentPosition = songLength * scroll.Value / 5000;
            }
        }

        //move forward seekbar every second
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {              
                try
                {
                    int moveForward = Convert.ToInt32(5000.0 / Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration));
                    if (scroll.Value + moveForward < 5000)
                    {
                        scroll.Value += moveForward;
                    }
                }
                catch
                {

                }
            }
        }

        //current song ended, goto next
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 1)
            {
                if (shuffle & songs.Items.Count > 1) //go to random song that is different from the current song
                {
                    var rand = new Random();
                    BeginInvoke(new Action(() =>
                    {
                        var prev = songs.SelectedIndex;
                        var tmp = rand.Next(songs.Items.Count);
                        while (tmp == prev)
                        {
                            tmp = rand.Next(songs.Items.Count);
                        }
                        songs.SelectedIndex = tmp;
                    }));
                }
                else if (repeat) //repeat current song
                {
                    BeginInvoke(new Action(() =>
                    {
                        var prev = songs.SelectedIndex;
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        songs.SelectedIndex = prev;
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        scroll.Value = 0;
                    }));
                }
                else if (songs.SelectedIndex != songs.Items.Count - 1) //move onto next song //otherwise go onto next song
                {
                    BeginInvoke(new Action(() =>
                    {
                        songs.SelectedIndex = songs.SelectedIndex + 1;
                    }));
                }
                else //last song, end
                {
                    play = false;
                    scroll.Value = 0;
                }
            }
        }

        //start repeat, turn off shuffle
        private void repeatSongs_Click(object sender, EventArgs e)
        {
            if (shuffle)
            {
                shuffle = false;
            }
            repeat = !repeat;
        }

        //start shuffle, turn off repeat
        private void shuffleSongs_Click(object sender, EventArgs e)
        {
            if (repeat)
            {
                repeat = false;
            }
            shuffle = !shuffle;
        }

        //adding new songs
        private void openSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (files is null)
                {
                    files = new List<string>();
                    paths = new List<string>();
                }
                int prev = files.Count;
                files.AddRange(ofd.SafeFileNames);
                paths.AddRange(ofd.FileNames);
                for (int i = prev; i < files.Count; i++)
                {
                    songs.Items.Add(files[i]); 
                }
            }
        }
    }
}
