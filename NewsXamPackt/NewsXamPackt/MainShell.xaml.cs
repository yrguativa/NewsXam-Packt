
using NewsXamPackt.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NewsXamPackt
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainShell : Shell
    {
        public MainShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("articleview", typeof(ArticleView));
        }
    }
}