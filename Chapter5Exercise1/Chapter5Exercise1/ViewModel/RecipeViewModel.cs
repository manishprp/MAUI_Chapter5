using Chapter5Exercise1.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chapter5Exercise1.ViewModel.RecipeViewModel
{
    public class RecipeViewModel : INotifyPropertyChanged
    {
        private RecipeModel _recipeModel;

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<DishDataModel> _recipes;
        public ObservableCollection<DishDataModel> Recipes { get { return _recipes; } set { _recipes = value; NotifyPropertyChanged();}}
        public RecipeViewModel()
        {
            _recipeModel = new RecipeModel();
            Recipes = _recipeModel.Recipes;
        }
        public void NotifyPropertyChanged([CallerMemberName] string propertyname = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
