﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;
using UITest.MoveResizeRotateWithAdorner;

namespace UITest
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var view = new SocketTest();
            view.Show();

            base.OnStartup(e);
        }
    }
}
