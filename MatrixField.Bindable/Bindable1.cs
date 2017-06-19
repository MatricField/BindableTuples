using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatrixField.Bindable
{
    public class Bindable<T1> :
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
        #endregion

        #region Events
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Constructors
        public Bindable(T1 item1)
        {
            Item1 = item1;
        }
        #endregion

        #region Methods
        public void Deconstruct(out T1 item1)
        {
            item1 = Item1;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
