
using System.ComponentModel; 
using System.Windows.Input; 
using WpfApp3.Model; 

namespace WpfApp3.ViewModel
{
    class MyViewModel : INotifyPropertyChanged // объявление класса MyViewModel, который реализует интерфейс INotifyPropertyChanged для уведомления об изменениях свойств
    {
        private bool isSquareSelected; 
        private bool isTriangleSelected; 
        private double area; 
        private readonly AreaCalculator areaCalculator; 

        public bool IsSquareSelected 
        {
            get { return isSquareSelected; } 
            set 
            {
                isSquareSelected = value; 
                if (isSquareSelected)
                {
                    CalculateSquareArea(); 
                }
                RaisePropertyChanged("IsSquareSelected"); // вызов метода RaisePropertyChanged для уведомления об изменении свойства
            }
        }

        public bool IsTriangleSelected 
        {
            get { return isTriangleSelected; } 
            set 
            {
                isTriangleSelected = value; 
                if (isTriangleSelected)
                {
                    CalculateTriangleArea(); 
                }
                RaisePropertyChanged("IsTriangleSelected"); // вызов метода RaisePropertyChanged для уведомления об изменении свойства
            }
        }

        public double Area
        {
            get { return area; } 
            set 
            {
                area = value; 
                RaisePropertyChanged("Area"); 
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }

        public MyViewModel() 
        {
            IsSquareSelected = false; 
            IsTriangleSelected = false; 
            Area = 0; 
            areaCalculator = new AreaCalculator(); 
        }

        private void CalculateSquareArea() 
        {
            Area = areaCalculator.CalculateSquareArea(3); 
        }

        private void CalculateTriangleArea()
        {
            Area = areaCalculator.CalculateEquilateralTriangleArea(3); 
        }
    }
}
