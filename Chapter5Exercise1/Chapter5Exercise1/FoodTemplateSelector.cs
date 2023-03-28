using Microsoft.Maui.Controls;

namespace Chapter5Exercise1.FoodTemplateSelector
{
    public class FoodTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WithNewDataTemplate { get; set; }
        public DataTemplate WithoutNewDataTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var Recipe = (DishDataModel)item;
            var cal = int.Parse(Recipe.Calories.ToString());
            if(cal<160)
            {
                return WithoutNewDataTemplate;
            }
            else
            {
                return WithNewDataTemplate;
            }
        }
    }
}
