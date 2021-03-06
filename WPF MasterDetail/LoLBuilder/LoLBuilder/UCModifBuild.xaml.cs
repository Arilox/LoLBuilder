﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Data;

namespace LoLBuilder
{
    /// <summary>
    /// Logique d'interaction pour UCModifBuild.xaml
    /// </summary>
    public partial class UCModifBuild : UserControl
    {
        public UCModifBuild()
        {
            InitializeComponent();
        }

        public Champion MyProperty
        {
            get { return (Champion)GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(Champion), typeof(UCModifBuild));




    }
}
