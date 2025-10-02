namespace CinemaReferenceService
{
    partial class FormFilmList
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
            System.Windows.Forms.Label id_фильмаLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label фИО_режиссераLabel;
            System.Windows.Forms.Label фИО_оператораLabel;
            System.Windows.Forms.Label производствоLabel;
            System.Windows.Forms.Label премьераLabel;
            System.Windows.Forms.Label жанрLabel;
            System.Windows.Forms.Label продолжительностьLabel;
            System.Windows.Forms.Label возрастной_рейтингLabel;
            System.Windows.Forms.Label кадр_из_фильмаLabel;
            System.Windows.Forms.Label прокатная_стоимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilmList));
            this.cinemaDataSet = new CinemaReferenceService.CinemaDataSet();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.фильмыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ФильмыTableAdapter();
            this.tableAdapterManager = new CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager();
            this.фильмыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.фильмыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonOK = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBoxFind = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.id_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.фИО_режиссераTextBox = new System.Windows.Forms.TextBox();
            this.фИО_оператораTextBox = new System.Windows.Forms.TextBox();
            this.производствоTextBox = new System.Windows.Forms.TextBox();
            this.премьераDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.жанрTextBox = new System.Windows.Forms.TextBox();
            this.продолжительностьTextBox = new System.Windows.Forms.TextBox();
            this.возрастной_рейтингComboBox = new System.Windows.Forms.ComboBox();
            this.прокатная_стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.buttonOpenPicture = new System.Windows.Forms.Button();
            this.openFileDialogPicture = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxCast = new System.Windows.Forms.GroupBox();
            this.ролиbindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ролиBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCast = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActors = new System.Windows.Forms.ToolStripButton();
            this.ролиDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ролиTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.РолиTableAdapter();
            this.groupBoxPrizes = new System.Windows.Forms.GroupBox();
            this.призыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.призыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrize = new System.Windows.Forms.ToolStripButton();
            this.призыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.призыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ПризыTableAdapter();
            this.кадр_из_фильмаPictureBox = new System.Windows.Forms.PictureBox();
            id_фильмаLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            фИО_режиссераLabel = new System.Windows.Forms.Label();
            фИО_оператораLabel = new System.Windows.Forms.Label();
            производствоLabel = new System.Windows.Forms.Label();
            премьераLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            продолжительностьLabel = new System.Windows.Forms.Label();
            возрастной_рейтингLabel = new System.Windows.Forms.Label();
            кадр_из_фильмаLabel = new System.Windows.Forms.Label();
            прокатная_стоимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingNavigator)).BeginInit();
            this.фильмыBindingNavigator.SuspendLayout();
            this.groupBoxCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиbindingNavigator)).BeginInit();
            this.ролиbindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиDataGridView)).BeginInit();
            this.groupBoxPrizes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingNavigator)).BeginInit();
            this.призыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.призыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.кадр_из_фильмаPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // id_фильмаLabel
            // 
            id_фильмаLabel.AutoSize = true;
            id_фильмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_фильмаLabel.Location = new System.Drawing.Point(45, 66);
            id_фильмаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_фильмаLabel.Name = "id_фильмаLabel";
            id_фильмаLabel.Size = new System.Drawing.Size(137, 29);
            id_фильмаLabel.TabIndex = 1;
            id_фильмаLabel.Text = "Id фильма:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            названиеLabel.Location = new System.Drawing.Point(43, 107);
            названиеLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(132, 29);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // фИО_режиссераLabel
            // 
            фИО_режиссераLabel.AutoSize = true;
            фИО_режиссераLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИО_режиссераLabel.Location = new System.Drawing.Point(43, 150);
            фИО_режиссераLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИО_режиссераLabel.Name = "фИО_режиссераLabel";
            фИО_режиссераLabel.Size = new System.Drawing.Size(208, 29);
            фИО_режиссераLabel.TabIndex = 5;
            фИО_режиссераLabel.Text = "ФИО режиссера:";
            // 
            // фИО_оператораLabel
            // 
            фИО_оператораLabel.AutoSize = true;
            фИО_оператораLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИО_оператораLabel.Location = new System.Drawing.Point(47, 193);
            фИО_оператораLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИО_оператораLabel.Name = "фИО_оператораLabel";
            фИО_оператораLabel.Size = new System.Drawing.Size(205, 29);
            фИО_оператораLabel.TabIndex = 7;
            фИО_оператораLabel.Text = "ФИО оператора:";
            // 
            // производствоLabel
            // 
            производствоLabel.AutoSize = true;
            производствоLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            производствоLabel.Location = new System.Drawing.Point(47, 236);
            производствоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            производствоLabel.Name = "производствоLabel";
            производствоLabel.Size = new System.Drawing.Size(184, 29);
            производствоLabel.TabIndex = 9;
            производствоLabel.Text = "Производство:";
            // 
            // премьераLabel
            // 
            премьераLabel.AutoSize = true;
            премьераLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            премьераLabel.Location = new System.Drawing.Point(47, 282);
            премьераLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            премьераLabel.Name = "премьераLabel";
            премьераLabel.Size = new System.Drawing.Size(136, 29);
            премьераLabel.TabIndex = 11;
            премьераLabel.Text = "Премьера:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            жанрLabel.Location = new System.Drawing.Point(47, 322);
            жанрLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(82, 29);
            жанрLabel.TabIndex = 13;
            жанрLabel.Text = "Жанр:";
            // 
            // продолжительностьLabel
            // 
            продолжительностьLabel.AutoSize = true;
            продолжительностьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            продолжительностьLabel.Location = new System.Drawing.Point(47, 366);
            продолжительностьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            продолжительностьLabel.Name = "продолжительностьLabel";
            продолжительностьLabel.Size = new System.Drawing.Size(260, 29);
            продолжительностьLabel.TabIndex = 15;
            продолжительностьLabel.Text = "Продолжительность:";
            // 
            // возрастной_рейтингLabel
            // 
            возрастной_рейтингLabel.AutoSize = true;
            возрастной_рейтингLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            возрастной_рейтингLabel.Location = new System.Drawing.Point(45, 409);
            возрастной_рейтингLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            возрастной_рейтингLabel.Name = "возрастной_рейтингLabel";
            возрастной_рейтингLabel.Size = new System.Drawing.Size(259, 29);
            возрастной_рейтингLabel.TabIndex = 17;
            возрастной_рейтингLabel.Text = "Возрастной рейтинг:";
            // 
            // кадр_из_фильмаLabel
            // 
            кадр_из_фильмаLabel.AutoSize = true;
            кадр_из_фильмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кадр_из_фильмаLabel.Location = new System.Drawing.Point(944, 66);
            кадр_из_фильмаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            кадр_из_фильмаLabel.Name = "кадр_из_фильмаLabel";
            кадр_из_фильмаLabel.Size = new System.Drawing.Size(208, 29);
            кадр_из_фильмаLabel.TabIndex = 19;
            кадр_из_фильмаLabel.Text = "Кадр из фильма:";
            // 
            // прокатная_стоимостьLabel
            // 
            прокатная_стоимостьLabel.AutoSize = true;
            прокатная_стоимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            прокатная_стоимостьLabel.Location = new System.Drawing.Point(47, 455);
            прокатная_стоимостьLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            прокатная_стоимостьLabel.Name = "прокатная_стоимостьLabel";
            прокатная_стоимостьLabel.Size = new System.Drawing.Size(271, 29);
            прокатная_стоимостьLabel.TabIndex = 21;
            прокатная_стоимостьLabel.Text = "Прокатная стоимость:";
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // фильмыBindingSource
            // 
            this.фильмыBindingSource.DataMember = "Фильмы";
            this.фильмыBindingSource.DataSource = this.cinemaDataSet;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.ЗалыTableAdapter = null;
            this.tableAdapterManager.КинотеатрыTableAdapter = null;
            this.tableAdapterManager.ПризыTableAdapter = null;
            this.tableAdapterManager.РолиTableAdapter = null;
            this.tableAdapterManager.СеансыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = this.фильмыTableAdapter;
            // 
            // фильмыBindingNavigator
            // 
            this.фильмыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.фильмыBindingNavigator.BindingSource = this.фильмыBindingSource;
            this.фильмыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.фильмыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.фильмыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.фильмыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.фильмыBindingNavigatorSaveItem,
            this.toolStripButtonOK,
            this.toolStripSeparator7,
            this.toolStripTextBoxFind,
            this.toolStripButtonFind});
            this.фильмыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.фильмыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.фильмыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.фильмыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.фильмыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.фильмыBindingNavigator.Name = "фильмыBindingNavigator";
            this.фильмыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.фильмыBindingNavigator.Size = new System.Drawing.Size(1424, 41);
            this.фильмыBindingNavigator.TabIndex = 0;
            this.фильмыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(83, 38);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 41);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 38);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 41);
            // 
            // фильмыBindingNavigatorSaveItem
            // 
            this.фильмыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.фильмыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("фильмыBindingNavigatorSaveItem.Image")));
            this.фильмыBindingNavigatorSaveItem.Name = "фильмыBindingNavigatorSaveItem";
            this.фильмыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 38);
            this.фильмыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.фильмыBindingNavigatorSaveItem.Click += new System.EventHandler(this.фильмыBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButtonOK
            // 
            this.toolStripButtonOK.Image = global::CinemaReferenceService.Properties.Resources.choose;
            this.toolStripButtonOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOK.Name = "toolStripButtonOK";
            this.toolStripButtonOK.Size = new System.Drawing.Size(127, 38);
            this.toolStripButtonOK.Text = "Выбрать";
            this.toolStripButtonOK.Visible = false;
            this.toolStripButtonOK.Click += new System.EventHandler(this.toolStripButtonOK_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 41);
            // 
            // toolStripTextBoxFind
            // 
            this.toolStripTextBoxFind.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.toolStripTextBoxFind.Name = "toolStripTextBoxFind";
            this.toolStripTextBoxFind.Size = new System.Drawing.Size(250, 41);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.Image = global::CinemaReferenceService.Properties.Resources.search;
            this.toolStripButtonFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(102, 38);
            this.toolStripButtonFind.Text = "Поиск";
            this.toolStripButtonFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // id_фильмаTextBox
            // 
            this.id_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Id_фильма", true));
            this.id_фильмаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_фильмаTextBox.Location = new System.Drawing.Point(344, 60);
            this.id_фильмаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_фильмаTextBox.Name = "id_фильмаTextBox";
            this.id_фильмаTextBox.Size = new System.Drawing.Size(145, 34);
            this.id_фильмаTextBox.TabIndex = 2;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Название", true));
            this.названиеTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.названиеTextBox.Location = new System.Drawing.Point(344, 103);
            this.названиеTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(408, 34);
            this.названиеTextBox.TabIndex = 4;
            // 
            // фИО_режиссераTextBox
            // 
            this.фИО_режиссераTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "ФИО_режиссера", true));
            this.фИО_режиссераTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИО_режиссераTextBox.Location = new System.Drawing.Point(344, 146);
            this.фИО_режиссераTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фИО_режиссераTextBox.Name = "фИО_режиссераTextBox";
            this.фИО_режиссераTextBox.Size = new System.Drawing.Size(559, 34);
            this.фИО_режиссераTextBox.TabIndex = 6;
            // 
            // фИО_оператораTextBox
            // 
            this.фИО_оператораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "ФИО_оператора", true));
            this.фИО_оператораTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИО_оператораTextBox.Location = new System.Drawing.Point(344, 190);
            this.фИО_оператораTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фИО_оператораTextBox.Name = "фИО_оператораTextBox";
            this.фИО_оператораTextBox.Size = new System.Drawing.Size(559, 34);
            this.фИО_оператораTextBox.TabIndex = 8;
            // 
            // производствоTextBox
            // 
            this.производствоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Производство", true));
            this.производствоTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.производствоTextBox.Location = new System.Drawing.Point(344, 233);
            this.производствоTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.производствоTextBox.Name = "производствоTextBox";
            this.производствоTextBox.Size = new System.Drawing.Size(265, 34);
            this.производствоTextBox.TabIndex = 10;
            // 
            // премьераDateTimePicker
            // 
            this.премьераDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.фильмыBindingSource, "Премьера", true));
            this.премьераDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.премьераDateTimePicker.Location = new System.Drawing.Point(344, 276);
            this.премьераDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.премьераDateTimePicker.Name = "премьераDateTimePicker";
            this.премьераDateTimePicker.Size = new System.Drawing.Size(265, 34);
            this.премьераDateTimePicker.TabIndex = 12;
            // 
            // жанрTextBox
            // 
            this.жанрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Жанр", true));
            this.жанрTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.жанрTextBox.Location = new System.Drawing.Point(344, 319);
            this.жанрTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.жанрTextBox.Name = "жанрTextBox";
            this.жанрTextBox.Size = new System.Drawing.Size(265, 34);
            this.жанрTextBox.TabIndex = 14;
            // 
            // продолжительностьTextBox
            // 
            this.продолжительностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Продолжительность", true));
            this.продолжительностьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.продолжительностьTextBox.Location = new System.Drawing.Point(344, 362);
            this.продолжительностьTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.продолжительностьTextBox.Name = "продолжительностьTextBox";
            this.продолжительностьTextBox.Size = new System.Drawing.Size(145, 34);
            this.продолжительностьTextBox.TabIndex = 16;
            // 
            // возрастной_рейтингComboBox
            // 
            this.возрастной_рейтингComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Возрастной_рейтинг", true));
            this.возрастной_рейтингComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.возрастной_рейтингComboBox.FormattingEnabled = true;
            this.возрастной_рейтингComboBox.Items.AddRange(new object[] {
            "0+",
            "6+",
            "12+",
            "16+",
            "18+"});
            this.возрастной_рейтингComboBox.Location = new System.Drawing.Point(344, 405);
            this.возрастной_рейтингComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.возрастной_рейтингComboBox.Name = "возрастной_рейтингComboBox";
            this.возрастной_рейтингComboBox.Size = new System.Drawing.Size(112, 37);
            this.возрастной_рейтингComboBox.TabIndex = 18;
            // 
            // прокатная_стоимостьTextBox
            // 
            this.прокатная_стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.фильмыBindingSource, "Прокатная_стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.прокатная_стоимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.прокатная_стоимостьTextBox.Location = new System.Drawing.Point(344, 452);
            this.прокатная_стоимостьTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.прокатная_стоимостьTextBox.Name = "прокатная_стоимостьTextBox";
            this.прокатная_стоимостьTextBox.Size = new System.Drawing.Size(145, 34);
            this.прокатная_стоимостьTextBox.TabIndex = 22;
            // 
            // buttonOpenPicture
            // 
            this.buttonOpenPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenPicture.Location = new System.Drawing.Point(1165, 64);
            this.buttonOpenPicture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenPicture.Name = "buttonOpenPicture";
            this.buttonOpenPicture.Size = new System.Drawing.Size(248, 36);
            this.buttonOpenPicture.TabIndex = 23;
            this.buttonOpenPicture.Text = "Открыть картинку";
            this.buttonOpenPicture.UseVisualStyleBackColor = true;
            this.buttonOpenPicture.Click += new System.EventHandler(this.buttonOpenPicture_Click);
            // 
            // openFileDialogPicture
            // 
            this.openFileDialogPicture.FileName = "openFileDialog1";
            // 
            // groupBoxCast
            // 
            this.groupBoxCast.Controls.Add(this.ролиbindingNavigator);
            this.groupBoxCast.Controls.Add(this.ролиDataGridView);
            this.groupBoxCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxCast.Location = new System.Drawing.Point(48, 505);
            this.groupBoxCast.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxCast.Name = "groupBoxCast";
            this.groupBoxCast.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxCast.Size = new System.Drawing.Size(615, 243);
            this.groupBoxCast.TabIndex = 24;
            this.groupBoxCast.TabStop = false;
            this.groupBoxCast.Text = "В ролях";
            // 
            // ролиbindingNavigator
            // 
            this.ролиbindingNavigator.AddNewItem = this.toolStripButton1;
            this.ролиbindingNavigator.BindingSource = this.ролиBindingSource;
            this.ролиbindingNavigator.CountItem = this.toolStripLabel1;
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
            this.toolStripButton7,
            this.toolStripButtonCast,
            this.toolStripButtonActors});
            this.ролиbindingNavigator.Location = new System.Drawing.Point(4, 31);
            this.ролиbindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.ролиbindingNavigator.MoveLastItem = this.toolStripButton6;
            this.ролиbindingNavigator.MoveNextItem = this.toolStripButton5;
            this.ролиbindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.ролиbindingNavigator.Name = "ролиbindingNavigator";
            this.ролиbindingNavigator.PositionItem = this.toolStripTextBox1;
            this.ролиbindingNavigator.Size = new System.Drawing.Size(607, 39);
            this.ролиbindingNavigator.TabIndex = 2;
            this.ролиbindingNavigator.Text = "ролиbindingNavigator";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton1.Text = "Добавить";
            // 
            // ролиBindingSource
            // 
            this.ролиBindingSource.DataMember = "FK_Роли_Фильмы";
            this.ролиBindingSource.DataSource = this.фильмыBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(83, 36);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(65, 39);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton7.Text = "Сохранить данные";
            this.toolStripButton7.Click += new System.EventHandler(this.ролиBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCast
            // 
            this.toolStripButtonCast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCast.Image = global::CinemaReferenceService.Properties.Resources.cast;
            this.toolStripButtonCast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCast.Name = "toolStripButtonCast";
            this.toolStripButtonCast.Size = new System.Drawing.Size(29, 36);
            this.toolStripButtonCast.Text = "Перейти к Роли";
            this.toolStripButtonCast.Click += new System.EventHandler(this.ролиBindingNavigatorOpenRoles_Click);
            // 
            // toolStripButtonActors
            // 
            this.toolStripButtonActors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActors.Image = global::CinemaReferenceService.Properties.Resources.actors;
            this.toolStripButtonActors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActors.Name = "toolStripButtonActors";
            this.toolStripButtonActors.Size = new System.Drawing.Size(29, 36);
            this.toolStripButtonActors.Text = "Перейти к Актеры";
            this.toolStripButtonActors.Click += new System.EventHandler(this.ролиBindingNavigatorOpenActors_Click);
            // 
            // ролиDataGridView
            // 
            this.ролиDataGridView.AutoGenerateColumns = false;
            this.ролиDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ролиDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ролиDataGridView.DataSource = this.ролиBindingSource;
            this.ролиDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ролиDataGridView.Location = new System.Drawing.Point(4, 75);
            this.ролиDataGridView.Name = "ролиDataGridView";
            this.ролиDataGridView.RowHeadersWidth = 51;
            this.ролиDataGridView.RowTemplate.Height = 24;
            this.ролиDataGridView.Size = new System.Drawing.Size(607, 164);
            this.ролиDataGridView.TabIndex = 1;
            this.ролиDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ролиDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_фильма";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_фильма";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО_актера";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО_актера";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // ролиTableAdapter
            // 
            this.ролиTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxPrizes
            // 
            this.groupBoxPrizes.Controls.Add(this.призыBindingNavigator);
            this.groupBoxPrizes.Controls.Add(this.призыDataGridView);
            this.groupBoxPrizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPrizes.Location = new System.Drawing.Point(48, 755);
            this.groupBoxPrizes.Name = "groupBoxPrizes";
            this.groupBoxPrizes.Size = new System.Drawing.Size(1221, 228);
            this.groupBoxPrizes.TabIndex = 25;
            this.groupBoxPrizes.TabStop = false;
            this.groupBoxPrizes.Text = "Призы";
            // 
            // призыBindingNavigator
            // 
            this.призыBindingNavigator.AddNewItem = this.toolStripButton8;
            this.призыBindingNavigator.BindingSource = this.призыBindingSource;
            this.призыBindingNavigator.CountItem = this.toolStripLabel2;
            this.призыBindingNavigator.DeleteItem = this.toolStripButton9;
            this.призыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.призыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton10,
            this.toolStripButton11,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton12,
            this.toolStripButton13,
            this.toolStripSeparator6,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripButton14,
            this.toolStripButtonPrize});
            this.призыBindingNavigator.Location = new System.Drawing.Point(3, 30);
            this.призыBindingNavigator.MoveFirstItem = this.toolStripButton10;
            this.призыBindingNavigator.MoveLastItem = this.toolStripButton13;
            this.призыBindingNavigator.MoveNextItem = this.toolStripButton12;
            this.призыBindingNavigator.MovePreviousItem = this.toolStripButton11;
            this.призыBindingNavigator.Name = "призыBindingNavigator";
            this.призыBindingNavigator.PositionItem = this.toolStripTextBox2;
            this.призыBindingNavigator.Size = new System.Drawing.Size(1215, 39);
            this.призыBindingNavigator.TabIndex = 3;
            this.призыBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton8.Text = "Добавить";
            // 
            // призыBindingSource
            // 
            this.призыBindingSource.DataMember = "FK_Призы_Фильмы";
            this.призыBindingSource.DataSource = this.фильмыBindingSource;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(83, 36);
            this.toolStripLabel2.Text = "для {0}";
            this.toolStripLabel2.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton9.Text = "Удалить";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton10.Text = "Переместить в начало";
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton11.Text = "Переместить назад";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Положение";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(65, 39);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton12.Text = "Переместить вперед";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton13.Text = "Переместить в конец";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(29, 36);
            this.toolStripButton14.Text = "Сохранить данные";
            // 
            // toolStripButtonPrize
            // 
            this.toolStripButtonPrize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrize.Image = global::CinemaReferenceService.Properties.Resources.prize;
            this.toolStripButtonPrize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrize.Name = "toolStripButtonPrize";
            this.toolStripButtonPrize.Size = new System.Drawing.Size(29, 36);
            this.toolStripButtonPrize.Text = "Перейти к Призы";
            this.toolStripButtonPrize.Click += new System.EventHandler(this.призыBindingNavigatorOpenPrizes_Click);
            // 
            // призыDataGridView
            // 
            this.призыDataGridView.AutoGenerateColumns = false;
            this.призыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.призыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.призыDataGridView.DataSource = this.призыBindingSource;
            this.призыDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.призыDataGridView.Location = new System.Drawing.Point(3, 71);
            this.призыDataGridView.Name = "призыDataGridView";
            this.призыDataGridView.RowHeadersWidth = 51;
            this.призыDataGridView.RowTemplate.Height = 24;
            this.призыDataGridView.Size = new System.Drawing.Size(1215, 154);
            this.призыDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Id_приза";
            this.dataGridViewTextBoxColumn3.HeaderText = "Id_приза";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Название_премии";
            this.dataGridViewTextBoxColumn4.HeaderText = "Название_премии";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Категория_номинации";
            this.dataGridViewTextBoxColumn5.HeaderText = "Категория_номинации";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 350;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Дата_присуждения";
            this.dataGridViewTextBoxColumn6.HeaderText = "Дата_присуждения";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id_фильма";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id_фильма";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // призыTableAdapter
            // 
            this.призыTableAdapter.ClearBeforeFill = true;
            // 
            // кадр_из_фильмаPictureBox
            // 
            this.кадр_из_фильмаPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.фильмыBindingSource, "Кадр_из_фильма", true));
            this.кадр_из_фильмаPictureBox.Location = new System.Drawing.Point(949, 107);
            this.кадр_из_фильмаPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.кадр_из_фильмаPictureBox.Name = "кадр_из_фильмаPictureBox";
            this.кадр_из_фильмаPictureBox.Size = new System.Drawing.Size(464, 432);
            this.кадр_из_фильмаPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.кадр_из_фильмаPictureBox.TabIndex = 20;
            this.кадр_из_фильмаPictureBox.TabStop = false;
            // 
            // FormFilmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 989);
            this.Controls.Add(this.groupBoxPrizes);
            this.Controls.Add(this.groupBoxCast);
            this.Controls.Add(this.buttonOpenPicture);
            this.Controls.Add(id_фильмаLabel);
            this.Controls.Add(this.id_фильмаTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(фИО_режиссераLabel);
            this.Controls.Add(this.фИО_режиссераTextBox);
            this.Controls.Add(фИО_оператораLabel);
            this.Controls.Add(this.фИО_оператораTextBox);
            this.Controls.Add(производствоLabel);
            this.Controls.Add(this.производствоTextBox);
            this.Controls.Add(премьераLabel);
            this.Controls.Add(this.премьераDateTimePicker);
            this.Controls.Add(жанрLabel);
            this.Controls.Add(this.жанрTextBox);
            this.Controls.Add(продолжительностьLabel);
            this.Controls.Add(this.продолжительностьTextBox);
            this.Controls.Add(возрастной_рейтингLabel);
            this.Controls.Add(this.возрастной_рейтингComboBox);
            this.Controls.Add(кадр_из_фильмаLabel);
            this.Controls.Add(this.кадр_из_фильмаPictureBox);
            this.Controls.Add(прокатная_стоимостьLabel);
            this.Controls.Add(this.прокатная_стоимостьTextBox);
            this.Controls.Add(this.фильмыBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormFilmList";
            this.Text = "Фильмы";
            this.Load += new System.EventHandler(this.FormFilmList_Load);
            this.Shown += new System.EventHandler(this.FormFilmList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingNavigator)).EndInit();
            this.фильмыBindingNavigator.ResumeLayout(false);
            this.фильмыBindingNavigator.PerformLayout();
            this.groupBoxCast.ResumeLayout(false);
            this.groupBoxCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиbindingNavigator)).EndInit();
            this.ролиbindingNavigator.ResumeLayout(false);
            this.ролиbindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ролиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ролиDataGridView)).EndInit();
            this.groupBoxPrizes.ResumeLayout(false);
            this.groupBoxPrizes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingNavigator)).EndInit();
            this.призыBindingNavigator.ResumeLayout(false);
            this.призыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.призыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.кадр_из_фильмаPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private CinemaDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private CinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator фильмыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton фильмыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_фильмаTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox фИО_режиссераTextBox;
        private System.Windows.Forms.TextBox фИО_оператораTextBox;
        private System.Windows.Forms.TextBox производствоTextBox;
        private System.Windows.Forms.DateTimePicker премьераDateTimePicker;
        private System.Windows.Forms.TextBox жанрTextBox;
        private System.Windows.Forms.TextBox продолжительностьTextBox;
        private System.Windows.Forms.ComboBox возрастной_рейтингComboBox;
        private System.Windows.Forms.PictureBox кадр_из_фильмаPictureBox;
        private System.Windows.Forms.TextBox прокатная_стоимостьTextBox;
        private System.Windows.Forms.Button buttonOpenPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialogPicture;
        private System.Windows.Forms.GroupBox groupBoxCast;
        private System.Windows.Forms.BindingSource ролиBindingSource;
        private CinemaDataSetTableAdapters.РолиTableAdapter ролиTableAdapter;
        private System.Windows.Forms.DataGridView ролиDataGridView;
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
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.GroupBox groupBoxPrizes;
        private System.Windows.Forms.BindingSource призыBindingSource;
        private CinemaDataSetTableAdapters.ПризыTableAdapter призыTableAdapter;
        private System.Windows.Forms.DataGridView призыDataGridView;
        private System.Windows.Forms.BindingNavigator призыBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButtonCast;
        private System.Windows.Forms.ToolStripButton toolStripButtonActors;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton toolStripButtonOK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn2;
    }
}