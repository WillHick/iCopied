using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCopiedGit
{
    public partial class UIMain : Form
    {
        public UIMain()
        {
            InitializeComponent();
        }
        //On Load
        private void UIMain_Load(object sender, EventArgs e)
        {
            ToHide();
            TextCopyOn();
        }

        //Functions

        //Text Copy
        private void TextCopyOn()
        {
            GetText.Start();
        }
        private void TextCopyOff()
        {

        }
        //Image Copy
        private void ImageCopyOn()
        {

        }
        private void ImageCopyOff()
        {

        }
        //Hide On Load
        private void ToHide()
        {
            SecurityMenu.Hide();
            MoreMenu.Hide();
        }

        //Ints
        private int _addtxtcount = 0;
        private int _addimgcount = 0;
        private int _detectclearcount = 0;

        //Timer Ticks
        private void GetText_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CopiedTextOutput.Items.Add("  • " + System.DateTime.Now.ToShortTimeString() + " - " + Clipboard.GetText());

                this._addtxtcount++;
                //this.WordsCopiedInt.Text = "Words Copied : " + this._addtxtcount.ToString();

                //Clear After Grabbing
                Clipboard.Clear();
            }
        }
        private void GetImage_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                CopiedImageOutput.Image = Clipboard.GetImage();

                this._addimgcount++;
                //this.ImagesCopiedInt.Text = "Images Copied : " + this._addimgcount.ToString();

                //Clear After Grabbing
                Clipboard.Clear();
            }
        }
        private void ClipboardClearing_Tick(object sender, EventArgs e)
        {
            Clipboard.Clear();

            /*this._detectclearcount++;
            this.ClearedCountInt.Text = "Detected And Cleared : " + this._detectclearcount.ToString();*/
        }
    }
}
