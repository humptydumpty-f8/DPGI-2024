using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp38
{
    public class MyDB
    {
        String connectionString; // Рядок з'єднання 
        DataTable dt; // Посилання на об'єкт DataTable

        public MyDB()
        {
            this.connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\DPGI-2024\91 Відображення таблиці БД в DataGrid\learnSQl.mdf;Integrated Security=True";
            this.dt = new DataTable();
        }

        public DataTable TableLoad()
        {
            // Заповнюємо об'єкт таблиці даними з БД

            using (SqlConnection сonnection = new SqlConnection(this.connectionString)) // Створюємо об'єкт підключення
            {
                SqlCommand selectedCommand = сonnection.CreateCommand(); // Створюємо об'єкт команди
                selectedCommand.CommandText = "Select * From OFFICER";

                SqlDataAdapter adapter = new SqlDataAdapter(selectedCommand); // Створюємо об'єкт читання

                //Завантажує дані та схему таблиці               
                try
                {
                    // Метод сам відкриває БД і сам її закриває
                    adapter.Fill(dt);
                }
                catch (Exception)
                {
                    MessageBox.Show("Помилка підключення до БД");
                }
            }
            return dt;
        }
    }
}
