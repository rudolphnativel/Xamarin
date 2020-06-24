using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Module7.Models;
using Xamarin.Forms;

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
            new LoginForm(this.id, this.password, this.rebemerMe, this.loginF, this.tweet, this.errorLabel, this.ClickConnexion);
        }
    }
}
