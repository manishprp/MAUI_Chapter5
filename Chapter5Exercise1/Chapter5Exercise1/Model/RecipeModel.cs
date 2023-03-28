using System.Collections.ObjectModel;

namespace Chapter5Exercise1.Model
{
    public class RecipeModel
    {
        public ObservableCollection<DishDataModel> Recipes { get; set; }
        public RecipeModel()
        {
            Recipes = new ObservableCollection<DishDataModel>();
            SetUpData();
        }

        private void SetUpData()
        {
            Recipes.Add(new DishDataModel { Calories = 100, Name = "Khaman", Ratings = "4.6", Time = "15:23" });
            Recipes.Add(new DishDataModel { Calories = 120, Name = "Undhiyu", Ratings = "4.7", Time = "15:00" });
            Recipes.Add(new DishDataModel { Calories = 140, Name = "Churma", Ratings = "4.8", Time = "19:23" });
            Recipes.Add(new DishDataModel { Calories = 160, Name = "Dal chawal", Ratings = "4.9", Time = "20:23" });
            Recipes.Add(new DishDataModel { Calories = 180, Name = "Dahi Bhalle", Ratings = "3.6", Time = "24:23" });
            Recipes.Add(new DishDataModel { Calories = 199, Name = "Bhel puri", Ratings = "7.7", Time = "11:23" });
            Recipes.Add(new DishDataModel { Calories = 233, Name = "Pohe", Ratings = "4.8", Time = "09:23" });
            Recipes.Add(new DishDataModel { Calories = 299, Name = "Bajra Rotla", Ratings = "4.9", Time = "05:23" });
            Recipes.Add(new DishDataModel { Calories = 456, Name = "Kadhi Khichdi", Ratings = "4.5", Time = "23:23" });
            Recipes.Add(new DishDataModel { Calories = 200, Name = "Aloo Puri", Ratings = "4.5", Time = "13:23" });
        }
    }
}
