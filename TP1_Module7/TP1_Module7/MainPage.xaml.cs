using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Module7.Models;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace TP1_Module7
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            VisibilitySwitch VisibilitySwitch  = new VisibilitySwitch(this.tweet, this.loginF);
            new LoginForm(this.id, this.password, this.rebemerMe, this.loginF, this.tweet, this.errorLabel, this.ClickConnexion);
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                this.labelConnexion.Text = "Connecter";
            }
            else this.labelConnexion.Text = "Déconnecter";
        }
    }
}
