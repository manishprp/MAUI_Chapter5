using Android.Graphics;
using Chapter5Exercise2.DataModel;
using System.Collections.ObjectModel;

namespace Chapter5Exercise2.Model
{
    public class ExpenseManagerModel
    {
        public double Amount { get; set; }
        public string ExpenseName { get; set; }
        public double TotalAmount { get; set; }
        public ExpenseData ToAddOrDelete { get; set; }
        public ObservableCollection<ExpenseData> ExpenseDataList { get; set; }
        public ExpenseManagerModel()
        {
            ToAddOrDelete = new ExpenseData();
        }
        public void AddExpense()
        {
            ToAddOrDelete.ExpenseAmount = Amount;
            ToAddOrDelete.ExpenseName = ExpenseName;
        }

        public void Summation()
        {
            TotalAmount = ExpenseDataList.Sum(x => x.ExpenseAmount);
        }

        public void Delete()
        {
            ExpenseDataList.Remove(ToAddOrDelete);
            Summation();
        }
    }
}
