using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Presentation
{
    public class ViewSimplePresenter:IViewSimplePresenter
    {
        private readonly IViewSimple _view;
        private readonly IApplicationController _appController;

        public ViewSimplePresenter(IViewSimple view, IApplicationController appController)
        {
            _view = view;
            _appController = appController;
            _view.Presenter = this;
        }

        public IViewSimple View
        {
            get { return _view; }
        }
    }
}
