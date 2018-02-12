

namespace Lands
{
    using Lands.Views;
    using Xamarin.Forms;

    public partial class App : Application
	{
        #region Ctor
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new LoginPage());
        }
        #endregion

        #region Metodos
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
