using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharp7Samples
{
    public abstract class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //{
        //    //if (PropertyChanged != null)
        //    //{
        //    //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    //}

        //    //var handler = PropertyChanged;
        //    //if (handler != null)
        //    //{
        //    //    handler(this, new PropertyChangedEventArgs(propertyName));
        //    //}

        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public virtual bool SetProperty<T>(ref T item, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(item, value)) return false;
            item = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
