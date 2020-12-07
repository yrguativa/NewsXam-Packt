using Xamarin.Forms;

namespace NewsXamPackt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Bootstrapper.Initialize();
            //MainPage = new MainPage();
            MainPage = Resolver.Resolve<MainShell>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
