﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lumememm.Services;
using Lumememm.Views;

namespace Lumememm
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new Absolute();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
