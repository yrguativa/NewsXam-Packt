
using NewsXamPackt.ViewModels;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsXamPackt.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeadlinesView : ContentPage
    {
        public HeadlinesView()
        {
            InitializeComponent();
            Task.Run(async () => await Initialize("Headlines"));
        }
        public HeadlinesView(string scope)
        {
            InitializeComponent();
            Title = $"{scope} news";
            Task.Run(async () => await Initialize(scope));
        }
        private async Task Initialize(string scope)
        {
            var viewModel = Resolver.Resolve<HeadlinesViewModel>();
            BindingContext = viewModel;
            await viewModel.Initialize(scope);
        }
    }
}