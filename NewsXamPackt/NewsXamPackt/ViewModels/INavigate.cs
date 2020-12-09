using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewsXamPackt.ViewModels
{
    public interface INavigate
    {
        Task NavigateTo(string route);
        Task PushModal(Page page);
        Task PopModal();
    }
}
