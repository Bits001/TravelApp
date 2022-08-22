using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp.ViewModels.Base
{
    public class ViewModelBase : BindableObject
    {
        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }
    }
}
