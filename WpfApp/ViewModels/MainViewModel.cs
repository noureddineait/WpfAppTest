using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp.ViewModels
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string _nomComplet = "";

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public string NomComplet
        {
            get
            {
                return _nomComplet;
            }
            set
            {
                if (this._nomComplet != value)
                {
                    _nomComplet = value;
                    OnPropertyChanged();
                }
            }
        }
        public Models.User User { get; set; }
        
        public ICommand AfficherNomCommand { get; private set; }
        public MainViewModel()
        {
            //window=this.;
            User = new Models.User();
            AfficherNomCommand = new RelayCommand(
                o=>User.IsValid(),
                o=>AfficherNom()
                );
        }

        private void AfficherNom()
        {
            NomComplet = $"Votre Nom est : {User.Nom} {User.Prenom}";

            Views.View2 view = new Views.View2(User);
            view.DataContext=this;
        }
    }
}
