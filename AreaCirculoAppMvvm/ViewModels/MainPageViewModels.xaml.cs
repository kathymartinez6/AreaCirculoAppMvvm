using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace AreaCirculoAppMvvm.ViewModels;

    public class MainPageViewModel : MainPageViewModelBase, INotifyPropertyChanged
    {
        public const double PI = 3.1415926535897931;

        private string _radius;
        public string Radius
        {
            get => _radius;
            set
            {
                _radius = value;
                OnPropertyChanged();
            }
        }

        private string _result;
        public string Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged();
            }
        }

        public ICommand CalculateAreaCommand { get; }
        public ICommand ClearFieldsCommand { get; }

    public MainPageViewModel()
        {
            CalculateAreaCommand = new Command(CalculateArea);
            ClearFieldsCommand = new Command(ClearFields);
        }

        private void CalculateArea()
        {
            if (double.TryParse(Radius, out double radius))
            {
                double area = PI * radius * radius;
                Result = $"Área: {area:F2}";
            }
            else
            {
                Result = "Por favor, ingresa un valor válido.";
            }
        }

        private void ClearFields()
        {
            Radius = string.Empty;
            Result = string.Empty;
        }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}
    