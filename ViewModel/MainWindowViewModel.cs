using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfAppListViewControlsMVVMProject5.Commands;

namespace WpfAppListViewControlsMVVMProject5.ViewModel
{
    public class MainWindowViewModel //: INotifyPropertyChanged
    {
        public MainWindowViewModel() 
        { 
            AddCommand = new AddCommand(this);
            DeleteCommand = new DeleteCommand(this);
            ClearCommand = new ClearCommand(this);
        }

        //private Array Array { get; set; } 
        public string TextData { get; set; }

        public ObservableCollection<string> Names { get; set; } = new ObservableCollection<string>();

        //public List<string> Names
        //{
        //    get
        //    {
        //        return names;
        //    }

        //    set
        //    {
        //        names = value;
        //        OnPropertyChanged(nameof(Names));
        //    }
        //}

        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand ClearCommand { get; set; }

        public int SelectedItemIndexes { get; set; }

        public void Add()
        {
            Names.Insert(0, TextData);
        }
        public bool CanAdd()
        {
            return true;
        }

        public void Delete()
        {

            Names.RemoveAt(SelectedItemIndexes);
            
        }
        public bool CanDelete()
        {
            return true;
        }

        public void Clear()
        {
            Names.Clear();
        }
        public bool CanClear()
        {
            return true;
        }

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}
    }
}
