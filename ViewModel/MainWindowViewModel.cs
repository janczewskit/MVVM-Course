
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace MVVM_1.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly string _defaultNameText = "Podaj imię";
        private readonly string _defaultSurnameText = "Podaj nazwisko";

        #region Propeties

        private string _result;

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                OnPropertyChanged(() => Result);
            }
        }


        private string _name;

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : _defaultNameText;
            }
            set
            {
                _name = value == string.Empty ? _defaultNameText : value;
                //metoda OnPropertyChanged informuje widok o zmianach wartości
                OnPropertyChanged(() => Name);
            }
        }

        private string _surname;

        public string Surname
        {
            get
            {
                return !string.IsNullOrEmpty(_surname) ? _surname : _defaultSurnameText;
            }
            set
            {
                _surname = value == string.Empty ? _defaultSurnameText : value;
                OnPropertyChanged(() => Surname);
            }
        }

        #endregion

        #region Commands

        //komenda musi być publicznie dostępnym akcesorem
        public ICommand ValidateCommand { get; set; }

        #endregion

        #region Constructors

        public MainWindowViewModel()
        {
            //przypisanie akcji do komendy
            ValidateCommand = new DelegateCommand(ValidateAction);
        }

        #endregion

        #region Actions

        private void ValidateAction()
        {
            bool validationResult = Name != _defaultNameText 
                && Surname != _defaultSurnameText;
            if (!validationResult)
            {
                Result = "Błąd, nie wypełniłeś wszystkich pól";
                return;
            }
            Result = "Brawo, poprawnie wypełniony formularz!";
        }

        #endregion
    }
}
