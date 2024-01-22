﻿using TodoApp.Pages;

namespace TodoApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ManageToDo), typeof(ManageToDo));
        }
    }
}