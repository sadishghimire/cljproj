using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;
using System.IO;
using AxWMPLib;
using System.Media;
using System.Threading;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using TagLib;
using WinFormAnimation;

namespace cljproj
{
    public partial class autoplaynext : Form
    {
       
        private Rectangle browsebtnOriginalRect;
        private Rectangle panel0riginalRect;
        private Rectangle labeloriginalRect ;
        private Rectangle musiclistboxOriginalRect; 
        private Rectangle clearbtn4OriginalRect ;
        private Rectangle prevbtnOriginalRect ;
        private Rectangle playbtnOriginalRect ;
        private Rectangle nextOriginalRect;
        private Rectangle progressbarOriginalRect ;
        private Rectangle axwindowOriginalRect;
        private Rectangle durationOriginalRect;
        private Rectangle fulldurationOriginalRect;                    
        private Rectangle musicpicoriginal;
        private Rectangle muteunmuteoriginal ;
        private Rectangle replayonofforiginal  ;
        private Rectangle button1original;
        private Rectangle volumeeoriginal;
        private Rectangle vollbloriginal;
        private Rectangle progpaneloriginal;
        private Rectangle panel2original;
        private Rectangle playbuttondiaplayoriginal;
        private Rectangle panel1original;
        private Rectangle formOriginalSize;
        private Rectangle authororiginal;
        private Rectangle dateoriginal;
        
        //boolean variables
        private bool Isreplayenabled = false;
        private bool Isautoplaynextenabled = true;
        private int currenttrackindex = 0;
        
        



        public autoplaynext()
        {
            InitializeComponent();
            play.Visible = false;
            pause.Visible = false;
            volumee.Value = 25;
            volumee.Minimum = 0;
            volumee.Maximum = 100;
            mute_unmute.BackgroundImage = unmute.BackgroundImage;
            replayonoff.BackgroundImage=replayoff.BackgroundImage;
            playbuttondisplay.Text = "Waiting for songs...";
            vollbl.Text = "25%";
            Author.Text= "Author:";
            year.Text = "Year:N/A";
            MessageBox.Show("welcome kapil");
            
        }

       

        string[] paths, files;
        int i;
        private int currentindex = 0;
       
        //listbox
        private void musiclistbox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
            string currentsongname = axWindowsMediaPlayer3.Ctlcontrols.currentItem.name;
            playbuttondisplay.Text = "Playing:" + currentsongname;
            playpausebtn.BackgroundImage= play.BackgroundImage;
            
            playtimer.Start();
            try
            {
                var file = TagLib.File.Create(paths[musiclistbox.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                musicpic.Image = Image.FromStream(new MemoryStream(bin));
                year.Text = ("Year:"+file.Tag.Year);
            }
            catch(IndexOutOfRangeException r)
            {
                musicpic.BackgroundImage = musicpic.BackgroundImage;
            }
        }

        //browse
        private void Browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter= "MP3 Files (*.mp3,*.m4a,*.wav,*.aac)|*.mp3;*.m4a;*.wav;*.aac";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (i = 0; i < files.Length; i++)
                {
                    musiclistbox.Items.Add(files[i]);
                }
            }
        }
        //browse button ends here
        //media player
        

        //progressbar
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        //list of songs in listbox are arranged in a circular queue form
        //previous 
        private void previousbtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (musiclistbox.SelectedIndex == null && musiclistbox.Items.Count > 0)
                {
                    musiclistbox.SelectedIndex = 0;
                    axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                }

                if ((musiclistbox.SelectedIndex) > 0 && (musiclistbox.Items.Count) > 0)
                {
                    musiclistbox.SelectedIndex = musiclistbox.SelectedIndex - 1;
                   
                }

                //selection goes to last song after first song
                else if (musiclistbox.SelectedIndex == 0)
                {
                    musiclistbox.SelectedIndex = musiclistbox.Items.Count - 1;
                   
                }

                //common play function
                string listboxitem = musiclistbox.SelectedItem.ToString();
                axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                axWindowsMediaPlayer3.Ctlcontrols.play();
                playbuttondisplay.Text = "Playing.";
                

