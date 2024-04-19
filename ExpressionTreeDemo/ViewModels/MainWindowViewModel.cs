using ExpressionTreeDemo.Common;
using ExpressionTreeDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExpressionTreeDemo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            EmployeeList = DataBase.GetEmployees();
        }

        public BaseCommand Command_Fun
        {
            get { return new BaseCommand(Command_Fun_Executed); }
        }

        private void Command_Fun_Executed(object obj)
        {
            string str = obj.ToString();
            switch (str)
            {
                case "submit":
                    OnSubmit();
                    break;
                default:
                    break;
            }
        }

        private void OnSubmit()
        {
            EmployeeList = FilterEmployees(Name, MinAge, MaxAge, Gender, MinSalary, MaxSalary, IsMarried).ToObservableCollection();
        }

        private IEnumerable<Employee> FilterEmployees(string name, int minAge, int maxAge, Gender gender, double minSalary, double maxSalary, bool isMarried)
        {
            Expression? currentExpression = default!;
            
            var employeeParameter = Expression.Parameter(typeof(Employee));

        }

        #region Data Binding
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _minAge;
        public int MinAge
        {
            get => _minAge;
            set
            {
                _minAge = value;
                OnPropertyChanged(nameof(MinAge));
            }
        }

        private int _maxAge;
        public int MaxAge
        {
            get => _maxAge;
            set
            {
                _maxAge = value;
                OnPropertyChanged(nameof(MaxAge));
            }
        }

        private Gender _gender;
        public Gender Gender
        {
            get => _gender;
            set
            {
                _gender = value;
                OnPropertyChanged(nameof(Gender));
            }
        }
        private double _minSalary;
        public double MinSalary
        {
            get => _minSalary;
            set
            {
                _minSalary = value;
                OnPropertyChanged(nameof(MinSalary));
            }
        }

        private double _maxSalary;
        public double MaxSalary
        {
            get => _maxSalary;
            set
            {
                _maxSalary = value;
                OnPropertyChanged(nameof(MaxSalary));
            }
        }

        private bool _isMarried;
        public bool IsMarried
        {
            get => _isMarried;
            set
            {
                _isMarried = value;
                OnPropertyChanged(nameof(IsMarried));
            }
        }

        private ObservableCollection<Employee> _employeeList;
        public ObservableCollection<Employee> EmployeeList
        {
            get => _employeeList;
            set
            {
                _employeeList = value;
                OnPropertyChanged(nameof(EmployeeList));
            }
        }
        #endregion
    }
}
