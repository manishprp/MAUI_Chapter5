using Chapter5Exercise4.ViewModel.ShoppingViewModel;

namespace Chapter5Exercise4;

public partial class MainPage : ContentPage
{
	private ShoppingViewModel _shoppingViewModel;

	public MainPage()
	{
		InitializeComponent();
		_shoppingViewModel = (ShoppingViewModel)BindingContext;
	}

	
}

