using DataHandler;
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
using System.Data;

namespace CourseWorkSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           // Startup();
        }

       // public void Startup()
        //{
            /*var handler = new Handler();
            var dataSet = handler.CreateDataSet();
            AddSampleData(dataSet);
            dataSet.WriteXmlSchema(@"F:\StudentCWSchema.xml");
            dataSet.WriteXml(@"F:\StudentCWData.xml");*/

            //var dataSet = new DataSet();
            //dataSet.ReadXmlSchema(@"F:\StudentCWSchema.xml");
            //dataSet.ReadXml(@"D:\StudentCWData.xml");

            //var i = 0;
       // } 
     

       /* private void AddSampleData(DataSet dataSet)
        {
            var dr = dataSet.Tables["Course"].NewRow();

            // Data extrated from the text Field//
            dr["Name"] = " txtName.Text";
            dr["Address"] = "txtAddress.Text";
            dr["ContactNo"] = " txtContact.Text ";
            dr["CourseEnroll"] = " txtCourseEnroll.Text ";
            dr["RegsitrationDate"] = " txtRegisDate.Text ";



            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Course"].NewRow();
            dr["Name"] = "Network & Communication";
            dr["DisplayText"] = "BCA Network";
            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Course"].NewRow();
            dr["Name"] = "Programming & Application Development";
            dr["DisplayText"] = "BSc CSIT Application Development";
            dataSet.Tables["Course"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Ishwor Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220845";
            dr["CourseEnroll"] = 1;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-2);
            dataSet.Tables["Student"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Samyam Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220846";
            dr["CourseEnroll"] = 2;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-1);
            dataSet.Tables["Student"].Rows.Add(dr);

            dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "Safal Sapkota";
            dr["Address"] = "Kathmandu";
            dr["ContactNo"] = "9851220847";
            dr["CourseEnroll"] = 3;
            dr["RegistrationDate"] = DateTime.Today.AddDays(-3);
            dataSet.Tables["Student"].Rows.Add(dr);

        } */
        private void AddSampleDataforstd(DataSet dataSet)
        {
            var dr = dataSet.Tables["Student"].NewRow();
            dr["Name"] = "BBA";
            dr["DisplayText"] = "BBA Hons";
            dataSet.Tables["Course"].Rows.Add(dr);


            var dr1 = dataSet.Tables["Student"].NewRow();

            // Data extrated from the text Field//
            dr1["Name"] =  txtName.Text;
            dr1["Address"] = txtAddress.Text;
            dr1["ContactNo"] =  txtContact.Text ;
            dr1["CourseEnroll"] =  txtCourseEnroll.Text ;
            dr1["RegsitrationDate"] =  txtRegisDate.Text ;



           
        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            /*txtName.Text = "Ram";
            txtAddress.Text = "Birauta";
            txtContact.Text = "9816144631";
            txtCourseEnroll.Text = "Computing";
            txtRegisDate.Text = "2076/1/8";*/
            var handler = new Handler();
            var dataSet = handler.CreateDataSet();
            //AddSampleData(dataSet);
            AddSampleDataforstd(dataSet);
            dataSet.WriteXmlSchema(@"F:\StudentCWSchema.xml");
            dataSet.WriteXml(@"F:\StudentCWData.xml");

        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
