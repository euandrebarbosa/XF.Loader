using Xamarin.Forms;

namespace XF.Loader
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            this.BindingContext = new ViewModels.MainPageViewModel();
		}
	}
}
