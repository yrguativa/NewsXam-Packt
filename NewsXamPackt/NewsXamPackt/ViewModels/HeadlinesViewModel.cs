using NewsXamPackt.Models;
using NewsXamPackt.Services;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using Xamarin.Forms;

namespace NewsXamPackt.ViewModels
{
    public class HeadlinesViewModel : ViewModel
    {
        private readonly NewsService NewsService;
        public NewsResult CurrentNews { get; set; }
        public HeadlinesViewModel(NewsService newsService) => NewsService = newsService;
        public async Task Initialize(string scope)
        {
            var resolvedScope = scope.ToLower() switch
            {
                "local" => NewsScope.Local,
                "global" => NewsScope.Global,
                "headlines" => NewsScope.Headlines,
                _ => NewsScope.Headlines
            };
            await Initialize(resolvedScope);
        }
        public async Task Initialize(NewsScope scope)
        {
            CurrentNews = await NewsService.GetNews(scope);
        }
        public ICommand ItemSelected => new Command(async (selectedItem) =>
        {
            var selectedArticle = selectedItem as Article;
            var url = HttpUtility.UrlEncode(selectedArticle.Url);
            // Placeholder for more code later on
        });
    }
}

