﻿using SampleApp.ViewModels;
using SampleApp.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SampleApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
