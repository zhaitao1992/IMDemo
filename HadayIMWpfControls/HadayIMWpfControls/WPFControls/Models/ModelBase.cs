using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HadayIMWpfControls.WPFControls.Models
{
    public class ModelBase : INotifyPropertyChanged
    {
        public void Set<T>(ref T field, T newValue = default(T), string propertyName = "")
        {
            if ((newValue != null && newValue.Equals(field)) || (newValue == null && field == null))
                return;
            else
            {
                field = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
