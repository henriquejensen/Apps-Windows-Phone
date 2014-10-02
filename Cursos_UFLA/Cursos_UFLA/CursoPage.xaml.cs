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
using System.Windows.Media.Imaging;

namespace Cursos_UFLA
{
    public partial class CursoPage : PhoneApplicationPage
    {
        private string _cursoSelected = "UFLA";

        public CursoPage()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(CursoPage_Loaded);
        }

        void CursoPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (NavigationContext.QueryString.
                    TryGetValue("dados", out _cursoSelected))
            {
                LoadInfo();
            }
        }

        private void LoadInfo()
        {
            BitmapImage bmp = new BitmapImage();

            PageTitle.Text = _cursoSelected;
            txtNomeCurso.Text = _cursoSelected;

            bmp.UriSource = new Uri(string.Format("Imagens/{0}.jpg", _cursoSelected),
                UriKind.RelativeOrAbsolute);
            imgCurso.Source = bmp;

            switch (_cursoSelected)
            {
                case "Agronomia":
                    txtDetalhes.Text = Descricao.Agronomia;
                    break;
                case "Administração":
                    txtDetalhes.Text = Descricao.Administracao;
                    break;
                case "Administração Publica":
                    txtDetalhes.Text = Descricao.AdmPublica;
                    break;
                case "Biologia Licenciatura":
                    txtDetalhes.Text = Descricao.BioLicen;
                    break;
                case "Biologia Bacharelado":
                    txtDetalhes.Text = Descricao.BioBach;
                    break;
                case "Ciência da Computação":
                    txtDetalhes.Text = Descricao.Computacao;
                    break;
                case "Direito":
                    txtDetalhes.Text = Descricao.Direito;
                    break;
                case "Eng. Agrícola":
                    txtDetalhes.Text = Descricao.Agricola;
                    break;
                case "Eng. Florestal":
                    txtDetalhes.Text = Descricao.Florestal;
                    break;
                case "Eng. Ambiental":
                    txtDetalhes.Text = Descricao.Ambiental;
                    break;
                case "Eng. Alimentos":
                    txtDetalhes.Text = Descricao.Alimentos;
                    break;
                case "Eng. Automação":
                    txtDetalhes.Text = Descricao.Automacao;
                    break;
                case "Filosofia":
                    txtDetalhes.Text = Descricao.Filosofia;
                    break;
                case "Física":
                    txtDetalhes.Text = Descricao.Fisica;
                    break;
                case "Letras":
                    txtDetalhes.Text = Descricao.Letras;
                    break;
                case "Matemática":
                    txtDetalhes.Text = Descricao.Matematica;
                    break;
                case "Medicina":
                    txtDetalhes.Text = Descricao.Medicina;
                    break;
                case "Medicina Veterinária":
                    txtDetalhes.Text = Descricao.Veterinaria;
                    break;
                case "Nutrição":
                    txtDetalhes.Text = Descricao.Nutricao;
                    break;
                case "Quimica":
                    txtDetalhes.Text = Descricao.Quimica;
                    break;
                case "Sistemas de Informação":
                    txtDetalhes.Text = Descricao.Sistemas;
                    break;
                case "Zootecnia":
                    txtDetalhes.Text = Descricao.Zootecnia;
                    break;

                default:
                    break;
            }
        }
    }
}