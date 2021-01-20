﻿using CatchPhrase.Properties;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CatchPhrase
{
    public partial class FormTypePhrases : Form
    {
        public FormTypePhrases()
        {
            InitializeComponent();
        }

        private void FormTypePhrases_Load(object sender, EventArgs e)
        {

        }

        /// <summary> Обновление содержимого таблицы данными из бд </summary>
        private void UpdateTable()
        {
            // отписаться от события изменения содержимого редактируемой ячейки
            grid.CellEndEdit -= GridOnCellEndEdit;
            // Получим индекс текущей выделенной строки (если выделено)
            int sel = grid.CurrentRow?.Index ?? -1;
            // Создадим подключение к бд
            using (SqlConnection con = new SqlConnection(Settings.Default.ConnectionString))
            {
                con.Open(); // Откроем соединение
                // Считаем требуемую таблицу
                var adapter = new SqlDataAdapter("SELECT * FROM TypePhrase", con);
                var dat = new DataTable();
                // заполним таблицу данными
                adapter.Fill(dat);
                if (grid.DataSource == null)
                {
                    grid.Rows.Clear();
                    grid.Columns.Clear();
                }

                // установим таблицу ресурсом данных для DataGridView
                grid.DataSource = dat;
                // если надо отобразим поле Id записи
                if (Settings.Default.ShowIdTables)
                {
                    // Установим факсированную длину столбца
                    grid.Columns[0].Width = 25;
                    // Поле Id - только чтение
                    grid.Columns[0].ReadOnly = true;
                }
                else // иначе спрячем колонку с id
                    grid.Columns[0].Visible = false;

                // установим наименования заголовков gridView
                grid.Columns[1].HeaderText = @"Тип";
                // Выровняем заголовки равномерно по ширине таблицы
                grid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // если была выделена строка, восстановим выделение
            if (sel >= 0)
                grid.Rows[sel].Selected = true;
            // подпишимся заново на событие изменения содержимого редактируемой ячейки
            grid.CellEndEdit += GridOnCellEndEdit;
        }

        /// <summary> Изменение содержимого редактируемой ячейки, изменение содержимого в бд </summary>
        private void GridOnCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Создадим подключение к бд
            using (SqlConnection con = new SqlConnection(Settings.Default.ConnectionString))
            {
                con.Open(); // Откроем соединение
                // Обновим значение отредактированной ячейки
                new SqlCommand($"UPDATE TypePhrase SET {grid.Columns[e.ColumnIndex].Name}" +
                               $"=N'{grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value}' " +
                               $"WHERE Id={grid.Rows[e.RowIndex].Cells[0].Value}", con)
                    .ExecuteNonQuery();
            }
        }

        /// <summary> Добавление новой пустой записи в базу данных </summary>
        private void insert_Click(object sender, EventArgs e)
        {
            // Создадим подключение к бд
            using (SqlConnection con = new SqlConnection(Settings.Default.ConnectionString))
            {
                con.Open(); // Откроем соединение
                // Добавим пустую запись в таблицу Author
                new SqlCommand($"INSERT INTO TypePhrase(Id,Name) VALUES({grid.Rows.Count + 1},N' ')", con)
                    .ExecuteNonQuery();
            }

            UpdateTable(); // Обновим содержимое таблицы
            // Выделим последнюю строку таблицы (новая созданная запись)
            grid.Rows[grid.RowCount - 1].Selected = true;
        }

        /// <summary> Удаление выделенной записи </summary>
        private void remote_Click(object sender, EventArgs e)
        {
            // получить Id удаляемой записи
            int selId = grid.CurrentRow?.Index ?? 0;
            // выйти если не выделена строка
            if (selId < 1) return;
            // спросить пользователя разрешение на даление записи
            if (MessageBox.Show($@"Удалить тип - '{grid.CurrentRow?.Cells[1]}' ?",
                    @"Внимание...", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes) return;
            // Создадим подключение к бд
            using (SqlConnection con = new SqlConnection(Settings.Default.ConnectionString))
            {
                con.Open(); // Откроем соединение
                // Добавим пустую запись в таблицу Author
                new SqlCommand($"DELETE FROM TypePhrase WHERE Id={selId}", con).ExecuteNonQuery();
            }
            UpdateTable(); // Обновим содержимое таблицы
        }

        private void back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
