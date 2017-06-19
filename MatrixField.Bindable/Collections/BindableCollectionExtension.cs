using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixField.Bindable.Collections
{
    public static class BindableCollectionExtension
    {
        public static BindableCollection<T> AsBindable<T>(this ICollection<T> collection)
        {
            return new BindableCollection<T>(collection);
        }
    }
}
