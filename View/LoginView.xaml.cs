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

namespace AppEstudoPromise.View
{
    /// <summary>
    /// Lógica interna para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

            OtimizacaoLayout();
        }

        private void OtimizacaoLayout()
        {
            txtUsuario.Focus();

            // Verifica se é possível tornar o objeto Brush freeze => congelado
            // isso ajuda a melhorar o desempenho visto que o sistema vai gastar menos recursos
            // monitorando suas notificações de alterações
            /*
            if (borderInterna.BorderBrush.CanFreeze) { borderInterna.BorderBrush.Freeze(); }
            if (gradienteBordaInterna.CanFreeze)     { gradienteBordaInterna.Freeze(); }
            */
            /*             
            Nem todo objeto Freezable pode ser congelado. Para evitar lançar um InvalidOperationException, 
            verifique o valor da propriedade CanFreeze do objeto Freezable para determinar se ele pode 
            ser congelado antes de tentar congelá-lo.             
            */

            // saber se está congelado
            //if (gradienteBordaInterna.IsFrozen ) { }
        }

        #region Eventos e Cliques

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // se o botão da esquerda do mouse estiver pressionado, DragMove() => arrasta a tela
            if (e.LeftButton == MouseButtonState.Pressed)            
                DragMove();            
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EsqueciSenha senha = new EsqueciSenha();
            senha.Show();

            this.Close();
        }

        #endregion

    }
}
