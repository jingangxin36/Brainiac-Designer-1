﻿using System;
using Samples.Infrastructure.Controls;
using Microsoft.Practices.Prism.Regions;

namespace Samples.Modules.Numeric.Views
{
    /// <summary>
    /// Interaction logic for HomeView.xaml
    /// </summary>
    [RegionMemberLifetime(KeepAlive = false)]
    public partial class HomeView : DemoView
    {
        public HomeView()
        {
            InitializeComponent();
        }
    }
}
