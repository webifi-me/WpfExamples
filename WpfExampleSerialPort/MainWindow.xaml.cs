using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfExampleSerialPort
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

        private void buttonClearRecData_Click(object sender, RoutedEventArgs e)
        {
            textboxRecData.Text = "";
        }

        private void buttonSendData_Click(object sender, RoutedEventArgs e)
        {
            webifiSerialPort.Write(textboxSendData.Text);
        }

        private void webifiSerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e, byte[] recData)
        {
            textboxRecData.Text += WebifiLib.Webifi.ConvertByteArrayToString(recData);
        }
    }
}
