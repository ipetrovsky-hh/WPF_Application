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
    public partial class DetailEmployee : Window
    {
        public DetailEmployee()
        {
            InitializeComponent();
        }

        public string NameDtl
        {
            get { return NameTextDetail.Text; }
            set { NameTextDetail.Text = value; }
        }

        public string SpecificationDtl
        {
            get { return SpecificationDetail.Text; }
            set { SpecificationDetail.Text = value; }
        }

        public string CategoryDtl
        {
            get { return CategoryDetail.Text; }
            set { CategoryDetail.Text = value; }
        }

        public string PriceDtl
        {
            get { return PriceDetail.Text; }
            set { PriceDetail.Text = value; }
        }

        public string DescriptionDtl
        {
            get { return DescriptionDetail.Text; }
            set { DescriptionDetail.Text = value; }
        }

        public string AddressDtl
        {
            get { return AddressDetail.Text; }
            set { AddressDetail.Text = value; }
        }
    }
}
