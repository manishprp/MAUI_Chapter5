using Chapter5Exercise4.DataModel;
using Chapter5Exercise4.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5Exercise4.ViewModel.ShoppingViewModel
{
    public class ShoppingViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<CategoryDataModel> _categoryDataModel;
        private ObservableCollection<ClothesDataModel> _clothesDataModel;
        public ICommand CategoryChangesCommand { get; private set; }
        private ShoppingModel _shoppingModel;
        private CategoryDataModel _selectedItem;
        public CategoryDataModel SelectedItem { get { return _selectedItem; } set { _selectedItem = value; NotifyPropertyChanged(); } }
        public ObservableCollection<CategoryDataModel> CategoryDataModel { get { return _categoryDataModel; } set { _categoryDataModel = value; NotifyPropertyChanged(); } }
        public ObservableCollection<ClothesDataModel> ClothesDataModel { get { return _clothesDataModel; } set { _clothesDataModel = value; NotifyPropertyChanged(); } }
        public ShoppingViewModel()
        {
            _shoppingModel = new ShoppingModel();
            CategoryChangesCommand = new Command(ClothesCategoryChanged);
            CategoryDataModel = _shoppingModel.CategoryDataModel;
            SelectedItem = CategoryDataModel.FirstOrDefault();
        }

        private void ClothesCategoryChanged(object obj)
        {
            _shoppingModel.ClothesCategoryEnum = SelectedItem.ClothesCategoryEnum;
            _shoppingModel.GetClothesForCategory();
            //SelectedItem.Clothes = _shoppingModel.ClothesAllDataModel;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string property= " ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
