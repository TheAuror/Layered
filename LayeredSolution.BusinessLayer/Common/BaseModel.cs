using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace LayeredSolution.BusinessLayer.Common
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        protected virtual bool OnPropertyChanged<T>(
            ref T ValueRef, T newValue, [CallerMemberName] string propertyName = null)
        {
            if (Equals(ValueRef, newValue)) return false;
            ValueRef = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
