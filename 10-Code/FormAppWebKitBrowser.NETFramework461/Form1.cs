using System;
using System.Windows.Forms;

namespace FormAppWebKitBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.webKitBrowser1.Navigate(textBox1.Text.Trim());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uri = @"file:///G:/ACSharp/AHelloDotNet_DG/10-Code/FormAppWebKitBrowser.NETFramework461/Src/Test.html";
            textBox1.Text = uri;
            this.webKitBrowser1.Navigate(uri);
        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            string domTitle = webKitBrowser1.DocumentTitle;
            string domText = webKitBrowser1.DocumentText;
            richTextBox1.Text = domTitle + "\n\n" + domText;
        }

        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string domText = webKitBrowser1.DocumentText;
            richTextBox1.Text = domText;
        }
    }
}
