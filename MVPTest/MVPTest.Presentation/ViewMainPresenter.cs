using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Presentation
{
    public class ViewMainPresenter:IViewMainPresenter
    {
        private readonly IViewMain _view;
        private readonly IApplicationController _appController;

        public ViewMainPresenter(IViewMain view,IApplicationController appController)
        {
            _view = view;
            _appController = appController;
            _view.Presenter = this;
        }
        public IViewMain View
        {
            get { return _view; }
            
        }

        public void RunSimpleForm()
        {
            _appController.RunSimpleForm();
        }
    }
}
