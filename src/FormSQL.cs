using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace CinemaReferenceService
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void radioButtonActors_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Актеры");
        }

        private void radioButtonPrizes_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Название_премии, Категория_номинации, 
                Дата_присуждения, Фильмы.Название AS 'Название фильма' FROM Призы, Фильмы 
                WHERE Фильмы.Id_фильма = Призы.Id_фильма");
        }

        private void radioButtonFilmsFS_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"
                SELECT Название, Жанр, COUNT(Сеансы.Id_фильма) AS [Количество показов] 
                FROM Фильмы, Сеансы 
                WHERE Сеансы.Id_фильма = Фильмы.Id_фильма 
                GROUP BY Жанр, Название 
                ORDER BY [Количество показов] DESC");
        }

        private void buttonFullSelect_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCinema.Text))
            {
                MessageBox.Show("Обязательно укажите название необходимого кинотеатра.\nДопустим ввод первых символов.", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkBoxMore.Checked && String.IsNullOrEmpty(textBoxMore.Text))
            {
                MessageBox.Show("Не указана прибыль в условии", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBoxMore.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Films.Checked)
                sqlSelect = @"
                    SELECT Фильмы.Id_фильма, Название, COUNT(Сеансы.Id_фильма) AS Количество_сеансов,
                    CAST(SUM((Вместимость - Количество_свободных_мест) * Сеансы.Цена_билета / 2) AS decimal (16, 2)) AS Прибыль 
                    FROM Залы, Фильмы, Сеансы 
                    WHERE Залы.Название_кинотеатра LIKE @cinema 
                    AND Фильмы.Id_фильма = Сеансы.Id_фильма 
                    AND Сеансы.Название_кинотеатра = Залы.Название_кинотеатра 
                    AND Сеансы.Номер_зала = Залы.Номер_зала
                    GROUP BY Название, Фильмы.Id_фильма";
            else if (radioButtonDet_Genre.Checked)
                sqlSelect = @"
                    SELECT Жанр, COUNT(DISTINCT Фильмы.Id_фильма) AS Количество_фильмов, COUNT(Сеансы.Id_фильма) AS Количество_сеансов,  
                    CAST(SUM((Вместимость - Количество_свободных_мест) * Сеансы.Цена_билета / 2) AS decimal (16, 2)) AS Прибыль
                    FROM Залы, Фильмы, Сеансы 
                    WHERE Залы.Название_кинотеатра LIKE @cinema 
                    AND Фильмы.Id_фильма = Сеансы.Id_фильма 
                    AND Сеансы.Название_кинотеатра = Залы.Название_кинотеатра 
                    AND Сеансы.Номер_зала = Залы.Номер_зала
                    GROUP BY Жанр";
            else
                sqlSelect = @"
                    SELECT Id_сеанса, Дата, Время, Название,
                    Вместимость - Количество_свободных_мест AS Количество_занятых_мест,  
                    CAST(SUM((Вместимость - Количество_свободных_мест) * Сеансы.Цена_билета / 2) AS decimal (16, 2)) AS Прибыль
                    FROM Сеансы, Залы, Фильмы
                    WHERE Сеансы.Название_кинотеатра LIKE @cinema
                    AND Фильмы.Id_фильма = Сеансы.Id_фильма 
                    AND Сеансы.Название_кинотеатра = Залы.Название_кинотеатра 
                    AND Сеансы.Номер_зала = Залы.Номер_зала
                    GROUP BY Id_сеанса, Дата, Время, Название, Вместимость - Количество_свободных_мест";
            if (checkBoxMore.Checked)
            {
                sqlSelect += " HAVING SUM((Вместимость - Количество_свободных_мест) * Сеансы.Цена_билета / 2) > @amount";
            }
            if (checkBoxOrder.Checked)
            {
                sqlSelect += " ORDER BY Прибыль DESC";
            }
            else sqlSelect += " ORDER BY Прибыль ASC";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@cinema", textBoxCinema.Text + "%");
            if (checkBoxMore.Checked)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(textBoxMore.Text);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkBoxMore.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewFullSelect.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNumber.Text))
            {
                MessageBox.Show("Обязательно укажите идентификатор необходимого фильма",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonCorrelated.Checked)
                sqlSelect = @"
                    SELECT Id_сеанса, Название_кинотеатра, Номер_зала,
                    (SELECT Фильмы.Название FROM Фильмы 
                    WHERE Сеансы.Id_фильма = Фильмы.Id_фильма) AS Фильм,
                    CAST(Дата as nvarchar) + ' ' + CAST(Время as nvarchar) AS Дата_время, 
                    Цена_билета, Количество_свободных_мест
                    FROM Сеансы
                    WHERE Id_фильма = @film";
            else if (radioButtonNoCorrelated.Checked)
                sqlSelect = @"
                    SELECT Id_сеанса, Название_кинотеатра, Номер_зала, Название,
                    Дата, Время, Цена_билета, Количество_свободных_мест
                    FROM Сеансы INNER JOIN Фильмы ON Сеансы.Id_фильма = Фильмы.Id_фильма
                    WHERE Сеансы.Id_фильма = @film
                    AND Сеансы.Цена_билета <= 
                    (SELECT AVG(Цена_билета) FROM Сеансы
                    WHERE Сеансы.Id_фильма = @film)";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.Add("@film", SqlDbType.Int).Value =
                int.Parse(textBoxNumber.Text);
            }
            catch
            {
                MessageBox.Show("Идентификатор фильма в условии должен быть задан числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewSubquery.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
            "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked)
                InsertSession();
            else if (radioButtonUpdate.Checked)
                UpdateSession();
            else if (radioButtonDelete.Checked)
                DeleteSession();
            else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e)
        {
            panelSession.Visible = !radioButtonDelete.Checked;
        }

        private void buttonSelectSessions_Click(object sender, EventArgs e)
        {
            dataGridViewSessions.DataSource = FillDataGridView("SELECT * FROM Сеансы");
        }

        void InsertSession()
        {
            if (String.IsNullOrEmpty(textBoxId_session.Text) ||
                String.IsNullOrEmpty(textBoxSessionCinema.Text) ||
                String.IsNullOrEmpty(textBoxSessionHall.Text) ||
                String.IsNullOrEmpty(textBoxSessionDate.Text) ||
                String.IsNullOrEmpty(textBoxSessionTime.Text) ||
                String.IsNullOrEmpty(textBoxSessionCost.Text) ||
                String.IsNullOrEmpty(listBoxSessionFormat.Text))
            {
                MessageBox.Show("Обязательно введите Id фильма, название кинотеатра, номера зала, дата, время, цена билета, формат показа", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSession;
            if (!int.TryParse(textBoxId_session.Text, out idSession))
            {
                MessageBox.Show("Некоректное значение идентификатора сеанса!", 
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hallNumber;
            if (!int.TryParse(textBoxSessionHall.Text, out hallNumber))
            {
                MessageBox.Show("Некоректное значение номера зала!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = 0;
            if (!double.TryParse(textBoxSessionCost.Text, out price))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlInsert = @"INSERT INTO Сеансы (Id_сеанса, Название_кинотеатра, Номер_зала,
                Id_фильма, Дата, Время, Цена_билета, Формат_показа, Количество_свободных_мест)
                VALUES (@idSession, @cinema, @hall, @idFilm, @date, @time, @cost, @format, @freePlaceCount)";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;

            command.Parameters.AddWithValue("@idSession", idSession);
            command.Parameters.AddWithValue("@cinema", textBoxSessionCinema.Text);
            command.Parameters.AddWithValue("@hall", hallNumber);
            command.Parameters.AddWithValue("@date", textBoxSessionDate.Text);
            command.Parameters.AddWithValue("@time", textBoxSessionTime.Text);
            command.Parameters.AddWithValue("@cost", textBoxSessionCost.Text);
            command.Parameters.AddWithValue("@format", listBoxSessionFormat.Text);
            if (!String.IsNullOrEmpty(textBoxSessionFilm.Text))
            {
                int idFilm;
                if (!int.TryParse(textBoxSessionFilm.Text, out idFilm))
                {
                    MessageBox.Show("Некоректное значение идентификатора фильма!",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                command.Parameters.AddWithValue("@idFilm", idFilm);
            }
            else
            {
                command.Parameters.AddWithValue("@idFilm", DBNull.Value);
            }
            if (!String.IsNullOrEmpty(textBoxSessionFreePlacesCount.Text))
            {
                int freePlaceCount;
                if (!int.TryParse(textBoxSessionFreePlacesCount.Text, out freePlaceCount))
                {
                    MessageBox.Show("Некоректное значение количества свободных мест!",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                command.Parameters.AddWithValue("@freePlaceCount", freePlaceCount);
            }
            else
            {
                command.Parameters.AddWithValue("@freePlaceCount", DBNull.Value);
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();
            buttonSelectSessions_Click(this, EventArgs.Empty);
        }

        void UpdateSession()
        {
            if (String.IsNullOrEmpty(textBoxId_session.Text))
            {
                MessageBox.Show("Обязательно введите Id фильма, для которого будете менять данные",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSession;
            if (!int.TryParse(textBoxId_session.Text, out idSession))
            {
                MessageBox.Show("Некоректное значение идентификатора фильма!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idFilm;
            if (!int.TryParse(textBoxSessionFilm.Text, out idFilm))
            {
                MessageBox.Show("Некоректное значение идентификатора фильма!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int hallNumber;
            if (!int.TryParse(textBoxSessionHall.Text, out hallNumber))
            {
                MessageBox.Show("Некоректное значение номера зала!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int freePlaceCount;
            if (!int.TryParse(textBoxSessionFreePlacesCount.Text, out freePlaceCount))
            {
                MessageBox.Show("Некоректное значение количества свободных мест!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double price = 0;
            if (!double.TryParse(textBoxSessionCost.Text, out price))
            {
                MessageBox.Show("Некоректное значение цены!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "UPDATE Сеансы SET {0} Формат_показа = @format WHERE Id_сеанса = @idSession";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();

            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxSessionCinema.Text))
                sqlValues += "Название_кинотеатра=@cinema,";
            if (!String.IsNullOrEmpty(textBoxSessionHall.Text))
                sqlValues += "Номер_зала=@hall,";
            if (!String.IsNullOrEmpty(textBoxSessionFilm.Text))
                sqlValues += "Id_фильма=@film,";
            if (!String.IsNullOrEmpty(textBoxSessionDate.Text))
                sqlValues += "Дата=@date,";
            if (!String.IsNullOrEmpty(textBoxSessionTime.Text))
                sqlValues += "Время=@time,";
            if (!String.IsNullOrEmpty(textBoxSessionCost.Text))
                sqlValues += "Цена_билета=@cost,";
            if (!String.IsNullOrEmpty(textBoxSessionFreePlacesCount.Text))
                sqlValues += "Количество_свободных_мест=@freePlacesCount,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBoxSessionCinema.Text))
                command.Parameters.AddWithValue("@cinema", textBoxSessionCinema.Text);
            if (!String.IsNullOrEmpty(textBoxSessionHall.Text))
                command.Parameters.AddWithValue("@hall", hallNumber);
            if (!String.IsNullOrEmpty(textBoxSessionFilm.Text))
                command.Parameters.AddWithValue("@film", idFilm);
            if (!String.IsNullOrEmpty(textBoxSessionDate.Text))
                command.Parameters.Add("@date", SqlDbType.Date).Value = textBoxSessionDate.Text;
            if (!String.IsNullOrEmpty(textBoxSessionTime.Text))
                command.Parameters.Add("@time", SqlDbType.Time).Value = textBoxSessionTime.Text;
            if (!String.IsNullOrEmpty(textBoxSessionCost.Text))
                command.Parameters.Add("@cost", SqlDbType.Decimal).Value = price;
            if (!String.IsNullOrEmpty(textBoxSessionFreePlacesCount.Text))
                command.Parameters.AddWithValue("@freePlacesCount", freePlaceCount);
            command.Parameters.AddWithValue("@format", listBoxSessionFormat.Text);
            command.Parameters.AddWithValue("@idSession", idSession);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();
            buttonSelectSessions_Click(this, EventArgs.Empty);
        }

        void DeleteSession()
        {
            if (String.IsNullOrEmpty(textBoxId_session.Text))
            {
                MessageBox.Show("Обязательно введите Id фильма, запись о котором хотите удалить",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idSession;
            if (!int.TryParse(textBoxId_session.Text, out idSession))
            {
                MessageBox.Show("Некоректное значение идентификатора фильма!",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlDelete = @"DELETE FROM Сеансы WHERE Id_сеанса=@idSession";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.CinemaReferenceServiceConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@idSession", idSession);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelectSessions_Click(this, EventArgs.Empty);
        }
    }
}
