using Chapter5Exercise3.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5Exercise3.ViewModel.FurnitureViewModel
{
    public class FurnitureViewModel : INotifyPropertyChanged
    {
        public ICommand SelectionChangedCommmand { get; private set; }
        private FurnitureModel _furnitureModel;
        public FurnitureDataModel SelectedFurnitureDataModel { get; set; }
        private ObservableCollection<FurnitureDataModel> _furnitureDataModel;
        private ObservableCollection<TrendingDataModel> _trendingDataModel;
        public ObservableCollection<FurnitureDataModel> FurnitureDataModel { get { return _furnitureDataModel; } set { _furnitureDataModel = value; NotifyPropertyChanged(); } }  
        public ObservableCollection<TrendingDataModel> TrendingDataModel { get { return _trendingDataModel; } set { _trendingDataModel = value; NotifyPropertyChanged(); } }  
        public FurnitureViewModel()
        {
            SelectedFurnitureDataModel = new FurnitureDataModel();
            SelectionChangedCommmand = new Command(SelectionChanged);
            _furnitureModel = new FurnitureModel();
            FurnitureDataModel = _furnitureModel.FurnitureDataModel;
            SelectedFurnitureDataModel = FurnitureDataModel[0];
            TrendingDataModel = FurnitureDataModel[0].Trending;
        }

        private void SelectionChanged(object obj)
        {
            var category = SelectedFurnitureDataModel.FurnitureCategory;
            TrendingDataModel = FurnitureDataModel.Where(x=>x.FurnitureCategory== category).FirstOrDefault().Trending;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string property ="")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
