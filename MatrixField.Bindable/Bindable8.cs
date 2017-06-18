using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatrixField.Bindable
{
    public class Bindable<T1, T2, T3, T4, T5, T6, T7>:
		INotifyPropertyChanged
    {
        #region Properties
        private T1 _Item1;
        public virtual T1 Item1
        {
            get => _Item1;
            set
            {
                _Item1 = value;
                NotifyPropertyChanged();
            }
        }

        private T2 _Item2;
        public virtual T2 Item2
        {
            get => _Item2;
            set
            {
                _Item2 = value;
                NotifyPropertyChanged();
            }
        }

        private T3 _Item3;
        public virtual T3 Item3
        {
            get => _Item3;
            set
            {
                _Item3 = value;
                NotifyPropertyChanged();
            }
        }

        private T4 _Item4;
        public virtual T4 Item4
        {
            get => _Item4;
            set
            {
                _Item4 = value;
                NotifyPropertyChanged();
            }
        }

        private T5 _Item5;
        public virtual T5 Item5
        {
            get => _Item5;
            set
            {
                _Item5 = value;
                NotifyPropertyChanged();
            }
        }

        private T6 _Item6;
        public virtual T6 Item6
        {
            get => _Item6;
            set
            {
                _Item6 = value;
                NotifyPropertyChanged();
            }
        }

        private T7 _Item7;
        public virtual T7 Item7
        {
            get => _Item7;
            set
            {
                _Item7 = value;
                NotifyPropertyChanged();
            }
        }
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructors
        public Bindable(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6, T7 item7)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
            Item4 = item4;
            Item5 = item5;
            Item6 = item6;
            Item7 = item7;
        }
        #endregion

        #region Methods
        public void Deconstruct(out T1 item1, out T2 item2, out T3 item3, out T4 item4, out T5 item5, out T6 item6, out T7 item7)
        {
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
            item4 = Item4;
            item5 = Item5;
            item6 = Item6;
            item7 = Item7;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
