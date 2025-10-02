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
    public partial class FormRolesList : Form
    {
        public FormRolesList()
        {
            InitializeComponent();
        }

        private void ролиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.ролиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormRolesList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.cinemaDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Роли". При необходимости она может быть перемещена или удалена.
            this.ролиTableAdapter.Fill(this.cinemaDataSet.Роли);

        }

        private static FormRolesList f;
        public static FormRolesList formRoles
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormRolesList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return ролиDataGridView.Columns[ролиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                ролиBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                ролиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких связей нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ролиBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        ролиBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                ролиBindingSource.Filter = "";
            if (ролиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                ролиBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void название_фильмаDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = -1;
            if
            (((DataRowView)ролиBindingSource.Current)["Id_фильма"].ToString() != "")
            {
                id = (int)(((DataRowView)ролиBindingSource.Current)["Id_фильма"]);
            }
            id = FormFilmList.formFilm.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)ролиBindingSource.Current)["Id_фильма"] = id;
                ролиBindingSource.EndEdit();
            }
        }

        
    }
}
