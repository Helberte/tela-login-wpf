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
using System.Windows.Shapes;

namespace AppEstudoPromise.View
{
    /// <summary>
    /// Lógica interna para UIDesign.xaml
    /// </summary>
    public partial class UIDesign : Window
    {
        public UIDesign()
        {
            InitializeComponent();
        }

        /// <summary>
        /// pressionamento de qualquer tecla do teclado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
                Application.Current.Shutdown();
        }
    }
}
