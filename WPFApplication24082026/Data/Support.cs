using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPFApplication24082026.Data
{
    public class Support
    {
        public Support()
        {
        }

        public  void getErrorMessage(string topic, 
            string captionText,
            string textShow, 
            MessageBoxButton buttonParam, 
            MessageBoxImage iconParam)
        {

            string messageBoxText = topic;
            string caption = captionText;
            MessageBoxButton button = buttonParam;
            MessageBoxImage icon = iconParam;

            MessageBox.Show(textShow);
        }
    }
}