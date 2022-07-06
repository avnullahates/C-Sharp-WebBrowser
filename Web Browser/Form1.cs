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

namespace Web_Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }         

        private void Form1_Load(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.google.com");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;

        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack(); 
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.google.com");
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate(textBox1.Text);

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            webBrowser.Stop();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void bBCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.nytimes.com");
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        private void cNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.latimes.com");
        }

        private void sanFranciscoChronicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.sfchronicle.com");

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void resToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser.DocumentTitle.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(webBrowser.DocumentText.ToString());
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
           
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.google.com");
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.yahoo.com");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.yandex.com");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           /* textBox1.Text = ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Url.ToString();

            string time2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            FileStream a = new FileStream("History.txt",FileMode.Append);
            StreamWriter write = new StreamWriter(a);
            write.Write( time2 + "/" + textBox1.Text + Environment.NewLine);
            write.Close();
            loadhistory();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = webBrowser.StatusText;
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                toolStripProgressBar1.Maximum = Convert.ToInt32(e.MaximumProgress);
                toolStripProgressBar1.Value = Convert.ToInt32(e.CurrentProgress);
            }
            catch (Exception)
            {

                toolStripProgressBar1.Minimum = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadhistory();
            this.button4.Click += new EventHandler(this.button4_Click);
            History.Visible = true;
        }
        private void loadhistory()
        {
            History.Items.Clear();
            StreamReader file = new StreamReader("History.txt");
            while(!file.EndOfStream)
            {
                History.Items.Add(file.ReadLine());

            }
            file.Close();

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter("History.txt");
            file.Write("");
            file.Close();
            loadhistory();
            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Click += new EventHandler(this.button6_Click);
            History.Visible = false;
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
           
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.facebook.com");
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.twitter.com");
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.youtube.com");
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.instagram.com");
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
           
            ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Navigate("www.shsu.edu");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                webBrowser.Navigate(textBox1.Text);
            }
        }

        private void favoritiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }
        Boolean st=false;
        private void bunifuImageButton15_Click(object sender, EventArgs e)
        {
            //this.bunifuImageButton15.Click += new EventHandler(this.bunifuImageButton15_Click);
            
            string fav;
            fav = textBox1.Text;
           favoritiesToolStripMenuItem.DropDownItems.Add(textBox1.Text); 

           
            
        }
        
        private void bunifuImageButton16_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount-1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("www.google.com");
            webTab.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(newtab_navigated);
            webTab.DocumentCompleted += WebTab_DocumentCompleted;

        }
        private void newtab_navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
           string url = ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).Url.AbsoluteUri;
            tabControl1.SelectedTab.Text = ((System.Windows.Forms.WebBrowser)(this.tabControl1.SelectedTab.Controls[0])).DocumentTitle;
            textBox1.Text = url.ToString();

            string time2 = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            FileStream a = new FileStream("History.txt", FileMode.Append);
            StreamWriter write = new StreamWriter(a);
            write.Write(time2 + "/" + textBox1.Text + Environment.NewLine);
            write.Close();
            loadhistory();
        }
            WebBrowser webTab = null;
        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            webBrowser.Navigate(textBox1.Text);
        }

        private void bunifuImageButton17_Click(object sender, EventArgs e)
        {
            
            tabControl1.Controls.Remove(this.tabControl1.SelectedTab);

                }
    }
}
