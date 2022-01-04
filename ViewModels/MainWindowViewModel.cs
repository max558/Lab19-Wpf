using Lab19___WpfApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab19___WpfApp.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged ([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private double numRadius;
        public double NumRadius
        {
            get => numRadius;
            set
            {
                numRadius = value;
                OnPropertyChanged();
            }
        }

        private double circumference;
        public double Circumference
        {
            get => circumference;
            set
            {
                circumference = value;
                OnPropertyChanged();
            }
        }

        private double areaCircle;
        public double AreaCircle
        {
            get => areaCircle;
            set
            {
                areaCircle = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalcCommand { get; }
        private void OnCalcCommandExecute (object p)
        {
            Circumference = Circle.LengthCircle(numRadius);
            AreaCircle = Circle.SquareCircle(numRadius);
        }

        public MainWindowViewModel()
        {
            CalcCommand = new RelayCommand(OnCalcCommandExecute, null) ;
        }
    }
}
