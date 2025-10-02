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
    public partial class FormCinemaList : Form
    {
        public FormCinemaList()
        {
            InitializeComponent();
        }

        private void кинотеатрыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.кинотеатрыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err) 
            { 
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void залыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.залыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCinemaList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Залы". При необходимости она может быть перемещена или удалена.
            this.залыTableAdapter.Fill(this.cinemaDataSet.Залы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Кинотеатры". При необходимости она может быть перемещена или удалена.
            this.кинотеатрыTableAdapter.Fill(this.cinemaDataSet.Кинотеатры);

        }

        private static FormCinemaList f;
        public static FormCinemaList formCinema
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormCinemaList();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
