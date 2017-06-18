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
using MatrixField.Bindable;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IDictionary<TestEnum, Bindable<bool>> Data { get; set; }

        private TestEnum DefaultOption = TestEnum.Two;

        public MainWindow()
        {
            Data =
                ((TestEnum[])Enum.GetValues(typeof(TestEnum)))
                .ToDictionary(x => x, _ => Bindable.Create(false));
            Data[DefaultOption].Item1 = true;
            InitializeComponent();
        }
    }
}
