﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using RentManager.Model;

namespace RentManager.Controls
{
	public partial class ContractsManagementControl
	{
		public ContractsManagementControl()
		{
			InitializeComponent();
		}

		public static readonly DependencyProperty ItemsSourceProperty = ItemsControl.ItemsSourceProperty.AddOwner(typeof(ContractsManagementControl));

		public IEnumerable<Contract> ItemsSource
		{
			get { return (IEnumerable<Contract>)GetValue(ItemsSourceProperty); }
			set { SetValue(ItemsSourceProperty, value); }
		}
	}
}
