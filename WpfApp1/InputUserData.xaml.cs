﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace FlightSimulatorWpf
{
	/// <summary>
	/// Interaction logic for inputUserData.xaml
	/// </summary>
	public partial class InputUserData : Window
	{
		public InputUserData()
		{
			InitializeComponent();
		}
		private void Button_Click_On_Ip_Massage(object sender, RoutedEventArgs e)
		{
			MainWindow mainWindow = new MainWindow(ipUserInput.Text, portUserInput.Text);
			mainWindow.Show();
			this.Close();
		}
	}
}
