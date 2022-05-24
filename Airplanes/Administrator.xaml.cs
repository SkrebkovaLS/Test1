using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для Administrator.xaml
    /// </summary>
    public partial class Administrator : Window
    {
        UserViewTableAdapter userViewTableAdapter = new UserViewTableAdapter();
        OfficesTableAdapter officesTableAdapter = new OfficesTableAdapter();
        UsersTableAdapter usersTableAdapter = new UsersTableAdapter();
        public Administrator()
        {
            InitializeComponent();
            dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
            office.ItemsSource = officesTableAdapter.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser(this);
            IsEnabled = false;
            addUser.Show();
            }

        private void enable_disable_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dg_admin_user.SelectedItem;
            String active = drv["Active"].ToString();
            if(drv != null)
            {
                try
                {
                    if(Convert.ToBoolean(active) == true)
                    {
                        string id = drv["ID"].ToString();
                        usersTableAdapter.UpdateActive(false,Convert.ToInt32(id));
                        dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
                    }
                    else
                    {
                        string id = drv["ID"].ToString();
                        usersTableAdapter.UpdateActive(true, Convert.ToInt32(id));
                        dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось сохранить изменения");
                }
            }
            else
            {
                MessageBox.Show("Вы не выбрали пользователя");
            }
        }

        private void office_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(office.SelectedIndex != -1)
            {
                dg_admin_user.ItemsSource = userViewTableAdapter.GetDataBy(office.SelectedValue.ToString());
            }
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            office.SelectedIndex = -1;
            dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
        }

        private void remove_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dg_admin_user.SelectedItem;
            if (drv != null)
            {
                String id = drv["ID"].ToString();
                usersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                dg_admin_user.ItemsSource = userViewTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Вы не выбрали пользователя для удаления");
            }
        }

        private void Change_role_Click(object sender, RoutedEventArgs e)
        {
            DataRowView drv = (DataRowView)dg_admin_user.SelectedItem;
            if (drv != null)
            {
                String id = drv["ID"].ToString();
                EditUser editUser = new EditUser(this, id);
                IsEnabled = false;
                editUser.Show();

            }
            else
            {
                MessageBox.Show("Вы не выбрали пользователя для удаления");
            }
        }
    }
}
