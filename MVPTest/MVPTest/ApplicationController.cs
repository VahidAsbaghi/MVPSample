using MVPTest.Presentation;

namespace MVPTest
{
    public class ApplicationController:IApplicationController
    {
        public void RunSimpleForm()
        {
            var view = new SimpleView();
            var presenter=new ViewSimplePresenter(view,this);
            view.ShowDialog();
        }
    }
}
