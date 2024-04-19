using ExpressionTreeDemo.Common;
using ExpressionTreeDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
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

            }
        }

        #region Data Binding


        #endregion

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
    }
}
