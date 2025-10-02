namespace CinemaReferenceService
{
    partial class FormSQL
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
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonFilmsFS = new System.Windows.Forms.RadioButton();
            this.radioButtonPrizes = new System.Windows.Forms.RadioButton();
            this.radioButtonActors = new System.Windows.Forms.RadioButton();
            this.tabPageFullSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewFullSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxFullSelect = new System.Windows.Forms.GroupBox();
            this.buttonFullSelect = new System.Windows.Forms.Button();
            this.checkBoxOrder = new System.Windows.Forms.CheckBox();
            this.textBoxMore = new System.Windows.Forms.TextBox();
            this.checkBoxMore = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonDet_None = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Genre = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Films = new System.Windows.Forms.RadioButton();
            this.textBoxCinema = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSubquery = new System.Windows.Forms.TabPage();
            this.dataGridViewSubquery = new System.Windows.Forms.DataGridView();
            this.groupBoxSubquery = new System.Windows.Forms.GroupBox();
            this.buttonSubquery = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonNoCorrelated = new System.Windows.Forms.RadioButton();
            this.radioButtonCorrelated = new System.Windows.Forms.RadioButton();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.labelId_session = new System.Windows.Forms.Label();
            this.textBoxId_session = new System.Windows.Forms.TextBox();
            this.panelSession = new System.Windows.Forms.Panel();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.labelCinema = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSessionCinema = new System.Windows.Forms.TextBox();
            this.textBoxSessionHall = new System.Windows.Forms.TextBox();
            this.textBoxSessionFilm = new System.Windows.Forms.TextBox();
            this.textBoxSessionDate = new System.Windows.Forms.TextBox();
            this.textBoxSessionTime = new System.Windows.Forms.TextBox();
            this.textBoxSessionCost = new System.Windows.Forms.TextBox();
            this.textBoxSessionFreePlacesCount = new System.Windows.Forms.TextBox();
            this.listBoxSessionFormat = new System.Windows.Forms.ListBox();
            this.dataGridViewSessions = new System.Windows.Forms.DataGridView();
            this.buttonSelectSessions = new System.Windows.Forms.Button();
            this.tabControlSQL.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageFullSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).BeginInit();
            this.groupBoxFullSelect.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageSubquery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).BeginInit();
            this.groupBoxSubquery.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.panelSession.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageFullSelect);
            this.tabControlSQL.Controls.Add(this.tabPageSubquery);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(1200, 703);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewSelect);
            this.tabPageSelect.Controls.Add(this.groupBoxSelect);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 34);
            this.tabPageSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageSelect.Size = new System.Drawing.Size(1192, 665);
            this.tabPageSelect.TabIndex = 0;
            this.tabPageSelect.Text = "Запросы";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(4, 94);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.RowHeadersWidth = 51;
            this.dataGridViewSelect.RowTemplate.Height = 24;
            this.dataGridViewSelect.Size = new System.Drawing.Size(1184, 566);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonFilmsFS);
            this.groupBoxSelect.Controls.Add(this.radioButtonPrizes);
            this.groupBoxSelect.Controls.Add(this.radioButtonActors);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(4, 5);
            this.groupBoxSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxSelect.Size = new System.Drawing.Size(1184, 89);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonFilmsFS
            // 
            this.radioButtonFilmsFS.AutoSize = true;
            this.radioButtonFilmsFS.Location = new System.Drawing.Point(223, 33);
            this.radioButtonFilmsFS.Name = "radioButtonFilmsFS";
            this.radioButtonFilmsFS.Size = new System.Drawing.Size(116, 29);
            this.radioButtonFilmsFS.TabIndex = 2;
            this.radioButtonFilmsFS.TabStop = true;
            this.radioButtonFilmsFS.Text = "Фильмы";
            this.radioButtonFilmsFS.UseVisualStyleBackColor = true;
            this.radioButtonFilmsFS.CheckedChanged += new System.EventHandler(this.radioButtonFilmsFS_CheckedChanged);
            // 
            // radioButtonPrizes
            // 
            this.radioButtonPrizes.AutoSize = true;
            this.radioButtonPrizes.Location = new System.Drawing.Point(122, 33);
            this.radioButtonPrizes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonPrizes.Name = "radioButtonPrizes";
            this.radioButtonPrizes.Size = new System.Drawing.Size(94, 29);
            this.radioButtonPrizes.TabIndex = 1;
            this.radioButtonPrizes.TabStop = true;
            this.radioButtonPrizes.Text = "Призы";
            this.radioButtonPrizes.UseVisualStyleBackColor = true;
            this.radioButtonPrizes.CheckedChanged += new System.EventHandler(this.radioButtonPrizes_CheckedChanged);
            // 
            // radioButtonActors
            // 
            this.radioButtonActors.AutoSize = true;
            this.radioButtonActors.Location = new System.Drawing.Point(10, 34);
            this.radioButtonActors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonActors.Name = "radioButtonActors";
            this.radioButtonActors.Size = new System.Drawing.Size(104, 29);
            this.radioButtonActors.TabIndex = 0;
            this.radioButtonActors.TabStop = true;
            this.radioButtonActors.Text = "Актеры";
            this.radioButtonActors.UseVisualStyleBackColor = true;
            this.radioButtonActors.CheckedChanged += new System.EventHandler(this.radioButtonActors_CheckedChanged);
            // 
            // tabPageFullSelect
            // 
            this.tabPageFullSelect.Controls.Add(this.dataGridViewFullSelect);
            this.tabPageFullSelect.Controls.Add(this.groupBoxFullSelect);
            this.tabPageFullSelect.Location = new System.Drawing.Point(4, 34);
            this.tabPageFullSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFullSelect.Name = "tabPageFullSelect";
            this.tabPageFullSelect.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageFullSelect.Size = new System.Drawing.Size(1192, 665);
            this.tabPageFullSelect.TabIndex = 1;
            this.tabPageFullSelect.Text = "Полная запись SELECT";
            this.tabPageFullSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFullSelect
            // 
            this.dataGridViewFullSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFullSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFullSelect.Location = new System.Drawing.Point(4, 269);
            this.dataGridViewFullSelect.Name = "dataGridViewFullSelect";
            this.dataGridViewFullSelect.RowHeadersWidth = 51;
            this.dataGridViewFullSelect.Size = new System.Drawing.Size(1184, 391);
            this.dataGridViewFullSelect.TabIndex = 1;
            // 
            // groupBoxFullSelect
            // 
            this.groupBoxFullSelect.Controls.Add(this.buttonFullSelect);
            this.groupBoxFullSelect.Controls.Add(this.checkBoxOrder);
            this.groupBoxFullSelect.Controls.Add(this.textBoxMore);
            this.groupBoxFullSelect.Controls.Add(this.checkBoxMore);
            this.groupBoxFullSelect.Controls.Add(this.groupBoxDet);
            this.groupBoxFullSelect.Controls.Add(this.textBoxCinema);
            this.groupBoxFullSelect.Controls.Add(this.label1);
            this.groupBoxFullSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxFullSelect.Location = new System.Drawing.Point(4, 5);
            this.groupBoxFullSelect.Name = "groupBoxFullSelect";
            this.groupBoxFullSelect.Size = new System.Drawing.Size(1184, 264);
            this.groupBoxFullSelect.TabIndex = 0;
            this.groupBoxFullSelect.TabStop = false;
            this.groupBoxFullSelect.Text = "Прибыль кинотеатров";
            // 
            // buttonFullSelect
            // 
            this.buttonFullSelect.Location = new System.Drawing.Point(447, 197);
            this.buttonFullSelect.Name = "buttonFullSelect";
            this.buttonFullSelect.Size = new System.Drawing.Size(254, 39);
            this.buttonFullSelect.TabIndex = 6;
            this.buttonFullSelect.Text = "Прибыль кинотеатров";
            this.buttonFullSelect.UseVisualStyleBackColor = true;
            this.buttonFullSelect.Click += new System.EventHandler(this.buttonFullSelect_Click);
            // 
            // checkBoxOrder
            // 
            this.checkBoxOrder.AutoSize = true;
            this.checkBoxOrder.Location = new System.Drawing.Point(7, 113);
            this.checkBoxOrder.Name = "checkBoxOrder";
            this.checkBoxOrder.Size = new System.Drawing.Size(447, 29);
            this.checkBoxOrder.TabIndex = 5;
            this.checkBoxOrder.Text = "Включить сортировку по убыванию прибыли";
            this.checkBoxOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxMore
            // 
            this.textBoxMore.Location = new System.Drawing.Point(274, 75);
            this.textBoxMore.Name = "textBoxMore";
            this.textBoxMore.Size = new System.Drawing.Size(116, 30);
            this.textBoxMore.TabIndex = 4;
            // 
            // checkBoxMore
            // 
            this.checkBoxMore.AutoSize = true;
            this.checkBoxMore.Location = new System.Drawing.Point(8, 77);
            this.checkBoxMore.Name = "checkBoxMore";
            this.checkBoxMore.Size = new System.Drawing.Size(260, 29);
            this.checkBoxMore.TabIndex = 3;
            this.checkBoxMore.Text = "Выбрать прибыль более";
            this.checkBoxMore.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonDet_None);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Genre);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Films);
            this.groupBoxDet.Location = new System.Drawing.Point(602, 29);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(461, 138);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация прибыли кинотеатров";
            // 
            // radioButtonDet_None
            // 
            this.radioButtonDet_None.AutoSize = true;
            this.radioButtonDet_None.Location = new System.Drawing.Point(7, 102);
            this.radioButtonDet_None.Name = "radioButtonDet_None";
            this.radioButtonDet_None.Size = new System.Drawing.Size(273, 29);
            this.radioButtonDet_None.TabIndex = 2;
            this.radioButtonDet_None.TabStop = true;
            this.radioButtonDet_None.Text = "Отсутствие детализации";
            this.radioButtonDet_None.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Genre
            // 
            this.radioButtonDet_Genre.AutoSize = true;
            this.radioButtonDet_Genre.Location = new System.Drawing.Point(7, 66);
            this.radioButtonDet_Genre.Name = "radioButtonDet_Genre";
            this.radioButtonDet_Genre.Size = new System.Drawing.Size(338, 29);
            this.radioButtonDet_Genre.TabIndex = 1;
            this.radioButtonDet_Genre.TabStop = true;
            this.radioButtonDet_Genre.Text = "Прибыль кинотеатра по жанрам";
            this.radioButtonDet_Genre.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Films
            // 
            this.radioButtonDet_Films.AutoSize = true;
            this.radioButtonDet_Films.Location = new System.Drawing.Point(7, 30);
            this.radioButtonDet_Films.Name = "radioButtonDet_Films";
            this.radioButtonDet_Films.Size = new System.Drawing.Size(358, 29);
            this.radioButtonDet_Films.TabIndex = 0;
            this.radioButtonDet_Films.TabStop = true;
            this.radioButtonDet_Films.Text = "Прибыль кинотеатра по фильмам";
            this.radioButtonDet_Films.UseVisualStyleBackColor = true;
            // 
            // textBoxCinema
            // 
            this.textBoxCinema.Location = new System.Drawing.Point(222, 29);
            this.textBoxCinema.Name = "textBoxCinema";
            this.textBoxCinema.Size = new System.Drawing.Size(287, 30);
            this.textBoxCinema.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название кинотеатра";
            // 
            // tabPageSubquery
            // 
            this.tabPageSubquery.Controls.Add(this.dataGridViewSubquery);
            this.tabPageSubquery.Controls.Add(this.groupBoxSubquery);
            this.tabPageSubquery.Location = new System.Drawing.Point(4, 34);
            this.tabPageSubquery.Name = "tabPageSubquery";
            this.tabPageSubquery.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubquery.Size = new System.Drawing.Size(1192, 665);
            this.tabPageSubquery.TabIndex = 2;
            this.tabPageSubquery.Text = "Подзапросы";
            this.tabPageSubquery.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSubquery
            // 
            this.dataGridViewSubquery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubquery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSubquery.Location = new System.Drawing.Point(3, 196);
            this.dataGridViewSubquery.Name = "dataGridViewSubquery";
            this.dataGridViewSubquery.RowHeadersWidth = 51;
            this.dataGridViewSubquery.Size = new System.Drawing.Size(1186, 466);
            this.dataGridViewSubquery.TabIndex = 1;
            // 
            // groupBoxSubquery
            // 
            this.groupBoxSubquery.Controls.Add(this.buttonSubquery);
            this.groupBoxSubquery.Controls.Add(this.textBoxNumber);
            this.groupBoxSubquery.Controls.Add(this.label2);
            this.groupBoxSubquery.Controls.Add(this.radioButtonNoCorrelated);
            this.groupBoxSubquery.Controls.Add(this.radioButtonCorrelated);
            this.groupBoxSubquery.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSubquery.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSubquery.Name = "groupBoxSubquery";
            this.groupBoxSubquery.Size = new System.Drawing.Size(1186, 193);
            this.groupBoxSubquery.TabIndex = 0;
            this.groupBoxSubquery.TabStop = false;
            this.groupBoxSubquery.Text = "Подзапросы по данным";
            // 
            // buttonSubquery
            // 
            this.buttonSubquery.Location = new System.Drawing.Point(478, 142);
            this.buttonSubquery.Name = "buttonSubquery";
            this.buttonSubquery.Size = new System.Drawing.Size(228, 35);
            this.buttonSubquery.TabIndex = 4;
            this.buttonSubquery.Text = "Выполнить подзапрос";
            this.buttonSubquery.UseVisualStyleBackColor = true;
            this.buttonSubquery.Click += new System.EventHandler(this.buttonSubquery_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(125, 86);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 30);
            this.textBoxNumber.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id фильма";
            // 
            // radioButtonNoCorrelated
            // 
            this.radioButtonNoCorrelated.AutoSize = true;
            this.radioButtonNoCorrelated.Location = new System.Drawing.Point(342, 30);
            this.radioButtonNoCorrelated.Name = "radioButtonNoCorrelated";
            this.radioButtonNoCorrelated.Size = new System.Drawing.Size(326, 29);
            this.radioButtonNoCorrelated.TabIndex = 1;
            this.radioButtonNoCorrelated.TabStop = true;
            this.radioButtonNoCorrelated.Text = "Некоррелированный подзапрос";
            this.radioButtonNoCorrelated.UseVisualStyleBackColor = true;
            // 
            // radioButtonCorrelated
            // 
            this.radioButtonCorrelated.AutoSize = true;
            this.radioButtonCorrelated.Location = new System.Drawing.Point(7, 30);
            this.radioButtonCorrelated.Name = "radioButtonCorrelated";
            this.radioButtonCorrelated.Size = new System.Drawing.Size(304, 29);
            this.radioButtonCorrelated.TabIndex = 0;
            this.radioButtonCorrelated.TabStop = true;
            this.radioButtonCorrelated.Text = "Коррелированный подзапрос";
            this.radioButtonCorrelated.UseVisualStyleBackColor = true;
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewSessions);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 34);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(1192, 665);
            this.tabPageDML.TabIndex = 3;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.buttonSelectSessions);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.panelSession);
            this.groupBoxDML.Controls.Add(this.textBoxId_session);
            this.groupBoxDML.Controls.Add(this.labelId_session);
            this.groupBoxDML.Controls.Add(this.radioButtonDelete);
            this.groupBoxDML.Controls.Add(this.radioButtonUpdate);
            this.groupBoxDML.Controls.Add(this.radioButtonInsert);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(1186, 363);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(7, 30);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(292, 29);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Добавить данные по сеансу";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(305, 30);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(434, 29);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить данные по сеансу с заданным Id";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(745, 30);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(416, 29);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить данные по сеансу с заданным Id";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            this.radioButtonDelete.CheckedChanged += new System.EventHandler(this.radioButtonDelete_CheckedChanged);
            // 
            // labelId_session
            // 
            this.labelId_session.AutoSize = true;
            this.labelId_session.Location = new System.Drawing.Point(6, 68);
            this.labelId_session.Name = "labelId_session";
            this.labelId_session.Size = new System.Drawing.Size(95, 25);
            this.labelId_session.TabIndex = 3;
            this.labelId_session.Text = "Id сеанса";
            // 
            // textBoxId_session
            // 
            this.textBoxId_session.Location = new System.Drawing.Point(107, 65);
            this.textBoxId_session.Name = "textBoxId_session";
            this.textBoxId_session.Size = new System.Drawing.Size(156, 30);
            this.textBoxId_session.TabIndex = 4;
            // 
            // panelSession
            // 
            this.panelSession.Controls.Add(this.listBoxSessionFormat);
            this.panelSession.Controls.Add(this.textBoxSessionFreePlacesCount);
            this.panelSession.Controls.Add(this.textBoxSessionCost);
            this.panelSession.Controls.Add(this.textBoxSessionTime);
            this.panelSession.Controls.Add(this.textBoxSessionDate);
            this.panelSession.Controls.Add(this.textBoxSessionFilm);
            this.panelSession.Controls.Add(this.textBoxSessionHall);
            this.panelSession.Controls.Add(this.textBoxSessionCinema);
            this.panelSession.Controls.Add(this.label9);
            this.panelSession.Controls.Add(this.label3);
            this.panelSession.Controls.Add(this.label8);
            this.panelSession.Controls.Add(this.label7);
            this.panelSession.Controls.Add(this.label6);
            this.panelSession.Controls.Add(this.label5);
            this.panelSession.Controls.Add(this.label4);
            this.panelSession.Controls.Add(this.labelCinema);
            this.panelSession.Location = new System.Drawing.Point(7, 105);
            this.panelSession.Name = "panelSession";
            this.panelSession.Size = new System.Drawing.Size(1169, 209);
            this.panelSession.TabIndex = 5;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.Location = new System.Drawing.Point(305, 61);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(205, 38);
            this.buttonExecuteDML.TabIndex = 6;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // labelCinema
            // 
            this.labelCinema.AutoSize = true;
            this.labelCinema.Location = new System.Drawing.Point(18, 12);
            this.labelCinema.Name = "labelCinema";
            this.labelCinema.Size = new System.Drawing.Size(213, 25);
            this.labelCinema.TabIndex = 0;
            this.labelCinema.Text = "Название кинотеатра";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Номер зала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id_фильма";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Дата";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Время";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(567, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Цена билета";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Формат показа";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(567, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Количество свободных мест";
            // 
            // textBoxSessionCinema
            // 
            this.textBoxSessionCinema.Location = new System.Drawing.Point(252, 14);
            this.textBoxSessionCinema.Name = "textBoxSessionCinema";
            this.textBoxSessionCinema.Size = new System.Drawing.Size(274, 30);
            this.textBoxSessionCinema.TabIndex = 8;
            // 
            // textBoxSessionHall
            // 
            this.textBoxSessionHall.Location = new System.Drawing.Point(252, 53);
            this.textBoxSessionHall.Name = "textBoxSessionHall";
            this.textBoxSessionHall.Size = new System.Drawing.Size(145, 30);
            this.textBoxSessionHall.TabIndex = 9;
            // 
            // textBoxSessionFilm
            // 
            this.textBoxSessionFilm.Location = new System.Drawing.Point(252, 90);
            this.textBoxSessionFilm.Name = "textBoxSessionFilm";
            this.textBoxSessionFilm.Size = new System.Drawing.Size(145, 30);
            this.textBoxSessionFilm.TabIndex = 10;
            // 
            // textBoxSessionDate
            // 
            this.textBoxSessionDate.Location = new System.Drawing.Point(252, 130);
            this.textBoxSessionDate.Name = "textBoxSessionDate";
            this.textBoxSessionDate.Size = new System.Drawing.Size(145, 30);
            this.textBoxSessionDate.TabIndex = 11;
            // 
            // textBoxSessionTime
            // 
            this.textBoxSessionTime.Location = new System.Drawing.Point(252, 166);
            this.textBoxSessionTime.Name = "textBoxSessionTime";
            this.textBoxSessionTime.Size = new System.Drawing.Size(145, 30);
            this.textBoxSessionTime.TabIndex = 12;
            // 
            // textBoxSessionCost
            // 
            this.textBoxSessionCost.Location = new System.Drawing.Point(733, 12);
            this.textBoxSessionCost.Name = "textBoxSessionCost";
            this.textBoxSessionCost.Size = new System.Drawing.Size(100, 30);
            this.textBoxSessionCost.TabIndex = 13;
            // 
            // textBoxSessionFreePlacesCount
            // 
            this.textBoxSessionFreePlacesCount.Location = new System.Drawing.Point(856, 135);
            this.textBoxSessionFreePlacesCount.Name = "textBoxSessionFreePlacesCount";
            this.textBoxSessionFreePlacesCount.Size = new System.Drawing.Size(100, 30);
            this.textBoxSessionFreePlacesCount.TabIndex = 14;
            // 
            // listBoxSessionFormat
            // 
            this.listBoxSessionFormat.FormattingEnabled = true;
            this.listBoxSessionFormat.ItemHeight = 25;
            this.listBoxSessionFormat.Items.AddRange(new object[] {
            "2D",
            "3D",
            "IMAX 3D"});
            this.listBoxSessionFormat.Location = new System.Drawing.Point(733, 50);
            this.listBoxSessionFormat.Name = "listBoxSessionFormat";
            this.listBoxSessionFormat.Size = new System.Drawing.Size(120, 79);
            this.listBoxSessionFormat.TabIndex = 15;
            // 
            // dataGridViewSessions
            // 
            this.dataGridViewSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSessions.Location = new System.Drawing.Point(3, 366);
            this.dataGridViewSessions.Name = "dataGridViewSessions";
            this.dataGridViewSessions.RowHeadersWidth = 51;
            this.dataGridViewSessions.RowTemplate.Height = 24;
            this.dataGridViewSessions.Size = new System.Drawing.Size(1186, 296);
            this.dataGridViewSessions.TabIndex = 1;
            // 
            // buttonSelectSessions
            // 
            this.buttonSelectSessions.Location = new System.Drawing.Point(443, 320);
            this.buttonSelectSessions.Name = "buttonSelectSessions";
            this.buttonSelectSessions.Size = new System.Drawing.Size(296, 37);
            this.buttonSelectSessions.TabIndex = 7;
            this.buttonSelectSessions.Text = "Показать список сеансов";
            this.buttonSelectSessions.UseVisualStyleBackColor = true;
            this.buttonSelectSessions.Click += new System.EventHandler(this.buttonSelectSessions_Click);
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tabControlSQL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageFullSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFullSelect)).EndInit();
            this.groupBoxFullSelect.ResumeLayout(false);
            this.groupBoxFullSelect.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageSubquery.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubquery)).EndInit();
            this.groupBoxSubquery.ResumeLayout(false);
            this.groupBoxSubquery.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.panelSession.ResumeLayout(false);
            this.panelSession.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSessions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabPage tabPageFullSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonPrizes;
        private System.Windows.Forms.RadioButton radioButtonActors;
        private System.Windows.Forms.DataGridView dataGridViewFullSelect;
        private System.Windows.Forms.GroupBox groupBoxFullSelect;
        private System.Windows.Forms.TextBox textBoxCinema;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonFilmsFS;
        private System.Windows.Forms.Button buttonFullSelect;
        private System.Windows.Forms.CheckBox checkBoxOrder;
        private System.Windows.Forms.TextBox textBoxMore;
        private System.Windows.Forms.CheckBox checkBoxMore;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonDet_None;
        private System.Windows.Forms.RadioButton radioButtonDet_Genre;
        private System.Windows.Forms.RadioButton radioButtonDet_Films;
        private System.Windows.Forms.TabPage tabPageSubquery;
        private System.Windows.Forms.DataGridView dataGridViewSubquery;
        private System.Windows.Forms.GroupBox groupBoxSubquery;
        private System.Windows.Forms.Button buttonSubquery;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonNoCorrelated;
        private System.Windows.Forms.RadioButton radioButtonCorrelated;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.Panel panelSession;
        private System.Windows.Forms.TextBox textBoxId_session;
        private System.Windows.Forms.Label labelId_session;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelCinema;
        private System.Windows.Forms.ListBox listBoxSessionFormat;
        private System.Windows.Forms.TextBox textBoxSessionFreePlacesCount;
        private System.Windows.Forms.TextBox textBoxSessionCost;
        private System.Windows.Forms.TextBox textBoxSessionTime;
        private System.Windows.Forms.TextBox textBoxSessionDate;
        private System.Windows.Forms.TextBox textBoxSessionFilm;
        private System.Windows.Forms.TextBox textBoxSessionHall;
        private System.Windows.Forms.TextBox textBoxSessionCinema;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewSessions;
        private System.Windows.Forms.Button buttonSelectSessions;
    }
}