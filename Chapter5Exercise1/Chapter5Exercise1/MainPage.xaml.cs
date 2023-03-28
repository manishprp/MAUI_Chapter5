using Chapter5Exercise1.ViewModel.RecipeViewModel;

namespace Chapter5Exercise1;

public partial class MainPage : ContentPage
{
	private RecipeViewModel _recipeViewModel;
	public MainPage()
	{
		InitializeComponent();
		_recipeViewModel = (RecipeViewModel)BindingContext;
    }
}

