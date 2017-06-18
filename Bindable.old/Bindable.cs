using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Bindable
{
    public class Bindable<T1>:
		INotifyPropertyChanged
    {
        private T1 _Item1;
        public T1 Item1
        {
            get => _Item1;
            set
            {
                _Item1 = value;
                NotifyPropertyChanged();
            }
        }

        public Bindable(T1 item1)
        {
            Item1 = item1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Deconstruct(out T1 item1)
        {
            item1 = Item1;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
