using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppListViewControlsMVVMProject5.ViewModel;

namespace WpfAppListViewControlsMVVMProject5.Commands
{
    public class AddCommand : BaseCommand
    {
        private readonly MainWindowViewModel _addEntry;
        public AddCommand(MainWindowViewModel addEntry)
        {
            this._addEntry = addEntry;
        }

        public override bool CanExecute(object parameter)
        {
            return _addEntry.CanAdd();
        }

        public override void Execute(object parameter)
        {
            _addEntry.Add();
        }
    }
}
