﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Forms.Sample.Views;

namespace Xamarin.Forms.Sample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
                        
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            MessagingCenter.Send<App>(this, "APP_RESUME");
        }
    }
}
