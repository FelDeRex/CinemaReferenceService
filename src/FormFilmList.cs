using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaReferenceService
{
    public partial class FormFilmList : Form
    {
        public FormFilmList()
        {
            InitializeComponent();
        }

        private void фильмыBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.фильмыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormFilmList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Призы". При необходимости она может быть перемещена или удалена.
            this.призыTableAdapter.Fill(this.cinemaDataSet.Призы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.cinemaDataSet.Роли);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.cinemaDataSet.Фильмы);

        }

        private static FormFilmList f;
        public static FormFilmList formFilm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormFilmList();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            фильмыBindingSource.Position = 0;
            Show();
            Activate();
        }

        private void buttonOpenPicture_Click(object sender, EventArgs e)
        {
            string fileImage = "";
            openFileDialogPicture.Title = "Укажите файл для картинки";
            if (openFileDialogPicture.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPicture.FileName;
                try
                {
                    кадр_из_фильмаPictureBox.Image = new Bitmap(openFileDialogPicture.FileName);
                }
                catch
                {
                    MessageBox.Show("Выбран не тот формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else fileImage = "";
        }

        private void ролиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ролиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
        }

        private void ролиBindingNavigatorOpenActors_Click(object sender, EventArgs e)
        {
            FormActorsList.formActors.ShowForm();
        }

        private void призыBindingNavigatorOpenPrizes_Click(object sender, EventArgs e)
        {
            FormPrizeList.formPrize.ShowForm();
        }

        private void ролиBindingNavigatorOpenRoles_Click(object sender, EventArgs e)
        {
            FormRolesList.formRoles.ShowForm();
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return (int)((DataRowView)фильмыBindingSource.Current)["Id_фильма"];
            else
                return -1;
        }

        private void FormFilmList_Shown(object sender, EventArgs e)
        {
            фильмыBindingSource.Position = фильмыBindingSource.Find("Id_фильма", idCurrent);
        }

        private void ролиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = "";
            if
            (((DataRowView)ролиBindingSource.Current)["ФИО_актера"].ToString() != "")
            {
                name = (string)(((DataRowView)ролиBindingSource.Current)["ФИО_актера"]);
            }
            name = FormActorsList.formActors.ShowSelectForm(name);
            if (name != "")
            {
                MessageBox.Show(name);
                ((DataRowView)ролиBindingSource.Current)["ФИО_актера"] = name;
                ролиBindingSource.EndEdit();
            }
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                фильмыBindingSource.Find("Название",
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                фильмыBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Такого фильма нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                фильмыBindingSource.Position = 0;
            }
        }
    }
}
