namespace CinemaReferenceService
{
    partial class FormCinemaList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label название_кинотеатраLabel;
            System.Windows.Forms.Label районLabel;
            System.Windows.Forms.Label адресLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCinemaList));
            this.cinemaDataSet = new CinemaReferenceService.CinemaDataSet();
            this.кинотеатрыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.кинотеатрыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.КинотеатрыTableAdapter();
            this.tableAdapterManager = new CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager();
            this.кинотеатрыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.кинотеатрыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.название_кинотеатраTextBox = new System.Windows.Forms.TextBox();
            this.районTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxHalls = new System.Windows.Forms.GroupBox();
            this.залыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.залыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ЗалыTableAdapter();
            this.ролиbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.залыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            название_кинотеатраLabel = new System.Windows.Forms.Label();
            районLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingNavigator)).BeginInit();
            this.кинотеатрыBindingNavigator.SuspendLayout();
            this.groupBoxHalls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиbindingNavigator)).BeginInit();
            this.ролиbindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // название_кинотеатраLabel
            // 
            название_кинотеатраLabel.AutoSize = true;
            название_кинотеатраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_кинотеатраLabel.Location = new System.Drawing.Point(14, 55);
            название_кинотеатраLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            название_кинотеатраLabel.Name = "название_кинотеатраLabel";
            название_кинотеатраLabel.Size = new System.Drawing.Size(219, 25);
            название_кинотеатраLabel.TabIndex = 1;
            название_кинотеатраLabel.Text = "Название кинотеатра:";
            // 
            // районLabel
            // 
            районLabel.AutoSize = true;
            районLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            районLabel.Location = new System.Drawing.Point(14, 95);
            районLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            районLabel.Name = "районLabel";
            районLabel.Size = new System.Drawing.Size(73, 25);
            районLabel.TabIndex = 3;
            районLabel.Text = "Район:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адресLabel.Location = new System.Drawing.Point(14, 135);
            адресLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(75, 25);
            адресLabel.TabIndex = 5;
            адресLabel.Text = "Адрес:";
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // кинотеатрыBindingSource
            // 
            this.кинотеатрыBindingSource.DataMember = "Кинотеатры";
            this.кинотеатрыBindingSource.DataSource = this.cinemaDataSet;
            // 
            // кинотеатрыTableAdapter
            // 
            this.кинотеатрыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.ЗалыTableAdapter = null;
            this.tableAdapterManager.КинотеатрыTableAdapter = this.кинотеатрыTableAdapter;
            this.tableAdapterManager.ПризыTableAdapter = null;
            this.tableAdapterManager.РолиTableAdapter = null;
            this.tableAdapterManager.СеансыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // кинотеатрыBindingNavigator
            // 
            this.кинотеатрыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.кинотеатрыBindingNavigator.BindingSource = this.кинотеатрыBindingSource;
            this.кинотеатрыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.кинотеатрыBindingNavigator.CountItemFormat = "из {0}";
            this.кинотеатрыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.кинотеатрыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.кинотеатрыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.кинотеатрыBindingNavigatorSaveItem});
            this.кинотеатрыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.кинотеатрыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.кинотеатрыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.кинотеатрыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.кинотеатрыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.кинотеатрыBindingNavigator.Name = "кинотеатрыBindingNavigator";
            this.кинотеатрыBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.кинотеатрыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.кинотеатрыBindingNavigator.Size = new System.Drawing.Size(782, 34);
            this.кинотеатрыBindingNavigator.TabIndex = 0;
            this.кинотеатрыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(69, 31);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 33);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 31);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // кинотеатрыBindingNavigatorSaveItem
            // 
            this.кинотеатрыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.кинотеатрыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("кинотеатрыBindingNavigatorSaveItem.Image")));
            this.кинотеатрыBindingNavigatorSaveItem.Name = "кинотеатрыBindingNavigatorSaveItem";
            this.кинотеатрыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 31);
            this.кинотеатрыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.кинотеатрыBindingNavigatorSaveItem.Click += new System.EventHandler(this.кинотеатрыBindingNavigatorSaveItem_Click);
            // 
            // название_кинотеатраTextBox
            // 
            this.название_кинотеатраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кинотеатрыBindingSource, "Название_кинотеатра", true));
            this.название_кинотеатраTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_кинотеатраTextBox.Location = new System.Drawing.Point(204, 51);
            this.название_кинотеатраTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.название_кинотеатраTextBox.Name = "название_кинотеатраTextBox";
            this.название_кинотеатраTextBox.Size = new System.Drawing.Size(281, 30);
            this.название_кинотеатраTextBox.TabIndex = 2;
            // 
            // районTextBox
            // 
            this.районTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кинотеатрыBindingSource, "Район", true));
            this.районTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.районTextBox.Location = new System.Drawing.Point(204, 91);
            this.районTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.районTextBox.Name = "районTextBox";
            this.районTextBox.Size = new System.Drawing.Size(281, 30);
            this.районTextBox.TabIndex = 4;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.кинотеатрыBindingSource, "Адрес", true));
            this.адресTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адресTextBox.Location = new System.Drawing.Point(204, 131);
            this.адресTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(543, 30);
            this.адресTextBox.TabIndex = 6;
            // 
            // groupBoxHalls
            // 
            this.groupBoxHalls.Controls.Add(this.ролиbindingNavigator);
            this.groupBoxHalls.Controls.Add(this.залыDataGridView);
            this.groupBoxHalls.Location = new System.Drawing.Point(19, 184);
            this.groupBoxHalls.Name = "groupBoxHalls";
            this.groupBoxHalls.Size = new System.Drawing.Size(419, 302);
            this.groupBoxHalls.TabIndex = 7;
            this.groupBoxHalls.TabStop = false;
            this.groupBoxHalls.Text = "Залы";
            // 
            // залыDataGridView
            // 
            this.залыDataGridView.AutoGenerateColumns = false;
            this.залыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.залыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.залыDataGridView.DataSource = this.залыBindingSource;
            this.залыDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.залыDataGridView.Location = new System.Drawing.Point(3, 63);
            this.залыDataGridView.Name = "залыDataGridView";
            this.залыDataGridView.RowHeadersWidth = 51;
            this.залыDataGridView.RowTemplate.Height = 24;
            this.залыDataGridView.Size = new System.Drawing.Size(413, 236);
            this.залыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_зала";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_зала";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название_кинотеатра";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название_кинотеатра";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Вместимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Вместимость";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // залыBindingSource
            // 
            this.залыBindingSource.DataMember = "FK_Кинотеатры_Залы";
            this.залыBindingSource.DataSource = this.кинотеатрыBindingSource;
            // 
            // залыTableAdapter
            // 
            this.залыTableAdapter.ClearBeforeFill = true;
            // 
            // ролиbindingNavigator
            // 
            this.ролиbindingNavigator.AddNewItem = this.toolStripButton1;
            this.ролиbindingNavigator.BindingSource = this.залыBindingSource;
            this.ролиbindingNavigator.CountItem = this.toolStripLabel1;
            this.ролиbindingNavigator.CountItemFormat = "из {0}";
            this.ролиbindingNavigator.DeleteItem = this.toolStripButton2;
            this.ролиbindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ролиbindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.залыBindingNavigatorSaveItem});
            this.ролиbindingNavigator.Location = new System.Drawing.Point(3, 26);
            this.ролиbindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.ролиbindingNavigator.MoveLastItem = this.toolStripButton6;
            this.ролиbindingNavigator.MoveNextItem = this.toolStripButton5;
            this.ролиbindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.ролиbindingNavigator.Name = "ролиbindingNavigator";
            this.ролиbindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ролиbindingNavigator.PositionItem = this.toolStripTextBox1;
            this.ролиbindingNavigator.Size = new System.Drawing.Size(413, 34);
            this.ролиbindingNavigator.TabIndex = 1;
            this.ролиbindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 31);
            this.toolStripLabel1.Text = "из {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(73, 33);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 34);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 31);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 34);
            // 
            // залыBindingNavigatorSaveItem
            // 
            this.залыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.залыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("залыBindingNavigatorSaveItem.Image")));
            this.залыBindingNavigatorSaveItem.Name = "залыBindingNavigatorSaveItem";
            this.залыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 31);
            this.залыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.залыBindingNavigatorSaveItem.Click += new System.EventHandler(this.залыBindingNavigatorSaveItem_Click);
            // 
            // FormCinemaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 498);
            this.Controls.Add(this.groupBoxHalls);
            this.Controls.Add(название_кинотеатраLabel);
            this.Controls.Add(this.название_кинотеатраTextBox);
            this.Controls.Add(районLabel);
            this.Controls.Add(this.районTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(this.кинотеатрыBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCinemaList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Кинотеатры";
            this.Load += new System.EventHandler(this.FormCinemaList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кинотеатрыBindingNavigator)).EndInit();
            this.кинотеатрыBindingNavigator.ResumeLayout(false);
            this.кинотеатрыBindingNavigator.PerformLayout();
            this.groupBoxHalls.ResumeLayout(false);
            this.groupBoxHalls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.залыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиbindingNavigator)).EndInit();
            this.ролиbindingNavigator.ResumeLayout(false);
            this.ролиbindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource кинотеатрыBindingSource;
        private CinemaDataSetTableAdapters.КинотеатрыTableAdapter кинотеатрыTableAdapter;
        private CinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator кинотеатрыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton кинотеатрыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox название_кинотеатраTextBox;
        private System.Windows.Forms.TextBox районTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.GroupBox groupBoxHalls;
        private System.Windows.Forms.BindingSource залыBindingSource;
        private CinemaDataSetTableAdapters.ЗалыTableAdapter залыTableAdapter;
        private System.Windows.Forms.DataGridView залыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingNavigator ролиbindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton залыBindingNavigatorSaveItem;
    }
}