using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Threading;
using System.Runtime.InteropServices;

namespace vidlooper
{
    public partial class Form1 : Form
    {
        
        public TimeSpan TimeoutToHide { get; private set; }
        public DateTime LastMouseMove { get; private set; }
        public bool IsHidden { get; private set; }
        bool firstplay = false;
        public string prevvid = "";
        public string vidnamefull = "";
        public List<string> vid = new List<string>();
        public List<string> vidloc = new List<string>();
        public List<string> vidloc1 = new List<string>();
        static string userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        public struct POINT
        {
            public int X;
            public int Y;

            public static implicit operator Point(POINT point)
            {
                return new Point(point.X, point.Y);
            }
        }
        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out POINT lpPoint);
        public static Point GetCursorPosition()
        {
            POINT lpPoint;
            GetCursorPos(out lpPoint);


            return lpPoint;
        }
        
        Thread stvid;
        
        Thread checkit2;

        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(new IgnoreMouseClickMessageFilter(this, axWindowsMediaPlayer1));
            TimeoutToHide = TimeSpan.FromSeconds(5);
            this.CenterToScreen();
            this.MaximizeBox = false;
            timer1.Enabled = true;
            timer1.Start();
            axWindowsMediaPlayer1.stretchToFit = true;
            axWindowsMediaPlayer1.settings.autoStart = true;
            findvid();
            if (Properties.Settings.Default.checkbox == true)
            {
                autostartcheckBox.Checked = true;
            }
            else
            {
                autostartcheckBox.Checked = false;
            }
            if(Properties.Settings.Default.checkbox2 == true)
            {
                mutecheckBox.Checked = true;
            }
            else
            {
                mutecheckBox.Checked = false;
            }
            if (Properties.Settings.Default.checkbox3 == true)
            {
                checkBox1.Checked = true;
                
            }
            else
            {
                checkBox1.Checked = false;
            }
            
            
        }

        public void findvid()
        {
            try
            {


                if (Properties.Settings.Default.vidlocation == "")
                {
                    string dmpath1 = @"Videos";
                    string dmpathog = Path.Combine(userProfile, dmpath1);
                    Properties.Settings.Default.vidlocation = dmpathog;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                }
                vidlocationtextBox.Text = Properties.Settings.Default.vidlocation;
                if (Directory.Exists(Properties.Settings.Default.vidlocation))
                {
                    string path = @"" + Properties.Settings.Default.vidlocation;
                    DirectoryInfo dirv = new DirectoryInfo(Properties.Settings.Default.vidlocation);
                    FileInfo[] neededFiles21 = dirv.GetFiles("*.mov", SearchOption.TopDirectoryOnly);
                    foreach (FileInfo file in neededFiles21)
                    {
                        vid.Add(file.Name);
                        vidloc.Add(file.FullName);
                    }
                    FileInfo[] neededFiles22 = dirv.GetFiles("*.mp4", SearchOption.TopDirectoryOnly);
                    foreach (FileInfo file in neededFiles22)
                    {
                        vid.Add(file.Name);
                        vidloc.Add(file.FullName);
                    }
                    FileInfo[] neededFiles23 = dirv.GetFiles("*.avi", SearchOption.TopDirectoryOnly);
                    foreach (FileInfo file in neededFiles23)
                    {
                        vid.Add(file.Name);
                        vidloc.Add(file.FullName);
                    }
                    foreach (var name in vid)
                    {
                        vidlistBox.Items.Add(name);

                    }
                    if (Properties.Settings.Default.checkbox == true)
                    {
                        stvid = new Thread(new ThreadStart(startvids));
                        stvid.Name = "vids";
                        stvid.Start();
                    }
                    toolStripStatusLabel1.Text = "Directory found. Files have been added to the Q.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Directory does not Exist. Check path!";
                }
            }
            catch
            {
                toolStripStatusLabel1.Text = "Directory does not Exist. Check path!";
            }
           

        }

        public void fulsrcenable()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            checkBox1.Visible = false;
            mutecheckBox.Visible = false;
            startbutton.Visible = false;
            stopbutton.Visible = false;
            applybutton.Visible = false;
            cancelbutton.Visible = false;
            browsebutton.Visible = false;
            tflbutton.Visible = false;
            axWindowsMediaPlayer1.enableContextMenu = false;
            statusStrip1.Visible = false;
            vidlistBox.Visible = false;
            vidlocationtextBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            autostartcheckBox.Visible = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    
                    this.Bounds = scrn.Bounds;
                    
                }
            }
            checkit2 = new Thread(new ThreadStart(checkcusror));
            checkit2.Name = "checkit2";
            checkit2.Start();
        }

        public void fulsrcdisable()
        {
           
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    
                    this.Size = new Size(711, 517);
                    this.CenterToScreen();
                }
            }

            try
            {

                if (checkit2.IsAlive)
                {
                    checkit2.Abort();
                }
            }
            catch
            {

            }
            axWindowsMediaPlayer1.enableContextMenu = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            axWindowsMediaPlayer1.uiMode = "full";
            axWindowsMediaPlayer1.Dock = DockStyle.None;
            axWindowsMediaPlayer1.Location = new Point(12, 12);
            axWindowsMediaPlayer1.Size = new Size(426, 329);
            startbutton.Visible = true;
            stopbutton.Visible = true;
            applybutton.Visible = true;
            cancelbutton.Visible = true;
            tflbutton.Visible = true;
            browsebutton.Visible = true;
            statusStrip1.Visible = true;
            vidlistBox.Visible = true;
            vidlocationtextBox.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            autostartcheckBox.Visible = true;
            mutecheckBox.Visible = true;
            checkBox1.Visible = true;
        }

        private void applybutton_Click(object sender, EventArgs e)
        {
            
            if (Properties.Settings.Default.vidlocation != vidlocationtextBox.Text)
            {
                vidlistBox.Items.Clear();
                vid.Clear();
                vidloc.Clear();
                vidloc1.Clear();
                Properties.Settings.Default.vidlocation = vidlocationtextBox.Text;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
                findvid();
            }
            
           
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            vidlocationtextBox.Text = Properties.Settings.Default.vidlocation;
        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            vidfolderBrowserDialog.Description = "Browse for Video Folder";
            vidfolderBrowserDialog.ShowDialog();
            var vidpath = vidfolderBrowserDialog.SelectedPath;
            if (vidpath != "")
            {
                vidlocationtextBox.Text = vidpath;
            }
            
            
        }

        private void vidlocationtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                if(firstplay == true)
                {
                    firstplay = false;
                    if (Properties.Settings.Default.checkbox3 == true)
                    {                                               
                        fulsrcenable();
                    }
                }
                
            }
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                if(axWindowsMediaPlayer1.URL != null)
                {
                    try
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.play();
                        
                    }
                    catch
                    {

                    }
                    
                    if (mutecheckBox.Checked == true)
                    {
                        axWindowsMediaPlayer1.settings.mute = true;
                    }
                    else
                    {
                        axWindowsMediaPlayer1.settings.mute = false;
                    }
                    
                    
                }
                
            }
                if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                
                if (vidloc1.Count == 0)
                {

                    foreach (var name in vidloc)
                    {

                       
                        vidloc1.Add(name);


                    }
                    foreach (var name in vid)
                    {
                        vidlistBox.Items.Add(name);

                    }
                }
                foreach (var name in vidloc1)
                {

                   
                    vidnamefull = name;
                    axWindowsMediaPlayer1.URL = vidnamefull;
                    
                }

                string tp = vidnamefull.Replace(Properties.Settings.Default.vidlocation + @"\", "");
                vidlistBox.SelectedItem = tp;
                toolStripStatusLabel1.Text = tp;
                vidlistBox.Items.Remove(prevvid);
                prevvid = tp;
                foreach (var name in vidloc1)
                {

                    if (name == vidnamefull)
                    {
                        vidloc1.Remove(name);
                        break;
                    }


                }
                
            }

        }


        public void checkcusror()
        {
            Point xy;
            xy = MousePosition;
        facem:
            
            try
            {
                Invoke(new Action(() =>
                {
                    
                    if (axWindowsMediaPlayer1.Dock == DockStyle.Fill)
                    {
                        if (MousePosition != xy)
                        {
                            if (IsHidden == true)
                            {
                                if (axWindowsMediaPlayer1.Bounds.Contains(PointToClient(GetCursorPosition())))
                                {
                                    exitfulscrbutton.Visible = true;
                                    LastMouseMove = DateTime.Now;
                                    Invoke(new Action(() => Cursor.Show()));                  //  use this for clickable
                                    Invoke(new Action(() => Cursor.Clip = Rectangle.Empty));
                                    IsHidden = false;
                                    
                                }
                                
                            }
                        }
                        

                    }
                    else
                    {
                        exitfulscrbutton.Visible = false;
                    }
                }
                ));

            }
            catch
            {

            }
            xy = MousePosition;
            Thread.Sleep(5);
            
            goto facem;
        }


        private void startbutton_Click(object sender, EventArgs e)
        {
            
            stvid = new Thread(new ThreadStart(startvids));
            stvid.Name = "vids";
            stvid.Start();
            
        }

        public void startvids()
        {
            
            if(vidloc1.Count == 0)
            {

                foreach (var name in vidloc)
                {

                    
                    vidloc1.Add(name);
                 

                }

            }
            foreach (var name in vidloc1)
            {

                
                vidnamefull = name;
                axWindowsMediaPlayer1.URL = vidnamefull;
               
            }
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                
                
                string tp = vidnamefull.Replace(Properties.Settings.Default.vidlocation + @"\", "");
                Invoke(new Action(() => vidlistBox.SelectedItem = tp));
                toolStripStatusLabel1.Text = tp;
                if (prevvid != "")
                {
                    Invoke(new Action(() => vidlistBox.Items.Remove(prevvid)));
                    
                }
                prevvid = tp;
            }

            foreach (var name in vidloc1)
            {
                
                if(name == vidnamefull)
                {
                    vidloc1.Remove(name);
                    break;
                }   
                

            }
            firstplay = true;
        }


        private void autostartcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(autostartcheckBox.Checked)
            {
                Properties.Settings.Default.checkbox = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.checkbox = false;
                Properties.Settings.Default.Save();
            }
        }

        private void stopbutton_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (stvid.IsAlive)
                {
                    stvid.Abort();
                }
            }
            catch
            {

            }
            try
            { 
                axWindowsMediaPlayer1.Ctlcontrols.stop();
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            try
            {
                if (stvid.IsAlive)
                {
                    stvid.Abort();
                }
                
            }
            catch
            {

            }
            
            try
            {

                if (checkit2.IsAlive)
                {
                    checkit2.Abort();
                }
            }
            catch
            {

            }
        }

        private void tflbutton_Click(object sender, EventArgs e)
        {
            fulsrcenable();
        }

        private void exitfulscrbutton_Click(object sender, EventArgs e)
        {
            fulsrcdisable();
        }

        private void exitfulscrbutton_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void exitfulscrbutton_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void mutecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (mutecheckBox.Checked == true)
            {
                axWindowsMediaPlayer1.settings.mute = true;
                Properties.Settings.Default.checkbox2 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                axWindowsMediaPlayer1.settings.mute = false;
                Properties.Settings.Default.checkbox2 = false;
                Properties.Settings.Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                
                Properties.Settings.Default.checkbox3 = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                
                Properties.Settings.Default.checkbox3 = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            TimeSpan elaped = DateTime.Now - LastMouseMove;
            if (elaped >= TimeoutToHide && !IsHidden)
            {
                if (axWindowsMediaPlayer1.Dock == DockStyle.Fill)
                {
                    exitfulscrbutton.Visible = false;
                    if (axWindowsMediaPlayer1.Bounds.Contains(PointToClient(GetCursorPosition())))
                    {
                        
                        Cursor.Clip = axWindowsMediaPlayer1.Bounds;                                               
                        IsHidden = true;
                        Cursor.Hide();
                    }                  
                    
                    
                }
            }
        }
    }
    class IgnoreMouseClickMessageFilter : IMessageFilter
    {
        private Control parent { get; set; }
        private Control target { get; set; }

        public IgnoreMouseClickMessageFilter(Control parent, Control target)
        {
            this.parent = parent;
            this.target = target;
        }

        public bool PreFilterMessage(ref Message messageBeforeFiltering)
        {
            const Boolean FilterTheMessageOut = true;
            const Boolean LetTheMessageThrough = false;

            if (IsNull(parent)) return LetTheMessageThrough;
            if (IsNull(target)) return LetTheMessageThrough;
            if (WasNotClickedOnTarget(parent, target)) return LetTheMessageThrough;
            if (MessageContainsAnyMousebutton(messageBeforeFiltering)) return FilterTheMessageOut;
            return LetTheMessageThrough;
        }

        private bool MessageContainsAnyMousebutton(Message message)
        {
            if (message.Msg == 0x202) return true; /* WM_LBUTTONUP*/
            if (message.Msg == 0x203) return true; /* WM_LBUTTONDBLCLK*/
            if (message.Msg == 0x204) return true; /* WM_RBUTTONDOWN */
            if (message.Msg == 0x205) return true; /* WM_RBUTTONUP */
            return false;
        }

        private bool WasNotClickedOnTarget(Control parent, Control target)
        {
            Control clickedOn = parent.GetChildAtPoint(Cursor.Position);
            if (IsNull(clickedOn)) return true;
            if (AreEqual(clickedOn, target)) return false;
            return true;
        }

        private bool AreEqual(Control controlA, Control controlB)
        {
            if (controlA == controlB) return true;
            return false;
        }

        private bool IsNull(Control control)
        {
            if (control == null) return true;
            return false;
        }
    }
}
