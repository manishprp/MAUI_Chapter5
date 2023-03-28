using Chapter5Exercise2.ViewModel.ExpenseManagerViewModel;

namespace Chapter5Exercise2;

public partial class MainPage : ContentPage
{

	private ExpenseManagerViewModel _expenseManagerViewModel;
	public MainPage()
	{
		InitializeComponent();
		_expenseManagerViewModel = (ExpenseManagerViewModel)BindingContext;

    }

    
}

