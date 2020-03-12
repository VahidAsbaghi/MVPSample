using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPTest.Presentation;

namespace MVPTest
{
    public partial class ViewMain : Form, IViewMain
    {
        private IViewMainPresenter _viewMainPresenter;

        public IViewMainPresenter Presenter
        {
            get { return _viewMainPresenter; }
            set
            {
                if (_viewMainPresenter == null)
                {
                    _viewMainPresenter = value;
                }

            }

        }

        public ViewMain()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _viewMainPresenter.RunSimpleForm();
        }
    }
}
