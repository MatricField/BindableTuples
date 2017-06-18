using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatrixField.Bindable
{
    public class Bindable<T1, T2, T3> :
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
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructors
        public Bindable(T1 item1, T2 item2, T3 item3)
        {
            Item1 = item1;
            Item2 = item2;
            Item3 = item3;
        }
        #endregion

        #region Methods
        public void Deconstruct(out T1 item1, out T2 item2, out T3 item3)
        {
            item1 = Item1;
            item2 = Item2;
            item3 = Item3;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
