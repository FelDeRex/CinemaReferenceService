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
    public partial class FormSessionsList : Form
    {
        public FormSessionsList()
        {
            InitializeComponent();
        }

        private void сеансыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сеансыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormSessionsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.cinemaDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Сеансы". При необходимости она может быть перемещена или удалена.
            this.сеансыTableAdapter.Fill(this.cinemaDataSet.Сеансы);

        }

        private static FormSessionsList f;
        public static FormSessionsList formSessions
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSessionsList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void сеансыDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((сеансыDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn9"].Value == null) || 
                (сеансыDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn9"].Value.ToString() == "2D"))
            {
                e.CellStyle.BackColor = Color.SkyBlue;
            }
            else if (сеансыDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn9"].Value.ToString() == "3D")
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else if (сеансыDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn9"].Value.ToString() == "IMAX 3D")
            {
                e.CellStyle.BackColor = Color.Purple;
            }
        }

        private void фильмDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = -1;
            if
            (((DataRowView)сеансыBindingSource.Current)["Id_фильма"].ToString() != "")
            {
                id = (int)(((DataRowView)сеансыBindingSource.Current)["Id_фильма"]);
            }
            id = FormFilmList.formFilm.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)сеансыBindingSource.Current)["Id_фильма"] = id;
                сеансыBindingSource.EndEdit();
            }
        }
    }
}
