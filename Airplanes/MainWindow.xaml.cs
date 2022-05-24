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
using Airplanes.DataSetAirplanesTableAdapters;

namespace Airplanes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSetAirplanes dataSetAirplanes;
        UsersTableAdapter usersTableAdapter;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        int time = 10;
        int countries = 0;
        public MainWindow()
        {
            InitializeComponent();
            dataSetAirplanes = new DataSetAirplanes();
            usersTableAdapter = new UsersTableAdapter();
            timer.Tick += new EventHandler(timeTicker);
            timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Username.Text != "" && Password.Password != "")
            {
                int? id_user = usersTableAdapter.Login(Username.Text, Password.Password);
                if(id_user != null)
                {
                    if(true == usersTableAdapter.Active(Username.Text, Password.Password).Value)
                    {
                        if(1 == usersTableAdapter.Role(Username.Text, Password.Password))
                        {
                            Administrator stateTable = new Administrator();
                            Close();
                            stateTable.Show();
                        }
                        else
                        {
                            Users stateTable = new Users();
                            Close();
                            stateTable.Show();
                        }
                    }
                    else
                    {
                        errors.Text = "Ваша учтная запись была анулирована администрацией";
                    }
                }
                else
                {
                    if(countries == 2)
                    {
                        btn_login.IsEnabled = false;
                        timer.Start();
                        countries = 0;
                    }
                    else
                    {
                        errors.Text = "Логин или пароль неверны, попробйте еще раз";
                        countries++;
                    }
                    
                }
            }
            else
            {
                errors.Text = "Введите логин и/или пароль";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void timeTicker(object sender, EventArgs e)
        {
            errors.Text = "Повторите попытку через " + time + " секунд";
            time--;
            if(time ==0)
            {
                btn_login.IsEnabled = true;
                errors.Text = "";
                timer.Stop();
            }
        }
    }
}
