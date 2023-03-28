using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Exercise3.TemplateSelector
{
    public class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate OutOfStockTemplate { get; set; }
        public DataTemplate InStockTemplate { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var objectItem = (TrendingDataModel)item;
            if (objectItem.IsOutOfStock)
            {
                return OutOfStockTemplate;
            }
            return InStockTemplate;
        }
    }
}
