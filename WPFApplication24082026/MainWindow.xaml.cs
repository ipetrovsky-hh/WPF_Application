
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFApplication24082026.Data;
using WPFApplication24082026.Models;

namespace WPFApplication24082026
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += Window_Loaded;
        }

        private void MenuItemHelp_Click(object sender, RoutedEventArgs e)
        {
            Support sup = new Support();

            sup.getErrorMessage("Справочное сообщение.",
                "Демонстрационный проект WPF",
                "Демонстрационный проект WPF. автор Петровский И.М.",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            return;
        }

        private void TreeViewButton_Click(object sender, RoutedEventArgs e)
        {
            WorkingData wData = new WorkingData(StaticJsonValues.textJson);

            TextBlock treeViewItem = e.OriginalSource as TextBlock;

            if (treeViewItem.Text == TypeOfTreeView.MongoDB)
            {
                dataGrid1.ItemsSource = wData.FullDataDataBase(TypeOfTreeView.MongoDB);
            }
            else if (treeViewItem.Text == TypeOfTreeView.Postgresql)
            {
                dataGrid1.ItemsSource = wData.FullDataDataBase(TypeOfTreeView.Postgresql);
            }
            else if (treeViewItem.Text == TypeOfTreeView.Oracle)
            {
                dataGrid1.ItemsSource = wData.FullDataDataBase(TypeOfTreeView.Oracle);
            }
            else if (treeViewItem.Text == TypeOfTreeView.MSSQL)
            {
                dataGrid1.ItemsSource = wData.FullDataDataBase(TypeOfTreeView.MSSQL);
            }
            else if (treeViewItem.Text == TypeOfTreeView.CSparp)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.CSparp);
            }
            else if (treeViewItem.Text == TypeOfTreeView.CPlus)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.CPlus);
            }
            else if (treeViewItem.Text == TypeOfTreeView.Java)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.Java);
            }
            else if (treeViewItem.Text == TypeOfTreeView.Typescript)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.Typescript);
            }
            else if (treeViewItem.Text == TypeOfTreeView.VB)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.VB);
            }
            else if (treeViewItem.Text == TypeOfTreeView.Javascript)
            {
                dataGrid1.ItemsSource = wData.FullDataSpecification(TypeOfTreeView.Javascript);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WorkingData wData = new WorkingData(StaticJsonValues.textJson);

            dataGrid1.ItemsSource = wData.FullSortDataGrid();
        }

        public void DialogWindowClick(object sender, RoutedEventArgs e)
        {
            DetailEmployee DatailWindow = new DetailEmployee();

            if (dataGrid1.SelectedItem != null)
            {
                var selectedItem = dataGrid1.SelectedItem as Employees; // Приведите к корректному типу
                DatailWindow.NameDtl = selectedItem.Name;
                DatailWindow.SpecificationDtl = selectedItem.Specification;
                DatailWindow.CategoryDtl = selectedItem.CategoryName;
                DatailWindow.PriceDtl = selectedItem.ListPrice;
                DatailWindow.DescriptionDtl = selectedItem.Description;
                DatailWindow.AddressDtl = selectedItem.Address;
            }
            else
            {
                Support sup = new Support();

                sup.getErrorMessage("Предупреждение - сообщение.",
                    "Демонстрационный проект WPF",
                    "Необходимо выбрать строку в таблице Сотрудники",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            DatailWindow.Show();
        }
        public void DialogViewWindowClick(object sender, RoutedEventArgs e)
        {
            DetailEmployeeView DatailWindow = new DetailEmployeeView();

            if (dataGrid1.SelectedItem != null)
            {
                var selectedItem = dataGrid1.SelectedItem as Employees; 
                DatailWindow.NameVDtl = selectedItem.Name;
                DatailWindow.SpecificationVDtl = selectedItem.Specification;
                DatailWindow.CategoryVDtl = selectedItem.CategoryName;
                DatailWindow.PriceVDtl = selectedItem.ListPrice;
                DatailWindow.DescriptionVDtl = selectedItem.Description;
                DatailWindow.AddressVDtl = selectedItem.Address;
            }
            else
            {
                Support sup = new Support();

                sup.getErrorMessage("Предупреждение - сообщение.",
                    "Демонстрационный проект WPF",
                    "Необходимо выбрать строку в таблице Сотрудники",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                return;
            }

            DatailWindow.Show();
        }


    }
}