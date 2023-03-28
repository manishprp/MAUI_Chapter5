using System.Collections.ObjectModel;

namespace Chapter5Exercise3.Model
{
    public class FurnitureModel
    {
        public ObservableCollection<FurnitureDataModel> FurnitureDataModel { get; set; }
        private ObservableCollection<TrendingDataModel> _tableData;
        private ObservableCollection<TrendingDataModel> _chairData;
        private ObservableCollection<TrendingDataModel> _cupboardData;
        private ObservableCollection<TrendingDataModel> _sofaData;
        public FurnitureModel() 
        {
            
            FillTableData();
            FillChairData();
            FillCupBoardData();
            FillSofaData();
            SetUpData();
        }

        private void FillSofaData()
        {
            _sofaData = new ObservableCollection<TrendingDataModel>()
            {
                new TrendingDataModel(){Name = "Wooden Sofa", CurrentPrice = "60000 RS", PreviousPrice= "80000 RS", ImageSource = "sofa", IsOutOfStock = true}
            };
        }

        private void FillCupBoardData()
        {
            _cupboardData = new ObservableCollection<TrendingDataModel>();
        }

        private void FillChairData()
        {
            _chairData = new ObservableCollection<TrendingDataModel>()
            {
                new TrendingDataModel(){Name = "Ivonne Chair", CurrentPrice = "3000 RS", PreviousPrice= "4000 RS", ImageSource = "chair_new", IsOutOfStock = false},
                new TrendingDataModel(){Name = "Office Chair", CurrentPrice = "200 RS", PreviousPrice= "8000 RS", ImageSource = "chair_new", IsOutOfStock = true},
                new TrendingDataModel(){Name = "Arm Chair", CurrentPrice = "5000 RS", PreviousPrice= "9000 RS", ImageSource = "chair_new", IsOutOfStock = true},
                new TrendingDataModel(){Name = "School Chair", CurrentPrice = "5000 RS", PreviousPrice= "6000 RS", ImageSource = "chair_new", IsOutOfStock = false},
                new TrendingDataModel(){Name = "Bus Chair", CurrentPrice = "2100 RS", PreviousPrice= "3000 RS", ImageSource = "chair_new", IsOutOfStock = false}
            };
        }

        private void FillTableData()
        {
            _tableData = new ObservableCollection<TrendingDataModel>()
            {
                new TrendingDataModel(){Name = "Office Table", CurrentPrice = "3000 RS", PreviousPrice= "4000 RS", ImageSource = "table", IsOutOfStock = false},
                new TrendingDataModel(){Name = "Wooden Table", CurrentPrice = "6000 RS", PreviousPrice= "8000 RS", ImageSource = "table", IsOutOfStock = true}
            };
        }

        private void SetUpData()
        {
            FurnitureDataModel = new ObservableCollection<FurnitureDataModel>()
            {
                new FurnitureDataModel(){Name="Chair", Source="chair_new", Trending = _chairData, ItemCount = _chairData.Count,FurnitureCategory= FurnitureCategory.Chair},
                new FurnitureDataModel(){Name="Table", Source="table", Trending = _tableData, ItemCount = _tableData.Count,FurnitureCategory= FurnitureCategory.Table},
                new FurnitureDataModel(){Name="Sofa", Source="sofa", Trending = _sofaData, ItemCount = _sofaData.Count,FurnitureCategory= FurnitureCategory.Sofa},
                new FurnitureDataModel(){Name="Cupboard", Source="cupboard", Trending = _cupboardData, ItemCount = _cupboardData.Count,FurnitureCategory= FurnitureCategory.Cupboard}
            };
        }
       
    }
}
