using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionMVVC
{
    class MainWindowVM : INotifyPropertyChanged
    {

        tema6bdluisEntities contexto = new tema6bdluisEntities();

        public MainWindowVM()
        {
            contexto.CLIENTES.Load();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
