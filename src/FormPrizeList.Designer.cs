namespace CinemaReferenceService
{
    partial class FormPrizeList
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
            System.Windows.Forms.Label id_призаLabel;
            System.Windows.Forms.Label название_премииLabel;
            System.Windows.Forms.Label категория_номинацииLabel;
            System.Windows.Forms.Label дата_присужденияLabel;
            System.Windows.Forms.Label id_фильмаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrizeList));
            System.Windows.Forms.Label название_фильмаLabel;
            this.призыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.призыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_призаTextBox = new System.Windows.Forms.TextBox();
            this.название_премииTextBox = new System.Windows.Forms.TextBox();
            this.категория_номинацииTextBox = new System.Windows.Forms.TextBox();
            this.дата_присужденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_фильмаTextBox = new System.Windows.Forms.TextBox();
            this.filmsButton = new System.Windows.Forms.Button();
            this.название_фильмаLabel1 = new System.Windows.Forms.Label();
            this.призыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cinemaDataSet = new CinemaReferenceService.CinemaDataSet();
            this.фильмыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.призыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ПризыTableAdapter();
            this.tableAdapterManager = new CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager();
            this.фильмыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ФильмыTableAdapter();
            id_призаLabel = new System.Windows.Forms.Label();
            название_премииLabel = new System.Windows.Forms.Label();
            категория_номинацииLabel = new System.Windows.Forms.Label();
            дата_присужденияLabel = new System.Windows.Forms.Label();
            id_фильмаLabel = new System.Windows.Forms.Label();
            название_фильмаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingNavigator)).BeginInit();
            this.призыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_призаLabel
            // 
            id_призаLabel.AutoSize = true;
            id_призаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_призаLabel.Location = new System.Drawing.Point(16, 63);
            id_призаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_призаLabel.Name = "id_призаLabel";
            id_призаLabel.Size = new System.Drawing.Size(93, 25);
            id_призаLabel.TabIndex = 1;
            id_призаLabel.Text = "Id приза:";
            // 
            // название_премииLabel
            // 
            название_премииLabel.AutoSize = true;
            название_премииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_премииLabel.Location = new System.Drawing.Point(16, 102);
            название_премииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            название_премииLabel.Name = "название_премииLabel";
            название_премииLabel.Size = new System.Drawing.Size(182, 25);
            название_премииLabel.TabIndex = 3;
            название_премииLabel.Text = "Название премии:";
            // 
            // категория_номинацииLabel
            // 
            категория_номинацииLabel.AutoSize = true;
            категория_номинацииLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            категория_номинацииLabel.Location = new System.Drawing.Point(16, 142);
            категория_номинацииLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            категория_номинацииLabel.Name = "категория_номинацииLabel";
            категория_номинацииLabel.Size = new System.Drawing.Size(225, 25);
            категория_номинацииLabel.TabIndex = 5;
            категория_номинацииLabel.Text = "Категория номинации:";
            // 
            // дата_присужденияLabel
            // 
            дата_присужденияLabel.AutoSize = true;
            дата_присужденияLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_присужденияLabel.Location = new System.Drawing.Point(16, 182);
            дата_присужденияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_присужденияLabel.Name = "дата_присужденияLabel";
            дата_присужденияLabel.Size = new System.Drawing.Size(197, 25);
            дата_присужденияLabel.TabIndex = 7;
            дата_присужденияLabel.Text = "Дата присуждения:";
            // 
            // id_фильмаLabel
            // 
            id_фильмаLabel.AutoSize = true;
            id_фильмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            id_фильмаLabel.Location = new System.Drawing.Point(16, 220);
            id_фильмаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_фильмаLabel.Name = "id_фильмаLabel";
            id_фильмаLabel.Size = new System.Drawing.Size(118, 25);
            id_фильмаLabel.TabIndex = 9;
            id_фильмаLabel.Text = "Id фильма:";
            // 
            // призыBindingNavigator
            // 
            this.призыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.призыBindingNavigator.BindingSource = this.призыBindingSource;
            this.призыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.призыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.призыBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.призыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.призыBindingNavigatorSaveItem});
            this.призыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.призыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.призыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.призыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.призыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.призыBindingNavigator.Name = "призыBindingNavigator";
            this.призыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.призыBindingNavigator.Size = new System.Drawing.Size(843, 39);
            this.призыBindingNavigator.TabIndex = 0;
            this.призыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(91, 36);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 36);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // призыBindingNavigatorSaveItem
            // 
            this.призыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.призыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("призыBindingNavigatorSaveItem.Image")));
            this.призыBindingNavigatorSaveItem.Name = "призыBindingNavigatorSaveItem";
            this.призыBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 36);
            this.призыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.призыBindingNavigatorSaveItem.Click += new System.EventHandler(this.призыBindingNavigatorSaveItem_Click);
            // 
            // id_призаTextBox
            // 
            this.id_призаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.призыBindingSource, "Id_приза", true));
            this.id_призаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_призаTextBox.Location = new System.Drawing.Point(264, 63);
            this.id_призаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_призаTextBox.Name = "id_призаTextBox";
            this.id_призаTextBox.Size = new System.Drawing.Size(120, 30);
            this.id_призаTextBox.TabIndex = 2;
            // 
            // название_премииTextBox
            // 
            this.название_премииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.призыBindingSource, "Название_премии", true));
            this.название_премииTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_премииTextBox.Location = new System.Drawing.Point(264, 102);
            this.название_премииTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.название_премииTextBox.Name = "название_премииTextBox";
            this.название_премииTextBox.Size = new System.Drawing.Size(309, 30);
            this.название_премииTextBox.TabIndex = 4;
            // 
            // категория_номинацииTextBox
            // 
            this.категория_номинацииTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.призыBindingSource, "Категория_номинации", true));
            this.категория_номинацииTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.категория_номинацииTextBox.Location = new System.Drawing.Point(264, 142);
            this.категория_номинацииTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.категория_номинацииTextBox.Name = "категория_номинацииTextBox";
            this.категория_номинацииTextBox.Size = new System.Drawing.Size(543, 30);
            this.категория_номинацииTextBox.TabIndex = 6;
            // 
            // дата_присужденияDateTimePicker
            // 
            this.дата_присужденияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.призыBindingSource, "Дата_присуждения", true));
            this.дата_присужденияDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_присужденияDateTimePicker.Location = new System.Drawing.Point(264, 181);
            this.дата_присужденияDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.дата_присужденияDateTimePicker.Name = "дата_присужденияDateTimePicker";
            this.дата_присужденияDateTimePicker.Size = new System.Drawing.Size(265, 30);
            this.дата_присужденияDateTimePicker.TabIndex = 8;
            // 
            // id_фильмаTextBox
            // 
            this.id_фильмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.призыBindingSource, "Id_фильма", true));
            this.id_фильмаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id_фильмаTextBox.Location = new System.Drawing.Point(264, 220);
            this.id_фильмаTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_фильмаTextBox.Name = "id_фильмаTextBox";
            this.id_фильмаTextBox.Size = new System.Drawing.Size(120, 30);
            this.id_фильмаTextBox.TabIndex = 10;
            // 
            // filmsButton
            // 
            this.filmsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filmsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filmsButton.Location = new System.Drawing.Point(412, 217);
            this.filmsButton.Name = "filmsButton";
            this.filmsButton.Size = new System.Drawing.Size(117, 36);
            this.filmsButton.TabIndex = 11;
            this.filmsButton.Text = "Фильмы";
            this.filmsButton.UseVisualStyleBackColor = true;
            this.filmsButton.Click += new System.EventHandler(this.filmButton_Click);
            // 
            // название_фильмаLabel
            // 
            название_фильмаLabel.AutoSize = true;
            название_фильмаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_фильмаLabel.Location = new System.Drawing.Point(16, 266);
            название_фильмаLabel.Name = "название_фильмаLabel";
            название_фильмаLabel.Size = new System.Drawing.Size(189, 25);
            название_фильмаLabel.TabIndex = 14;
            название_фильмаLabel.Text = "Название фильма:";
            // 
            // название_фильмаLabel1
            // 
            this.название_фильмаLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.призыBindingSource, "Название_фильма", true));
            this.название_фильмаLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_фильмаLabel1.Location = new System.Drawing.Point(259, 268);
            this.название_фильмаLabel1.Name = "название_фильмаLabel1";
            this.название_фильмаLabel1.Size = new System.Drawing.Size(350, 23);
            this.название_фильмаLabel1.TabIndex = 15;
            this.название_фильмаLabel1.Text = "label1";
            // 
            // призыBindingSource
            // 
            this.призыBindingSource.DataMember = "Призы";
            this.призыBindingSource.DataSource = this.cinemaDataSet;
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
            // призыTableAdapter
            // 
            this.призыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.ЗалыTableAdapter = null;
            this.tableAdapterManager.КинотеатрыTableAdapter = null;
            this.tableAdapterManager.ПризыTableAdapter = this.призыTableAdapter;
            this.tableAdapterManager.РолиTableAdapter = null;
            this.tableAdapterManager.СеансыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // фильмыTableAdapter
            // 
            this.фильмыTableAdapter.ClearBeforeFill = true;
            // 
            // FormPrizeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 317);
            this.Controls.Add(название_фильмаLabel);
            this.Controls.Add(this.название_фильмаLabel1);
            this.Controls.Add(this.filmsButton);
            this.Controls.Add(id_призаLabel);
            this.Controls.Add(this.id_призаTextBox);
            this.Controls.Add(название_премииLabel);
            this.Controls.Add(this.название_премииTextBox);
            this.Controls.Add(категория_номинацииLabel);
            this.Controls.Add(this.категория_номинацииTextBox);
            this.Controls.Add(дата_присужденияLabel);
            this.Controls.Add(this.дата_присужденияDateTimePicker);
            this.Controls.Add(id_фильмаLabel);
            this.Controls.Add(this.id_фильмаTextBox);
            this.Controls.Add(this.призыBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPrizeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Призы";
            this.Load += new System.EventHandler(this.FormPrizeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingNavigator)).EndInit();
            this.призыBindingNavigator.ResumeLayout(false);
            this.призыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.призыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.фильмыBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource призыBindingSource;
        private CinemaDataSetTableAdapters.ПризыTableAdapter призыTableAdapter;
        private CinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator призыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton призыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_призаTextBox;
        private System.Windows.Forms.TextBox название_премииTextBox;
        private System.Windows.Forms.TextBox категория_номинацииTextBox;
        private System.Windows.Forms.DateTimePicker дата_присужденияDateTimePicker;
        private System.Windows.Forms.TextBox id_фильмаTextBox;
        private System.Windows.Forms.Button filmsButton;
        private System.Windows.Forms.BindingSource фильмыBindingSource;
        private CinemaDataSetTableAdapters.ФильмыTableAdapter фильмыTableAdapter;
        private System.Windows.Forms.Label название_фильмаLabel1;
    }
}