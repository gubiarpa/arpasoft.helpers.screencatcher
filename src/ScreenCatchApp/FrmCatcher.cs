using ScreenCatchApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenCatchApp
{
    public partial class FrmCatcher : Form
    {
        private FrmMain Parent;

        public FrmCatcher(FrmMain parent)
        {
            Parent = parent;
            InitializeComponent();
        }

        private void FrmCatcher_LocationChanged(object sender, EventArgs e)
        {
            SetMeasures();
        }

        private void FrmCatcher_Resize(object sender, EventArgs e)
        {
            SetMeasures();
        }

        private void SetMeasures()
        {
            Parent.GetMeasures(new CatchMeasures()
            {
                Top = this.Top,
                Left = this.Left,
                Height = this.Height,
                Width = this.Width
            });
        }
    }
}
