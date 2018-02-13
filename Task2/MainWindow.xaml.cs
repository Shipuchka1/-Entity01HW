using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Task2.Model;
using System.Data.Entity;

namespace AdoNetHW3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        public Model1 db = new Model1();
        public MainWindow()
        {
            InitializeComponent();
            DataListView.ItemsSource = db.TablesManufacturers.ToList();
                     
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            TablesManufacturer t = (TablesManufacturer)DataWrapPanel.DataContext;



            try
            {
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Изменения сохранены");
                DataListView.ItemsSource = db.TablesManufacturers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TablesManufacturer rec = new TablesManufacturer();
                rec.strManufacturerChecklistId = strManufacturerChecklistIdTextBox.Text;
                rec.strName = strNameTextBox.Text;
                db.TablesManufacturers.Add(rec);
                db.SaveChanges();
                MessageBox.Show("Запись добавлена");
                DataListView.ItemsSource = db.TablesManufacturers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void DataListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataListView.SelectedIndex != -1)
            {
                intManufacturerIDTextBox.Text = ((TablesManufacturer)DataListView.SelectedItem).intManufacturerID.ToString();
                strManufacturerChecklistIdTextBox.Text = ((TablesManufacturer)DataListView.SelectedItem).strManufacturerChecklistId;
                strNameTextBox.Text = ((TablesManufacturer)DataListView.SelectedItem).strName;
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.TablesManufacturers.Remove((TablesManufacturer)DataListView.SelectedItem);
                db.SaveChanges();
                MessageBox.Show("Запись удалена");
                DataListView.ItemsSource = db.TablesManufacturers.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

   
}
