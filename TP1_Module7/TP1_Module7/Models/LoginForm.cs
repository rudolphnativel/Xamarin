using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using TP1_Module7.BO;
using TP1_Module7.Services;
using Xamarin.Forms;

namespace TP1_Module7.Models
{
    class LoginForm

    {
        private readonly ITwitterService__ twitterService;
        public Entry Login { get; }
        public Entry Password { get; }
        public Xamarin.Forms.Switch IsRemind { get; }
        public VisibilitySwitch VisibilitySwitch { get; }
        public ErrorForm Error { get; }
        private User user { get; set; }

        public LoginForm(Entry login, Entry password, Xamarin.Forms.Switch isRemind, View loginForm, View tweetForm, Label errorLabel, Button button)
        {
            
            this.twitterService = new TwitterService();
            this.Login = login;
            this.Password = password;
            this.IsRemind = isRemind;
            this.Error = new ErrorForm(errorLabel);
            Debug.WriteLine("new User");
            button.Clicked += Button_Clicked;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("btn clicked");
            if (this.IsValid())
            {
                if (twitterService.authenticate(this.user))
                {
                    this.Error.Hide();
                    this.VisibilitySwitch.Switch();
                }
                else
                {
                    this.Error.Error = "Utilisateur non trouvé";
                    this.Error.Display();
                }
            }
            else
            {
                this.Error.Display();
            }
        }

        public Boolean IsValid()
        {
            Boolean result = true;

            String login = this.Login.Text;
            String password = this.Password.Text;
            Boolean isRemind = this.IsRemind.IsToggled;

            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (haveError)
            {

                this.Error.Error = stringBuilder.ToString();
            }
            else
            {
                this.user = new User(this.Login.Text, this.Password.Text);
            }

            result = !haveError;

            return result;
        }
    }
}

