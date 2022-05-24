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
using Airplanes.DataSetAirplanesTableAdapters;


namespace Airplanes
{
    /// <summary>
    /// Логика взаимодействия для AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        Administrator main;
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        UserViewTableAdapter userViewTableAdapter = new UserViewTableAdapter();

        public AddUser(Administrator main)
        {
            InitializeComponent();
            this.main = main;
            office.ItemsSource = officesTableAdapter.GetData();
        }

        private void btn_cancel_Click(object sender, RoutedEventArgs e)
        {
            main.IsEnabled = true;
            Close();
        }

        private void btn_save_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if(last_name.Text == "")
            {
                errors.AppendLine("Укажите фамилию");
            }
            if (email.Text == "")
            {
                errors.AppendLine("Укажите почту");
            }
            else
            {
                string emails = email.Text;
                if(!emails.Contains('@'))
                    errors.AppendLine("Укажите верный формат почты");
            }
            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                errors.AppendLine("Укажите имя");
            }
            if(string.IsNullOrWhiteSpace(password.Password))
            {
                errors.AppendLine("Укажите пароль");
            }
            if (string.IsNullOrWhiteSpace(date.Text))
            {
                errors.AppendLine("Укажите дату рождения");
            }
            if (string.IsNullOrWhiteSpace(office.Text))
            {
                errors.AppendLine("Выберите офис");
            }
            if(errors.Length >0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                string office_name = office.Text;
                int id_office = Convert.ToInt32(officesTableAdapter.ID(office_name));
                usersTableAdapter.Save(2, email.Text, password.Password, first_name.Text, last_name.Text, officesTableAdapter.ID(office_name), date.Text, true);
                main.dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
                main.IsEnabled = true;
                Close();
            }
        }
    }
}
