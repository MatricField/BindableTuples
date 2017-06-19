using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatrixField.Bindable
{
    public class Bindable<T1, T2> :
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
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructors
        public Bindable(T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
        #endregion

        #region Methods
        public void Deconstruct(out T1 item1, out T2 item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
