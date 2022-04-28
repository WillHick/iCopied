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

            this.CenterToScreen();
            //ClipboardClearing.Start();
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
            MoreInfoPanel.Hide();
            SecurityMenu.Hide();
            CountMenu.Hide();
            MoreMenu.Hide();            
        }

        //Counter Ints
        private int _addtxtcount = 0;
        private int _addimgcount = 0;
        private int _addtotalcount = 0;

        //Clearing Ints
        private int _detectclearcount = 0;

        //Timer Ticks
        private void GetText_Tick(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                CopiedTextOutput.Items.Add("  • " + System.DateTime.Now.ToShortTimeString() + " - " + Clipboard.GetText());

                this._addtxtcount++;                
                this.CopiedPhraseInt.Text = "Copied Phrases : " + this._addtxtcount.ToString();

                this._addtotalcount++;
                this.SessionTotalInt.Text = "Session Total : " + this._addtotalcount.ToString();

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
                this.CopiedImagesInt.Text = "Copied Images : " + this._addimgcount.ToString();

                this._addtotalcount++;
                this.SessionTotalInt.Text = "Session Total : " + this._addtotalcount.ToString();

                //Clear After Grabbing
                Clipboard.Clear();
            }
        }
        private void ClipboardClearing_Tick(object sender, EventArgs e)
        {
            //Always Clearing
            Clipboard.Clear();
        }
    }
}
