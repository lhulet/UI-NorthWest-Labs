﻿using Microsoft.Win32;
using System;
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

namespace UI_NorthWest_Labs2.Pages.Tests.Completed
{
    /// <summary>
    /// Interaction logic for TestInfo.xaml
    /// </summary>
    public partial class CompletedTestInfo1 : UserControl
    {
        public CompletedTestInfo1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //set pdf name here
            string pdfname = "TestDataReport";

            //add PDF folder and .pdf to filename
            string fullname = "\\PDF\\" + pdfname + ".pdf";

            //find the full filepath
            string filepath = AppDomain.CurrentDomain.BaseDirectory;

            //remove 'bin' and 'debug' folder
            filepath = filepath.Remove(filepath.Length - 10);

            //open the pdf :)
            System.Diagnostics.Process.Start(filepath + fullname);

            //OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            //openFileDialog1.Filter = "PDF files (*.PDF)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2;
            //openFileDialog1.RestoreDirectory = true;
            //openFileDialog1.ShowDialog();

            //UploadConfirmation newuc = new UploadConfirmation();
            //newuc.ShowDialog();
        }
    }
}
