using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace DataTableWPFExample
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // поля
        DataTable table = null;

        // методы
        public MainWindow()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection connection = GetDbConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand(queryTextBox.Text, connection);
            var reader = cmd.ExecuteReader();
            // результат запроса считывается в СУБД-подобную структуру - DataTable
            table = new DataTable();
            int line = 0;
            do
            {
                while (reader.Read())
                {
                    //на первой итерации формируем колонки
                    if (line == 0)
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            table.Columns.Add(reader.GetName(i));
                        }
                        line++;
                    }
                    //поскольку колонки уже готовы,
                    //то на каждой итерации создаем
                    //и заполняем очередную строку
                    DataRow row = table.NewRow();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        row[i] = reader[i]; //заполняем строку
                                            //из reader
                    }
                    table.Rows.Add(row); //добавляем
                                         //очередную строку
                }
            } while (reader.NextResult());

            resultDataGrid.ItemsSource = table.DefaultView;

            connection.Close();
            reader.Close();
        }

        // вспомогательные методы
        SqlConnection GetDbConnection()
        {
            // 1. создаем подключение к БД
            SqlConnection connection = new SqlConnection();
            // 2. устанавливаем строку подключения
            connection.ConnectionString = @"
                Data Source=fishman\SQLEXPRESS; 
                Initial Catalog=computer_game_db; 
                Integrated Security=SSPI; 
                Connect Timeout=30;";
            // 3. возвращаем результат - созданное подключение
            return connection;
        }
    }
}
