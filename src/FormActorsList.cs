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
    public partial class FormActorsList : Form
    {
        public FormActorsList()
        {
            InitializeComponent();
        }

        private void актерыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.актерыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.cinemaDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormActorsList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cinemaDataSet.Актеры". При необходимости она может быть перемещена или удалена.
            this.актерыTableAdapter.Fill(this.cinemaDataSet.Актеры);

        }

        private static FormActorsList f;
        public static FormActorsList formActors
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormActorsList();
                return f;
            }
        }

        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            актерыBindingSource.Position = 0;
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return актерыDataGridView.Columns[актерыDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                актерыBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                актерыBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких актеров нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                актерыBindingSource.Position = 0;
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
                        актерыBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                актерыBindingSource.Filter = "";
            if (актерыBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                актерыBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        string nameCurrent = "";
        public string ShowSelectForm(string name)
        {
            toolStripButtonOK.Visible = true;
            nameCurrent = name;
            if (ShowDialog() == DialogResult.OK)
                return (string)((DataRowView)актерыBindingSource.Current)["ФИО_актера"];
            else
                return "";
        }

        private void FormActorsList_Shown(object sender, EventArgs e)
        {
            актерыBindingSource.Position = актерыBindingSource.Find("ФИО_актера", nameCurrent);
        }
    }
}
