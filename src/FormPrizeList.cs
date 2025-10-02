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
    public partial class FormPrizeList : Form
    {
        public FormPrizeList()
        {
            InitializeComponent();
        }

        private void призыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.призыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormPrizeList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this.cinemaDataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Призы". При необходимости она может быть перемещена или удалена.
            this.призыTableAdapter.Fill(this.cinemaDataSet.Призы);
        }

        private static FormPrizeList f;
        public static FormPrizeList formPrize
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormPrizeList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void filmButton_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
            (((DataRowView)призыBindingSource.Current)["Id_фильма"].ToString() != "")
            {
                id = (int)(((DataRowView)призыBindingSource.Current)["Id_фильма"]);
            }
            id = FormFilmList.formFilm.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)призыBindingSource.Current)["Id_фильма"] = id;
                призыBindingSource.EndEdit();
                фильмыTableAdapter.Fill(this.cinemaDataSet.Фильмы);
            }
        }
    }
}
