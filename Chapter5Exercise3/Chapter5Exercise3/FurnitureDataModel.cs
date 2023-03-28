using System.Collections.ObjectModel;

namespace Chapter5Exercise3
{
    public class FurnitureDataModel
    {
        public string Source { get; set; }
        public string Name { get; set; }
        public ObservableCollection<TrendingDataModel> Trending { get; set; }
        public int ItemCount { get; set; }
        public FurnitureCategory FurnitureCategory { get; set; }
    }
}
