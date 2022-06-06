using System;
using System.ComponentModel;

namespace London2012
{
    public class GBfinderDetailModel : INotifyPropertyChanged
    {
        private string _aName;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string aName
        {
            get{return _aName;}
            set
            {
                if (value != _aName)
                {
                    _aName = value;
                    NotifyPropertyChanged("aName");
                }
            }
        }
        private string _DOB;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string DOB
        {
            get { return _DOB; }
            set
            {
                if (value != _DOB)
                {
                    _DOB = value;
                    NotifyPropertyChanged("DOB");
                }
            }
        }
        private string _Location;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Location
        {
            get { return _Location; }
            set
            {
                if (value != _Location)
                {
                    _Location = value;
                    NotifyPropertyChanged("Location");
                }
            }
        }


        private string _bioData;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string BioData
        {
            get{return _bioData;}
            set
            {
                if (value != _bioData)
                {
                    _bioData = value;
                    NotifyPropertyChanged("BioData");
                }
            }
        }

        private string _picture;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string Picture
        {
            get{return _picture;}
            set
            {
                if (value != _picture)
                {
                    _picture = value;
                    NotifyPropertyChanged("Picture");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}