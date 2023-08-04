using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppListViewControlsMVVMProject5.ViewModel;

namespace WpfAppListViewControlsMVVMProject5.Commands
{
    public class ClearCommand : BaseCommand
    {
        private readonly MainWindowViewModel _clearEntry;
        public ClearCommand(MainWindowViewModel clearEntry)
        {
            this._clearEntry = clearEntry;
        }

        public override bool CanExecute(object parameter)
        {
            return _clearEntry.CanClear();
        }

        public override void Execute(object parameter)
        {
            _clearEntry.Clear();
        }
    }
}
