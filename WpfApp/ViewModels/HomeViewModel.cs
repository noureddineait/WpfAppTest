using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    internal class HomeViewModel 
    {
        public Models.User User { get; set; }
        public HomeViewModel(Models.User _User)
        {
            User = _User;           
        }

        private void ChangeName()
        {
            User.Nom = "teatea";
        }
    }
}
