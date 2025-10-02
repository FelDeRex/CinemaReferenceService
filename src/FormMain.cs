using CinemaReferenceService.Properties;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
                "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
            Settings.Default.Save();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Погудин Владимир Юрьевич,580-3,2022", "О программе",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void кинотеатрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCinemaList.formCinema.ShowForm();
        }

        private void залыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHallList.formHall.ShowForm();
        }

        private void фильмыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFilmList.formFilm.ShowForm();
        }

        private void сеансыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSessionsList.formSessions.ShowForm();
        }

        private void призыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPrizeList.formPrize.ShowForm();
        }

        private void актерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActorsList.formActors.ShowForm();
        }

        private void запросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL formSQL = new FormSQL();
            formSQL.Show();
        }
    }
}
