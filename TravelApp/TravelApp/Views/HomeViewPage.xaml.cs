
using Xamarin.Forms;

namespace TravelApp.Views
{

    public partial class HomeViewPage : TabbedPage
    {
        public HomeViewPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}