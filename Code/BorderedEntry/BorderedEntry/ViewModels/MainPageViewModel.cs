using System;
using System.Collections.Generic;
using System.Text;

namespace BorderedEntry.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private string _DefaultEntryPlaceHolder, _BorderedEntryPlaceholder, _CurvedBorderEntryPlaceholder;

        public string DefaultEntryPlaceHolder
        {
            get { return _DefaultEntryPlaceHolder; }
            set { _DefaultEntryPlaceHolder = value;NotifyPropertyChanged("DefaultEntryPlaceHolder"); }
        }

        public string BorderedEntryPlaceholder
        {
            get { return _BorderedEntryPlaceholder; }
            set { _BorderedEntryPlaceholder = value; NotifyPropertyChanged("BorderedEntryPlaceholder"); }
        }

        public string CurvedBorderEntryPlaceholder
        {
            get { return _CurvedBorderEntryPlaceholder; }
            set { _CurvedBorderEntryPlaceholder = value; NotifyPropertyChanged("CurvedBorderEntryPlaceholder"); }
        }

        public MainPageViewModel()
        {
            DefaultEntryPlaceHolder = "Default Entry";
            BorderedEntryPlaceholder = "Bordered Entry";
            CurvedBorderEntryPlaceholder = "Curved Bordered Entry";
        }
    }
}