                //fullduration
                if (musiclistbox.SelectedItem != null)
                {
                    double fullDuration = axWindowsMediaPlayer3.currentMedia.duration;
                    fulldurationlabel.Text = $"{TimeSpan.FromSeconds(fullDuration):mm\\:ss}";
                }
                else { }

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //previous end here
        //next
        private void nextbtn_Click(object sender, EventArgs e)
        {
            try
            {   if(musiclistbox.SelectedIndex == null && musiclistbox.Items.Count > 0)
                {
                    musiclistbox.SelectedIndex = 0;
                    axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                }
                else if (musiclistbox.SelectedIndex < musiclistbox.Items.Count - 1)
                {
                    musiclistbox.SelectedIndex++;
                    double fullDuration = axWindowsMediaPlayer3.currentMedia.duration;
                    axWindowsMediaPlayer3.URL= paths[musiclistbox.SelectedIndex];
                    fulldurationlabel.Text = $"{TimeSpan.FromSeconds(fullDuration):mm\\:ss}";
                }
                //selection goes to first song after last song
                else if (musiclistbox.SelectedIndex == musiclistbox.Items.Count - 1)
                {
                    musiclistbox.SelectedIndex = 0;
                    axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                    double fullDuration = axWindowsMediaPlayer3.currentMedia.duration;
                    fulldurationlabel.Text = $"{TimeSpan.FromSeconds(fullDuration):mm\\:ss}";
                }

                string listboxitem = musiclistbox.SelectedItem.ToString();
                axWindowsMediaPlayer3.Ctlcontrols.play();
            }
            catch (NullReferenceException   )
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(ArgumentOutOfRangeException )
            {
                MessageBox.Show("No music to play", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //next ends here
        //clear button
        private void clear_Click(object sender, EventArgs e)
        {
            musiclistbox.Items.Clear();
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            playbuttondisplay.Text = "Music Cleared";
        }
        //clear ends here
        private void play_Click(object sender, EventArgs e)
        {
            play.Visible = false;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            pause.Visible = false;
        }

       

        private void fulldurationlabel_Click(object sender, EventArgs e)
        {

        }

        //playpause
        private void playpausebtn_Click(object sender, EventArgs e)
        {
            try
            {
                //this button will play and pause using two states

                
                    if (axWindowsMediaPlayer3.playState == WMPPlayState.wmppsPlaying)
                    {
                        playpausebtn.BackgroundImage = pause.BackgroundImage;
                        axWindowsMediaPlayer3.Ctlcontrols.pause();
                        string currentsongname = axWindowsMediaPlayer3.Ctlcontrols.currentItem.name;
                        playbuttondisplay.Text = "Paused:" + currentsongname;
                    }
                    else if(axWindowsMediaPlayer3.playState== WMPPlayState.wmppsPaused)
                    {
                        playpausebtn.BackgroundImage = play.BackgroundImage;
                        axWindowsMediaPlayer3.Ctlcontrols.play();
                        string currentsongname = axWindowsMediaPlayer3.Ctlcontrols.currentItem.name;
                        playbuttondisplay.Text = "Playing:" + currentsongname;
                    }
                
                else if (musiclistbox.Items.Count > 0 && musiclistbox.SelectedIndex == null)
                {                   
                    musiclistbox.SelectedIndex = 0;
                    axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                    axWindowsMediaPlayer3.Ctlcontrols.play();
                }
                else if(musiclistbox.Items.Count==0)
                {
                    MessageBox.Show("No Music In Musiclist Box", "Sorry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //playpause button ends here

        //stop button
        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.stop();
            progressBar1.Value = 0;
        }

        //Resize design in runtime
        private void Form1_Load_1(object sender, EventArgs e)
        {
            formOriginalSize = new Rectangle(this.Location.X,this.Location.Y,this.Size.Width,this.Size.Height);
            panel0riginalRect = new Rectangle(panel.Location.X, panel.Location.Y,panel.Width, panel.Height);
            labeloriginalRect = new Rectangle(label2.Location.X, label2.Location.Y, label2.Width, label2.Height);
            musiclistboxOriginalRect = new Rectangle(musiclistbox.Location.X, musiclistbox.Location.Y, musiclistbox.Width, musiclistbox.Height);
            browsebtnOriginalRect = new Rectangle(Browsebtn.Location.X, Browsebtn.Location.Y, Browsebtn.Width, Browsebtn.Height);
            clearbtn4OriginalRect = new Rectangle(clear.Location.X, clear.Location.Y, clear.Width, clear.Height);
            prevbtnOriginalRect = new Rectangle(previousbtn.Location.X, previousbtn.Location.Y, previousbtn.Width, previousbtn.Height);
            playbtnOriginalRect = new Rectangle(playpausebtn.Location.X, playpausebtn.Location.Y, playpausebtn.Width, playpausebtn.Height);
            nextOriginalRect = new Rectangle(nextbtn.Location.X, nextbtn.Location.Y, nextbtn.Width, nextbtn.Height);
            progressbarOriginalRect = new Rectangle(progressBar1.Location.X, progressBar1.Location.Y, progressBar1.Width, progressBar1.Height);
            axwindowOriginalRect = new Rectangle(axWindowsMediaPlayer3.Location.X, axWindowsMediaPlayer3.Location.Y, axWindowsMediaPlayer3.Width, axWindowsMediaPlayer3.Height);
            durationOriginalRect = new Rectangle(durationlabel.Location.X, durationlabel.Location.Y, durationlabel.Width, durationlabel.Height);
            fulldurationOriginalRect = new Rectangle(fulldurationlabel.Location.X, fulldurationlabel.Location.Y, fulldurationlabel.Width, fulldurationlabel.Height);
            
            muteunmuteoriginal = new Rectangle(mute_unmute.Location.X, mute_unmute.Location.Y, mute_unmute.Width, mute_unmute.Height);
            replayonofforiginal= new Rectangle(replayonoff.Location.X, replayonoff.Location.Y, replayonoff.Width, replayonoff.Height);
            button1original= new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            volumeeoriginal = new Rectangle(volumee.Location.X, volumee.Location.Y, volumee.Width, volumee.Height);
            vollbloriginal = new Rectangle(vollbl.Location.X, vollbl.Location.Y, vollbl.Width, vollbl.Height);
            progpaneloriginal= new Rectangle(progpanel.Location.X, progpanel.Location.Y, progpanel.Width, progpanel.Height);
            panel2original= new Rectangle(panel2.Location.X, panel2.Location.Y, panel2.Width, panel2.Height);
            playbuttondiaplayoriginal= new Rectangle(playbuttondisplay.Location.X, playbuttondisplay.Location.Y, playbuttondisplay.Width, playbuttondisplay.Height);
            panel1original= new Rectangle(panel1.Location.X, panel1.Location.Y, panel1.Width, panel1.Height);
            musicpicoriginal=new Rectangle(musicpic.Location.X,musicpic.Location.Y,musicpic.Width,musicpic.Height);
            authororiginal=new Rectangle(Author.Location.X,Author.Location.Y, Author.Width,Author.Height);
            dateoriginal=new Rectangle(year.Location.X,year.Location.Y,year.Width,year.Height);
            
        }
        private void resizeControl(Rectangle r , Control c)
                {
            //calculation of ratio of height and width of form components with respect to the size of form
            float xRatio = (float)(this.Width) / (float)(formOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(formOriginalSize.Height);

            //new width,height and location with respect to form
            int newX = (int)(r.Location.X * xRatio) ;
            int newY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            resizeControl(panel0riginalRect, panel);
            resizeControl(labeloriginalRect, label2);
            resizeControl(musiclistboxOriginalRect, musiclistbox);
            resizeControl(browsebtnOriginalRect, Browsebtn);
            resizeControl(clearbtn4OriginalRect, clear);
            resizeControl(prevbtnOriginalRect, previousbtn);
            resizeControl(playbtnOriginalRect, playpausebtn);
            resizeControl(nextOriginalRect, nextbtn);
            resizeControl(progressbarOriginalRect, progressBar1);
            resizeControl(axwindowOriginalRect, axWindowsMediaPlayer3);
            resizeControl(durationOriginalRect, durationlabel);
            resizeControl(fulldurationOriginalRect, fulldurationlabel);
            resizeControl(muteunmuteoriginal,mute_unmute);
            resizeControl(replayonofforiginal,replayonoff);
            resizeControl(button1original,button1);
            resizeControl(volumeeoriginal,volumee);
            resizeControl(vollbloriginal,vollbl);
            resizeControl(progpaneloriginal,progpanel);
            resizeControl(panel2original,panel2);
            resizeControl(playbuttondiaplayoriginal, playbuttondisplay);
            resizeControl(panel0riginalRect, panel1);
            resizeControl(musicpicoriginal, musicpic);
            resizeControl(authororiginal, Author);
            resizeControl(dateoriginal, year);
        }

        //volume button
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer3.settings.volume = volumee.Value;
            vollbl.Text = volumee.Value.ToString() + "%";
        }

        //code for mute/unmute button
        private void mute_unmute_Click(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer3.settings.mute = !axWindowsMediaPlayer3.settings.mute;
            if (axWindowsMediaPlayer3.settings.mute)
            {
                mute_unmute.BackgroundImage=mute.BackgroundImage;
                vollbl.Text = "0%";
                
                //axWindowsMediaPlayer3.settings.volume = volumee.Minimum;

            }
            else
            {
                vollbl.Text = volumee.Value.ToString() + "%";
                mute_unmute.BackgroundImage = unmute.BackgroundImage;
                //axWindowsMediaPlayer3.settings.volume= volumee.Value;
            }
        }


        //function that handle the mouse click event when clicked to progressbar for skip 
        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer3.Ctlcontrols.currentPosition = axWindowsMediaPlayer3.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void playbuttondisplay_Click(object sender, EventArgs e)
        {

        }
       

            //displays music name to the button
            private void axWindowsMediaPlayer3_Enter(object sender, EventArgs e)
            { 
                if (axWindowsMediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                string currentsongname = axWindowsMediaPlayer3.Ctlcontrols.currentItem.name;
                playbuttondisplay.Text = "Playing:"+currentsongname;
                }
                else if (axWindowsMediaPlayer3.playState==WMPPlayState.wmppsMediaEnded)
                {
                playbuttondisplay.Text = "Waiting for music play";
                }
            }


        //audio replay on off
        private void replayonoff_Click(object sender, EventArgs e)
        {
            
            Isreplayenabled = !Isreplayenabled;
            axWindowsMediaPlayer3.settings.setMode("loop", Isreplayenabled);
            replayonoff.BackgroundImage = replayoff.BackgroundImage;


            // Update the button text to reflect the current replay state

            if (Isreplayenabled)
            {
                replayonoff.BackgroundImage=replayon.BackgroundImage;
                
            }
            else 
            {
                replayonoff.BackgroundImage = replayoff.BackgroundImage;
            }
        }

        private void musicpic_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer3_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            try
            {
                if (axWindowsMediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    // Get the current media item
                    var mediaItem = axWindowsMediaPlayer3.Ctlcontrols.currentItem;
                    Author.BackColor.ToFloat3D();

                    // Check if the media item has author information (You can use other properties like 'Author' or 'Creator' depending on your media files)
                    if (!string.IsNullOrEmpty(mediaItem.getItemInfo("Author")))
                    {
                        // Update the label or textbox with the author's name
                        Author.Text = "Author: " + mediaItem.getItemInfo("Author");
                    }
                    else
                    {
                        // If author information is not available, you can clear the label or textbox
                        Author.Text = "Author: N/A";

                    }
                }
                if(axWindowsMediaPlayer3.playState==WMPLib.WMPPlayState.wmppsMediaEnded)
                {
                    Thread.Sleep(2000);
                    musiclistbox.SelectedIndex++;

                    axWindowsMediaPlayer3.URL = paths[musiclistbox.SelectedIndex];
                    
                    axWindowsMediaPlayer3.Ctlcontrols.play();

                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("No music selected", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No music to play", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void year_Click(object sender, EventArgs e)
        {

        }

       

        private void playpausebtn_MouseHover(object sender, EventArgs e)
        {

        }
        //code for showing progressbar timespan and full duration and running duration of audio
        private void playtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (axWindowsMediaPlayer3.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    progressBar1.Maximum = (int)axWindowsMediaPlayer3.Ctlcontrols.currentItem.duration;
                    progressBar1.Value = (int)axWindowsMediaPlayer3.Ctlcontrols.currentPosition;

                }
                durationlabel.Text = axWindowsMediaPlayer3.Ctlcontrols.currentPositionString;
                fulldurationlabel.Text = axWindowsMediaPlayer3.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch (NullReferenceException) { }
        }       
    }
}

