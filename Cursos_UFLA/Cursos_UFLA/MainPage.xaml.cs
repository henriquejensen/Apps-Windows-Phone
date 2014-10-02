using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Cursos_UFLA
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void tbRestaurante_Tap(object sender, GestureEventArgs e)
        {
            string cursoSelected = ((ListBoxItem)lbxCursos.SelectedItem).Content.ToString();

            string url = string.Format("/CursoPage.xaml?dados={0}", cursoSelected);
            Uri uri = new Uri(url, UriKind.RelativeOrAbsolute);
            NavigationService.Navigate(uri);
        }
    }
}