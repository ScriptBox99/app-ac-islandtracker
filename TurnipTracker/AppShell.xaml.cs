﻿using System;
using System.Collections.Generic;
using TurnipTracker.View;
using Xamarin.Forms;

namespace TurnipTracker
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            TabBar.CurrentItem = TabBar.Items[1];

            Routing.RegisterRoute("invite", typeof(AcceptFriendRequestPage));
        }
    }
}