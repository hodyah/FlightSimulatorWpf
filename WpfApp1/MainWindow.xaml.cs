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
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		static public void MainA()
		{
			Console.WriteLine("hii");
			/**
				ClientServer client = new ClientServerSimple();
				client.openIp();
				int x = 0;
				while (x < 500)
				{
					x++;
				}
				client.close();
		*/
			
							flyModel flyModel = new flyModel();
							flyModel.connect();
							flyModel.start();

							flyModel.disconnect();
				
		}

		/// <summary>
		/// Interaction logic for MainWindow.xaml
		/// </summary>
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MyJoystick_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void Map_Loaded(object sender, RoutedEventArgs e)
		{

		}

		private void TunedBoard_Loaded(object sender, RoutedEventArgs e)
		{

		}
	}
}


