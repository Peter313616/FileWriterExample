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

namespace _313616_FileWriterExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(txtFileName.Text);
                streamWriter.WriteLine(txtInput.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }//end try
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }// end catch
        }

        private void btnAppend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(txtFileName.Text, true);
                streamWriter.WriteLine(txtInput.Text);
                streamWriter.Flush();
                streamWriter.Close();
            }//end try
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }// end catch
        }

        private void btnSquares_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(txtFileName.Text, true);
                double.TryParse(txtInput.Text, out double lastNumber);
                for(int i  = 0; i <= lastNumber; i++)
                {
                    int squaredNumber = i * i;
                    streamWriter.WriteLine(i.ToString() + "\t" + squaredNumber.ToString());
                }
                streamWriter.Flush();
                streamWriter.Close();
            }//end try
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }// end catch

        }
    }
}
