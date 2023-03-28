using Chapter5Exercise2.DataModel;
using Chapter5Exercise2.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Chapter5Exercise2.ViewModel.ExpenseManagerViewModel
{
    public class ExpenseManagerViewModel : INotifyPropertyChanged
    {
        private double _amount;
        private string _expenseName;
        private double _totalAmount;
        public ICommand DeleteCommand { get; private set; }
        public double TotalAmount
        {
            get { return _totalAmount; }
            set
            {
                _totalAmount = value;
                NotifyPropertyChanged();
            }
        }
        public double Amount
        {
            get { return _amount; }
            set { 
                    _amount = value;
                    NotifyPropertyChanged();
                }
        }
        public string ExpenseName
        {
            get { return _expenseName; }
            set
            {
                _expenseName = value;
                NotifyPropertyChanged();
            }
        }
        private ObservableCollection<ExpenseData> _expenseDataList ;
        public ObservableCollection<ExpenseData> ExpenseDataList
        {
            get { return _expenseDataList; }
            set
            {
                _expenseDataList = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand AddExpenseCommand { get; private set; }
        private ExpenseManagerModel _expenseManagerModel;
        public ExpenseManagerViewModel()
        {
            ExpenseDataList = new ObservableCollection<ExpenseData>();
            AddExpenseCommand = new Command(AddExpense);
            _expenseManagerModel = new ExpenseManagerModel();
            DeleteCommand = new Command(Delete);
        }

        private void Delete(object obj)
        {
            var item = (ExpenseData)obj;
            _expenseManagerModel.ToAddOrDelete = item;
            ExpenseDataList.Remove(_expenseManagerModel.ToAddOrDelete);
            _expenseManagerModel.ExpenseDataList = ExpenseDataList;
            _expenseManagerModel.Summation();
            TotalAmount = _expenseManagerModel.TotalAmount;
        }

        private void AddExpense(object obj)
        {
            _expenseManagerModel.Amount = Amount;
            _expenseManagerModel.ExpenseName = ExpenseName;
            _expenseManagerModel.AddExpense();
            ExpenseDataList.Add(_expenseManagerModel.ToAddOrDelete);
            _expenseManagerModel.ExpenseDataList = ExpenseDataList;
            _expenseManagerModel.Summation();
            TotalAmount = _expenseManagerModel.TotalAmount;
        }

        private void NotifyPropertyChanged([CallerMemberName] string PropertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}
