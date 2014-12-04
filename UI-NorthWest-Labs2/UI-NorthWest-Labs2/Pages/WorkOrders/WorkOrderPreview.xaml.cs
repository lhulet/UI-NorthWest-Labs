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

namespace UI_NorthWest_Labs2.Pages.WorkOrders
{
    /// <summary>
    /// Interaction logic for WorkOrderPreview.xaml
    /// </summary>
    public partial class WorkOrderPreview : UserControl
    {
        public WorkOrderPreview()
        {
            InitializeComponent();
        }

        private void View_Work_Order_Click(object sender, RoutedEventArgs e)
        {
            NavigationCommands.GoToPage.Execute("/Pages/WorkOrders/InProcess/WorkOrder1.xaml", MainWindow.frame);
        }

  
    }
}
