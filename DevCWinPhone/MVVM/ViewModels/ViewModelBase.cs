﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DevCWinPhone
{
    public class ViewModelBase
    {
        #region "region INotifyPropertyChanged Membres"

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region "Méthodes"

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
