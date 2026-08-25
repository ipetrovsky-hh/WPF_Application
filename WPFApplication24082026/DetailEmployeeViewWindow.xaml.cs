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
using System.Windows.Shapes;

namespace WPFApplication24082026
{
    /// <summary>
    /// Логика взаимодействия для DetailEmployee.xaml
    /// </summary>
    public partial class DetailEmployeeView : Window
    {
        public DetailEmployeeView()
        {
            InitializeComponent();
        }

        public string NameVDtl
        {
            get { return NameTextVDetail.Text; }
            set { NameTextVDetail.Text = value; }
        }

        public string SpecificationVDtl
        {
            get { return SpecificationVDetail.Text; }
            set { SpecificationVDetail.Text = value; }
        }

        public string CategoryVDtl
        {
            get { return CategoryVDetail.Text; }
            set { CategoryVDetail.Text = value; }
        }

        public string PriceVDtl
        {
            get { return PriceVDetail.Text; }
            set { PriceVDetail.Text = value; }
        }

        public string DescriptionVDtl
        {
            get { return DescriptionVDetail.Text; }
            set { DescriptionVDetail.Text = value; }
        }

        public string AddressVDtl
        {
            get { return AddressVDetail.Text; }
            set { AddressVDetail.Text = value; }
        }
    }
}
