using ScreenCatchApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCatchApp
{
    public partial class FrmMain : Form
    {
        #region Properties
        private int _counter;
        private string _titleName;
        private CatchMeasures _catchedMeasures = new CatchMeasures();
        private FrmCatcher FrmCatcher;
        #endregion

        #region Constructor
        public FrmMain()
        {
            _counter = 1;
            _titleName = "Screen Catcher";
            FrmCatcher = null;
            InitializeComponent();
        }
        #endregion

        #region Exposed
        public void GetMeasures(CatchMeasures catchMeasures)
        {
            this.txtTop.Text = (_catchedMeasures.Top = catchMeasures.Top).ToString();
            this.txtLeft.Text = (_catchedMeasures.Left = catchMeasures.Left).ToString();
            this.txtHeight.Text = (_catchedMeasures.Height = catchMeasures.Height).ToString();
            this.txtWidth.Text = (_catchedMeasures.Width = catchMeasures.Width).ToString();
        }
        #endregion

        #region Events
        private void btnShowCatcher_Click(object sender, EventArgs e)
        {
            if (FrmCatcher == null)
            {
                btnShowCatcher.Enabled = false;
                FrmCatcher = new FrmCatcher(this);
                SetStyle(ControlStyles.UserPaint, true);
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                FrmCatcher.TransparencyKey = FrmCatcher.BackColor;
                FrmCatcher.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnCatch.Enabled = false;
        }

        private void btnSetPosition_Click(object sender, EventArgs e)
        {
            btnSetPosition.Enabled = txtTop.Enabled = txtLeft.Enabled = txtHeight.Enabled = txtWidth.Enabled = false;
            FrmCatcher.Close();
            btnCatch.Enabled = true;
        }

        private void btnCatch_Click(object sender, EventArgs e)
        {
            var path = txtFolder.Text;
            var format = ConfigurationManager.AppSettings["Format"].ToString();

            _counter = (int)this.numCounter.Value;
            var fullName = System.IO.Path.Combine(path, format + _counter.ToString("00") + ".bmp");
            this.Text = string.Format("{0} ({1})", _titleName, _counter.ToString("00"));
            this.numCounter.Value++;

            //ScreenCapture.CaptureScreen(CatchedMeasures);
            CaptureMyScreen(fullName, _catchedMeasures);
        }
        #endregion

        #region Auxiliar
        private void CaptureMyScreen(string fullName, CatchMeasures catchMeasures)
        {
            try
            {
                //Creating a new Bitmap objectx
                Bitmap captureBitmap = new Bitmap(catchMeasures.Width, catchMeasures.Height - 30, PixelFormat.Format32bppArgb);

                //Bitmap captureBitmap = new Bitmap(int width, int height, PixelFormat);
                //Creating a Rectangle object which will  
                //capture our Current Screen
                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;

                //Creating a New Graphics Object
                Graphics captureGraphics = Graphics.FromImage(captureBitmap);

                //Copying Image from The Screen
                //captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);
                captureGraphics.CopyFromScreen(catchMeasures.Left, catchMeasures.Top + 30, 0, 0, captureRectangle.Size);

                //Saving the Image File (I am here Saving it in My E drive).
                captureBitmap.Save(fullName, ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var folderDlg = new FolderBrowserDialog();
            var result = folderDlg.ShowDialog();
            folderDlg.ShowNewFolderButton = true;
            if (result == DialogResult.OK)
            {
                txtFolder.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }
        }
    }
}
