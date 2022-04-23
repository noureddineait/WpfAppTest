using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.Models
{
    public class User :INotifyPropertyChanged
    {
        private string _nom = "";
        private string _prenom = "";
        private string _fullName = "";
        public string Nom
        {
            get { return _nom; }
            set {
                if(this._nom != value)
                {
                    this._nom = value;
                }
            }
        }
        public string Prenom
        {
            get { return _prenom; }
            set
            {
                if (this._prenom != value)
                {
                    this._prenom = value;
                }
            }
        }
        public string FullName
        {
            get {
                return _fullName;
            }
            set
            {
                if(this._fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged();
                }
            }
        }
        public bool IsValid()
        {
            return(Nom != null && Prenom!=null);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
