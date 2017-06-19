using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MatrixField.Bindable.Collections
{
    public class BindableCollection<T> :
        ICollection<T>, INotifyPropertyChanged, INotifyCollectionChanged
    {
        public int Count => WrappedCollection.Count;

        public bool IsReadOnly => WrappedCollection.IsReadOnly;

        protected virtual ICollection<T> WrappedCollection { get; }

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        protected BindableCollection()
        {

        }

        public BindableCollection(ICollection<T> collectionToWrap)
        {
            WrappedCollection = collectionToWrap;
        }

        public virtual void Add(T item)
        {
            WrappedCollection.Add(item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, changedItem: item));
        }

        public virtual void Clear()
        {
            WrappedCollection.Clear();
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public virtual bool Contains(T item)
        {
            return WrappedCollection.Contains(item);
        }

        public virtual void CopyTo(T[] array, int arrayIndex)
        {
            WrappedCollection.CopyTo(array, arrayIndex);
        }

        public virtual IEnumerator<T> GetEnumerator()
        {
            return WrappedCollection.GetEnumerator();
        }

        public virtual bool Remove(T item)
        {
            if (WrappedCollection.Remove(item))
            {
                OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, changedItem: item));
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            CollectionChanged?.Invoke(this, args);
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return WrappedCollection.GetEnumerator();
        }
    }
}
