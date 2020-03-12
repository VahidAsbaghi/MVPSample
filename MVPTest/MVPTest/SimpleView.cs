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
    public partial class SimpleView : Form, IViewSimple
    {
        private IViewSimplePresenter _presenter;

        public SimpleView()
        {
            InitializeComponent();
        }

        public IViewSimplePresenter Presenter
        {
            get { return _presenter; }
            set
            {
                if (_presenter == null)
                {
                    _presenter = value;
                }

            }
        }
    }
}
