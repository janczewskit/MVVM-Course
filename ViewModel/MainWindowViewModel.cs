using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace MVVM_1.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly string _defaultNameText = "Podaj imię";
        private readonly string _defaultSurnameText = "Podaj nazwisko";

        #region Propeties

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

        public ICommand ValidateCommand { get; set; }

        #endregion

        #region Constructors

        public MainWindowViewModel()
        {
            ValidateCommand = new DelegateCommand(ValidateAction);
            //(ValidateAction);
        }

        #endregion

        #region Actions

        private void ValidateAction()
        {
            bool validationResult = Name != _defaultNameText 
                && Surname != _defaultSurnameText;
            if (!validationResult)
            {
                MessageBox.Show("Błąd, nie wypełniłeś wszystkich pól");
                return;
            }
            MessageBox.Show("Brawo, poprawnie wypełniony formularz!");
        }

        #endregion
    }
}
