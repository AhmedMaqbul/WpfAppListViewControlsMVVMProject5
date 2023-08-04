using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppListViewControlsMVVMProject5.ViewModel;

namespace WpfAppListViewControlsMVVMProject5.Commands
{
    public class DeleteCommand : BaseCommand
    {
        private readonly MainWindowViewModel _deleteEntry;
        public DeleteCommand(MainWindowViewModel deleteContext)
        {
            this._deleteEntry = deleteContext;
        }

        public override bool CanExecute(object parameter)
        {
            return _deleteEntry.CanDelete();
        }

        public override void Execute(object parameter)
        {
            _deleteEntry.Delete();
        }
    }
}
