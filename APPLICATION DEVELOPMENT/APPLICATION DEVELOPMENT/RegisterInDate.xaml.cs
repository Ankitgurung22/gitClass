﻿using DataHandler;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace APPLICATION_DEVELOPMENT
{
    /// <summary>
    /// Interaction logic for RegisterInDate.xaml
    /// </summary>
    public partial class RegisterInDate : Window
    {
        public RegisterInDate()
        {
            InitializeComponent();
            LoadStudentData();
        }

        private void LoadStudentData()
        {

            if (System.IO.File.Exists(@"F:\StudentReport.xml"))
            {
                var handler = new Handler();


                var dataSet = new DataSet();

                dataSet.ReadXml(@"F:\StudentReport.xml");

                DataTable dtStdReport = new DataTable();
                dtStdReport = dataSet.Tables[0];
                dtStdReport.DefaultView.Sort = "RegistrationDate ASC";
                RegisInDate.DataContext = dtStdReport.DefaultView;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            RetriveWindow back = new RetriveWindow();
            back.Show();
            Close();

        }
    }

}
