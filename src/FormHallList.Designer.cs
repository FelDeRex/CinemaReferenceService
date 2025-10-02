namespace CinemaReferenceService
{
    partial class FormHallList
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
            System.Windows.Forms.Label номер_залаLabel;
            System.Windows.Forms.Label название_кинотеатраLabel;
            System.Windows.Forms.Label вместимостьLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHallList));
            this.cinemaDataSet = new CinemaReferenceService.CinemaDataSet();
            this.залыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.залыTableAdapter = new CinemaReferenceService.CinemaDataSetTableAdapters.ЗалыTableAdapter();
            this.tableAdapterManager = new CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager();
            this.залыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.залыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.номер_залаTextBox = new System.Windows.Forms.TextBox();
            this.название_кинотеатраTextBox = new System.Windows.Forms.TextBox();
            this.вместимостьTextBox = new System.Windows.Forms.TextBox();
            номер_залаLabel = new System.Windows.Forms.Label();
            название_кинотеатраLabel = new System.Windows.Forms.Label();
            вместимостьLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingNavigator)).BeginInit();
            this.залыBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // номер_залаLabel
            // 
            номер_залаLabel.AutoSize = true;
            номер_залаLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            номер_залаLabel.Location = new System.Drawing.Point(12, 46);
            номер_залаLabel.Name = "номер_залаLabel";
            номер_залаLabel.Size = new System.Drawing.Size(103, 20);
            номер_залаLabel.TabIndex = 1;
            номер_залаLabel.Text = "Номер зала:";
            // 
            // название_кинотеатраLabel
            // 
            название_кинотеатраLabel.AutoSize = true;
            название_кинотеатраLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            название_кинотеатраLabel.Location = new System.Drawing.Point(11, 75);
            название_кинотеатраLabel.Name = "название_кинотеатраLabel";
            название_кинотеатраLabel.Size = new System.Drawing.Size(180, 20);
            название_кинотеатраLabel.TabIndex = 3;
            название_кинотеатраLabel.Text = "Название кинотеатра:";
            // 
            // вместимостьLabel
            // 
            вместимостьLabel.AutoSize = true;
            вместимостьLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            вместимостьLabel.Location = new System.Drawing.Point(12, 104);
            вместимостьLabel.Name = "вместимостьLabel";
            вместимостьLabel.Size = new System.Drawing.Size(116, 20);
            вместимостьLabel.TabIndex = 5;
            вместимостьLabel.Text = "Вместимость:";
            // 
            // cinemaDataSet
            // 
            this.cinemaDataSet.DataSetName = "CinemaDataSet";
            this.cinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // залыBindingSource
            // 
            this.залыBindingSource.DataMember = "Залы";
            this.залыBindingSource.DataSource = this.cinemaDataSet;
            // 
            // залыTableAdapter
            // 
            this.залыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CinemaReferenceService.CinemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.АктерыTableAdapter = null;
            this.tableAdapterManager.ЗалыTableAdapter = this.залыTableAdapter;
            this.tableAdapterManager.КинотеатрыTableAdapter = null;
            this.tableAdapterManager.ПризыTableAdapter = null;
            this.tableAdapterManager.РолиTableAdapter = null;
            this.tableAdapterManager.СеансыTableAdapter = null;
            this.tableAdapterManager.ФильмыTableAdapter = null;
            // 
            // залыBindingNavigator
            // 
            this.залыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.залыBindingNavigator.BindingSource = this.залыBindingSource;
            this.залыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.залыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.залыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.залыBindingNavigatorSaveItem});
            this.залыBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.залыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.залыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.залыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.залыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.залыBindingNavigator.Name = "залыBindingNavigator";
            this.залыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.залыBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.залыBindingNavigator.TabIndex = 0;
            this.залыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(69, 30);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 33);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 30);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // залыBindingNavigatorSaveItem
            // 
            this.залыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.залыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("залыBindingNavigatorSaveItem.Image")));
            this.залыBindingNavigatorSaveItem.Name = "залыBindingNavigatorSaveItem";
            this.залыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 30);
            this.залыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.залыBindingNavigatorSaveItem.Click += new System.EventHandler(this.залыBindingNavigatorSaveItem_Click);
            // 
            // номер_залаTextBox
            // 
            this.номер_залаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залыBindingSource, "Номер_зала", true));
            this.номер_залаTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.номер_залаTextBox.Location = new System.Drawing.Point(197, 40);
            this.номер_залаTextBox.Name = "номер_залаTextBox";
            this.номер_залаTextBox.Size = new System.Drawing.Size(100, 26);
            this.номер_залаTextBox.TabIndex = 2;
            // 
            // название_кинотеатраTextBox
            // 
            this.название_кинотеатраTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залыBindingSource, "Название_кинотеатра", true));
            this.название_кинотеатраTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.название_кинотеатраTextBox.Location = new System.Drawing.Point(197, 69);
            this.название_кинотеатраTextBox.Name = "название_кинотеатраTextBox";
            this.название_кинотеатраTextBox.Size = new System.Drawing.Size(273, 26);
            this.название_кинотеатраTextBox.TabIndex = 4;
            // 
            // вместимостьTextBox
            // 
            this.вместимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.залыBindingSource, "Вместимость", true));
            this.вместимостьTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.вместимостьTextBox.Location = new System.Drawing.Point(197, 101);
            this.вместимостьTextBox.Name = "вместимостьTextBox";
            this.вместимостьTextBox.Size = new System.Drawing.Size(100, 26);
            this.вместимостьTextBox.TabIndex = 6;
            // 
            // FormHallList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 149);
            this.Controls.Add(номер_залаLabel);
            this.Controls.Add(this.номер_залаTextBox);
            this.Controls.Add(название_кинотеатраLabel);
            this.Controls.Add(this.название_кинотеатраTextBox);
            this.Controls.Add(вместимостьLabel);
            this.Controls.Add(this.вместимостьTextBox);
            this.Controls.Add(this.залыBindingNavigator);
            this.Name = "FormHallList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Залы";
            this.Load += new System.EventHandler(this.FormHallList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cinemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.залыBindingNavigator)).EndInit();
            this.залыBindingNavigator.ResumeLayout(false);
            this.залыBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CinemaDataSet cinemaDataSet;
        private System.Windows.Forms.BindingSource залыBindingSource;
        private CinemaDataSetTableAdapters.ЗалыTableAdapter залыTableAdapter;
        private CinemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator залыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton залыBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox номер_залаTextBox;
        private System.Windows.Forms.TextBox название_кинотеатраTextBox;
        private System.Windows.Forms.TextBox вместимостьTextBox;
    }
}