using Chapter5Exercise3.ViewModel.FurnitureViewModel;

namespace Chapter5Exercise3;

public partial class MainPage : ContentPage
{
	private FurnitureViewModel _furnitureViewModel;
	public MainPage()
	{
		InitializeComponent();
		_furnitureViewModel = (FurnitureViewModel)BindingContext;
    }
}

