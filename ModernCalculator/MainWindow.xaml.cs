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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ModernCalculator {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        #region Zmienne
        string znak;
        float liczba1;
        float liczba2;
        #endregion

        #region Pasek Górny

        private void pasek_LewyPrzyciskMyszy(object sender, MouseButtonEventArgs e) {
            this.DragMove();
        }

        private void close_Btn_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void minimize_Btn_Click(object sender, RoutedEventArgs e) {
            this.WindowState = WindowState.Minimized;
        }

        #endregion

        #region Przyciski 1-9 + 0
        private void btn_1_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "1";
                } else {
                    current_TextBox.Text += "1";
                }
            }
        }

        private void btn_2_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "2";
                } else {
                    current_TextBox.Text += "2";
                }
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "3";
                } else {
                    current_TextBox.Text += "3";
                }
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "4";
                } else {
                    current_TextBox.Text += "4";
                }
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "5";
                } else {
                    current_TextBox.Text += "5";
                }
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "6";
                } else {
                    current_TextBox.Text += "6";
                }
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "7";
                } else {
                    current_TextBox.Text += "7";
                }
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "8";
                } else {
                    current_TextBox.Text += "8";
                }
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "9";
                } else {
                    current_TextBox.Text += "9";
                }
            }
        }

        private void btn_0_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                if (current_TextBox.Text == "0") {
                    current_TextBox.Text = "0";
                } else {
                    current_TextBox.Text += "0";
                }
            }
        }
        #endregion

        #region Znaki obliczeniowie;
        private void btn_Sum_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_Substract_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_Multiply_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_Devide_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_Power_Click(object sender, RoutedEventArgs e) {

        }

        private void btn_Root_Click(object sender, RoutedEventArgs e) {

        }
        #endregion
        
        #region Czyszczenie + przecinek
        private void btn_C_Click(object sender, RoutedEventArgs e) {
            current_TextBox.Text = "0";
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e) {
            liczba1 = 0;
            liczba2 = 0;
            znak = null;
            current_TextBox.Text = "0";
            full_TextBox.Text = "0";
        }
        private void btn_Coma_Click(object sender, RoutedEventArgs e) {
            if (current_TextBox.Text.Length <= 9) {
                bool IsComaInText = false;
                foreach (char znaczek in current_TextBox.Text) {
                    if (znaczek == 0x2e) {
                        IsComaInText = false;
                        return;
                    } else {
                        IsComaInText = true;
                    }
                }
                if (IsComaInText) {
                    current_TextBox.Text += ".";
                }
            }
        }
        #endregion
        private void btn_Equal_Click(object sender, RoutedEventArgs e) {

        }

        private void lenghtCheck_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show(current_TextBox.Text.Length.ToString());
        }
    }
}
