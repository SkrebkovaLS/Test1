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
    /// Логика взаимодействия для EditUser.xaml
    /// </summary>
    public partial class EditUser : Window
    {
        OfficesTableAdapter OfficesTableAdapter = new OfficesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        UserViewTableAdapter userViewTableAdapter = new UserViewTableAdapter();
        Administrator main;
        int id;
        public EditUser(Administrator main, string id)
        {
            InitializeComponent();
            this.main = main;
            this.id = Convert.ToInt32(id);
            office.ItemsSource = OfficesTableAdapter.GetData();
            string email =  usersTableAdapter.Email(Convert.ToInt32(id));
            email_adress.Text = email;
            string firstName = usersTableAdapter.FirstName(Convert.ToInt32(id));
            first_name.Text = firstName;
            int? office_id = usersTableAdapter.Office(Convert.ToInt32(id));
            string offce_title = OfficesTableAdapter.Title(Convert.ToInt32(office_id));
            office.Text = offce_title;

        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            main.IsEnabled = true;
            Close();
        }

        private void btn_apply_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (last_name.Text == "")
            {
                errors.AppendLine("Укажите фамилию");
            }
            if (email_adress.Text == "")
            {
                errors.AppendLine("Укажите почту");
            }
            else
            {
                string emails = email_adress.Text;
                if (!emails.Contains('@'))
                    errors.AppendLine("Укажите верный формат почты");
            }
            if (string.IsNullOrWhiteSpace(first_name.Text))
            {
                errors.AppendLine("Укажите имя");
            }
           
            if (string.IsNullOrWhiteSpace(office.Text))
            {
                errors.AppendLine("Выберите офис");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
            }
            else
            {
                string office_name = office.Text;
                int id_office = Convert.ToInt32(OfficesTableAdapter.ID(office_name));
                usersTableAdapter.UpdateUser(2, email_adress.Text, first_name.Text, last_name.Text, id_office, id);
                main.dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
                main.IsEnabled = true;
                Close();
            }
        }
    }
}
