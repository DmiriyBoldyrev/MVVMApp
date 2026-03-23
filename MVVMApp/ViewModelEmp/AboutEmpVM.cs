using MVVMApp.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMApp.ViewModelEmp
{
    class AboutEmpVM : Property
    {

        #region Название компании
        private Visibility _textBoxName = Visibility.Collapsed;
        private Visibility _textBlockName = Visibility.Visible;
        private string _textBoxRename = "Название вашей компании";
        private string _textBlockRename = "Название вашей компании";
        public string TextBoxRename
        {
            get => _textBoxRename;
            set
            {
                if (_textBoxRename != value)
                { _textBoxRename = value; OnPropertyChanged(); }
            }
        }
        public string TextBlockRename
        {
            get => _textBlockRename;
            set
            {
                if (_textBlockRename != value)
                { _textBlockRename = value;OnPropertyChanged(); }
            }
        }
        public Visibility TextBoxName {
            get => _textBoxName;
            set {
                if (_textBoxName != value) 
                { _textBoxName = value;OnPropertyChanged(); }
            }
        }

        public Visibility TextBlockName
        {
            get => _textBlockName;
            set
            {
                if (_textBlockName != value)
                { _textBlockName = value;OnPropertyChanged(); }
            }
        }

        public RelayCommand changeCommand { get; }
        public void changeCommandExecute(object p) {
            TextBlockName = TextBlockName == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
            
            TextBoxName = TextBoxName == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

            TextBlockRename = TextBoxRename;
        }
        public bool changeCommandCanExecute(object p) { return true; }
        #endregion
        #region Местонахождение
        private Visibility _textBlockLocation = Visibility.Visible;
        private Visibility _textBoxLocation = Visibility.Collapsed;
        private string _textBoxLocationRename = "Ваше местоположение";
        private string _textBlockLocationRename = "Ваше местоположение";


        public string TextBoxLocationRename {
            get => _textBoxLocationRename;
            set { if (_textBoxLocationRename != value) 
                { _textBoxLocationRename = value; OnPropertyChanged(); }
            } 
        }
        public string TextBlockLocationRename
        {
            get => _textBlockLocationRename;
            set
            {
                if (_textBlockLocationRename != value)
                { _textBlockLocationRename = value; OnPropertyChanged(); }
            }
        }
        public Visibility TextBlockLocation { get => _textBlockLocation;
            set { if(_textBlockLocation != value)
                { _textBlockLocation = value;OnPropertyChanged();  }
            } 
        }

        public Visibility TextBoxLocation
        {
            get => _textBoxLocation;
            set
            {
                if (_textBoxLocation != value)
                { _textBoxLocation = value; OnPropertyChanged(); }
            }
        }

        public RelayCommand changeLocatiobCommand { get; }
        public void changeLocationCommandExecute(object p) {
            TextBlockLocation = TextBlockLocation == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        
            TextBoxLocation = TextBoxLocation == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;

            TextBlockLocationRename = TextBoxLocationRename;
        }
        public bool changeLocationCommandCanExecute(object p) {  return true; }
        #endregion
        #region Сохранение изменений
        #endregion
        #region Изменить фото
        private object _image = "\\icons\\main.svg";
        private Visibility _imageVisibility = Visibility.Visible;
        private Visibility _boxChangeImage = Visibility.Collapsed;

        public Visibility ImageVisibility
        {
            get => _imageVisibility;
            set { if (_imageVisibility != value) 
                { _imageVisibility = value;OnPropertyChanged(); }
            }
        }
        public object Image { get => _image;

            set { if (_image != value)
                { _image = value;OnPropertyChanged(); }
            }
        }


        public RelayCommand changeImageCommand { get; }
        public void changeImageExecute(object p)
        {
            ImageVisibility = ImageVisibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
        

        }
        public bool changeImageCanExecute(object p) { return true; }

        
        #endregion
        #region Изменить описание
        #endregion

        public AboutEmpVM() {

            changeCommand = new RelayCommand(changeCommandExecute,changeCommandCanExecute);
            changeLocatiobCommand = new RelayCommand(changeLocationCommandExecute, changeLocationCommandCanExecute);
            changeImageCommand = new RelayCommand(changeImageExecute, changeImageCanExecute);
        }
    }
}
