﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DroneLanderNew;
using DroneLanderNew.ViewModels;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace DroneLanderNew
{
    public partial class App : Application
    {
        public static MainViewModel ViewModel { get; set; }

        public static Services.IAuthenticationService Authenticator { get; private set; }

        public static void InitializeAuthentication(Services.IAuthenticationService authenticator)
        {
            Authenticator = authenticator;
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new DroneLanderNew.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MobileCenter.Start($"android={Common.MobileCenterConstants.AndroidAppId};" +
                               $"ios={Common.MobileCenterConstants.iOSAppId}",
                typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
