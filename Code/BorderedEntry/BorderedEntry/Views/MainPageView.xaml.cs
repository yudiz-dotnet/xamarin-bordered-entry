using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BorderedEntry.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageView : ContentPage
	{
		public MainPageView ()
		{
			InitializeComponent ();
            BindingContext = new ViewModels.MainPageViewModel();
		}
	}
}