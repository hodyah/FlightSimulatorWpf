﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp1
{
	class TunedBoardSimple
	{
		const int numOfInformation = 8;
		List<Rectangle> rectangleList;
		List<int> highOfBlock;
		TunedBoardSimple()
		{
			SolidColorBrush solidColorBlock = new SolidColorBrush();
			solidColorBlock.Color = Color.FromArgb(255, 255, 255, 0);
			for (int i = 0; i < numOfInformation; i++){
				rectangleList.Add(new System.Windows.Shapes.Rectangle());
				rectangleList[i].Fill = solidColorBlock;
				rectangleList[i].Width = 10;
				rectangleList[i].Height = 0;
			}
		}
		void upDate()
		{
			for (int i = 0; i < rectangleList.Count(); i++)
			{
				rectangleList[i].Height = highOfBlock[i];
			}
		}
		/**
		 *             <>
                <DataGrid HorizontalAlignment="Right" VerticalAlignment="Top" Width="356" Height="164" Grid.Row="2" 
                      Grid.Column="8" Panel.ZIndex="-10" FontFamily="Segoe UI Black" Name="tableInformation" 
                      AccessKeyManager.AccessKeyPressed="tableInformation_AccessKeyPressed" 
                      DataGridCell.Selected="tableInformation_Selected" 
                      Binding.SourceUpdated="tableInformation_SourceUpdated"/>
            </>
		 */
	}
}
