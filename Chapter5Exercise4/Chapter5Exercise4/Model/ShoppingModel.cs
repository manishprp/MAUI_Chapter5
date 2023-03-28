using Chapter5Exercise4.DataModel;
using System.Collections.ObjectModel;
using System.Linq;

namespace Chapter5Exercise4.Model
{
    public class ShoppingModel
    {
        public ObservableCollection<CategoryDataModel> CategoryDataModel { get; set; }
        public ObservableCollection<ClothesDataModel> ClothesAllDataModel { get; set; }
        public ObservableCollection<ClothesDataModel> ClothesMenDataModel { get; set; }
        public ObservableCollection<ClothesDataModel> ClothesWomenDataModel { get; set; }
        public ObservableCollection<ClothesDataModel> ClothesSportsDataModel { get; set; }
        public ObservableCollection<ClothesDataModel> ClothesWinterDataModel { get; set; }
        public ClothesCategoryEnum ClothesCategoryEnum { get; set; }
        public ShoppingModel() 
        {
            CategoryDataModel = new ObservableCollection<CategoryDataModel>();
            ClothesAllDataModel = new ObservableCollection<ClothesDataModel>();
            ClothesMenDataModel = ClothesAllDataModel.Where(x => x.IsMen == true).ToList());
            ClothesWomenDataModel = new ObservableCollection<ClothesDataModel>(CategoryDataModel[0].Clothes.Where(x => x.IsWomen == true).ToList());
            ClothesSportsDataModel = new ObservableCollection<ClothesDataModel>(CategoryDataModel[0].Clothes.Where(x => x.IsSports == true).ToList());
            ClothesWinterDataModel = new ObservableCollection<ClothesDataModel>(CategoryDataModel[0].Clothes.Where(x => x.IsWinter == true).ToList());
        }

        private void FillInDataInitially()
        {
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Collins", ImageSource = "shirt", IsFavourite = false, IsMen = true, IsSports = false, IsWinter = true, IsWomen = true, Price = "RS 50000" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Roadster", ImageSource = "shirt", IsFavourite = false, IsMen = true, IsSports = true, IsWinter = false, IsWomen = false, Price = "RS 6000" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Siyarams", ImageSource = "shirt", IsFavourite = false, IsMen = true, IsSports = false, IsWinter = true, IsWomen = false, Price = "RS 8000" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Peter England", ImageSource = "shirt", IsFavourite = false, IsMen = true, IsSports = false, IsWinter = false, IsWomen = false, Price = "RS 300" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Polar Bear", ImageSource = "shirt", IsFavourite = false, IsMen = true, IsSports = true, IsWinter = false, IsWomen = false, Price = "RS 56000" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Regal", ImageSource = "shirt", IsFavourite = false, IsMen = false, IsSports = true, IsWinter = false, IsWomen = true, Price = "RS 800" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Kasturi", ImageSource = "shirt", IsFavourite = false, IsMen = false, IsSports = true, IsWinter = false, IsWomen = true, Price = "RS 500" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Pankudi", ImageSource = "shirt", IsFavourite = false, IsMen = false, IsSports = false, IsWinter = true, IsWomen = true, Price = "RS 100" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Sangam", ImageSource = "shirt", IsFavourite = false, IsMen = false, IsSports = true, IsWinter = true, IsWomen = true, Price = "RS 50" });
            ClothesAllDataModel.Add( new ClothesDataModel() { Name = "Louis Vuitton", ImageSource = "shirt", IsFavourite = false, IsMen = false, IsSports = true, IsWinter = false, IsWomen = true, Price = "RS 10" });

            CategoryDataModel.Add(new CategoryDataModel() { ClothesCategoryEnum = ClothesCategoryEnum.All,CategoryName = "All" });
            CategoryDataModel.Add(new CategoryDataModel() { ClothesCategoryEnum = ClothesCategoryEnum.Men, CategoryName = "Men" });
            CategoryDataModel.Add(new CategoryDataModel() { ClothesCategoryEnum = ClothesCategoryEnum.Women, CategoryName = "Women"});
            CategoryDataModel.Add(new CategoryDataModel() { ClothesCategoryEnum = ClothesCategoryEnum.Sports, CategoryName = "Sports" });
            CategoryDataModel.Add(new CategoryDataModel() { ClothesCategoryEnum = ClothesCategoryEnum.Winter, CategoryName = "Winter" });
        }
        /**/
        public void GetClothesForCategory()
        {
           
            switch (ClothesCategoryEnum)
            {
                case ClothesCategoryEnum.All:
                   // ClothesAllDataModel = CategoryDataModel[0].Clothes;
                    break;
                    case ClothesCategoryEnum.Men:
                    ClothesAllDataModel = ClothesMenDataModel;
                    break;
                    case ClothesCategoryEnum.Winter:
                    ClothesAllDataModel = ClothesWinterDataModel;
                    break;
                    case ClothesCategoryEnum.Sports:
                    ClothesAllDataModel = ClothesSportsDataModel;
                    break;
                    case ClothesCategoryEnum.Women:
                    ClothesAllDataModel = ClothesWomenDataModel;
                    break;
            }
        }
    }
}
