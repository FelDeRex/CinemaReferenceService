namespace CinemaReferenceService
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинотеатрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.залыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.актерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.призыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.кинотеатрыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.залыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фильмыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.актерыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.призыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сеансыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(800, 43);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(88, 39);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.exit;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(345, 40);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.info;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(345, 40);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кинотеатрыToolStripMenuItem,
            this.залыToolStripMenuItem,
            this.фильмыToolStripMenuItem,
            this.актерыToolStripMenuItem,
            this.призыToolStripMenuItem,
            this.сеансыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(184, 39);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // кинотеатрыToolStripMenuItem
            // 
            this.кинотеатрыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.cinema;
            this.кинотеатрыToolStripMenuItem.Name = "кинотеатрыToolStripMenuItem";
            this.кинотеатрыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.кинотеатрыToolStripMenuItem.Text = "Кинотеатры";
            this.кинотеатрыToolStripMenuItem.Click += new System.EventHandler(this.кинотеатрыToolStripMenuItem_Click);
            // 
            // залыToolStripMenuItem
            // 
            this.залыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.hall;
            this.залыToolStripMenuItem.Name = "залыToolStripMenuItem";
            this.залыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.залыToolStripMenuItem.Text = "Залы";
            this.залыToolStripMenuItem.Click += new System.EventHandler(this.залыToolStripMenuItem_Click);
            // 
            // фильмыToolStripMenuItem
            // 
            this.фильмыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.film;
            this.фильмыToolStripMenuItem.Name = "фильмыToolStripMenuItem";
            this.фильмыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.фильмыToolStripMenuItem.Text = "Фильмы";
            this.фильмыToolStripMenuItem.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // актерыToolStripMenuItem
            // 
            this.актерыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.actors;
            this.актерыToolStripMenuItem.Name = "актерыToolStripMenuItem";
            this.актерыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.актерыToolStripMenuItem.Text = "Актеры";
            this.актерыToolStripMenuItem.Click += new System.EventHandler(this.актерыToolStripMenuItem_Click);
            // 
            // призыToolStripMenuItem
            // 
            this.призыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.prize;
            this.призыToolStripMenuItem.Name = "призыToolStripMenuItem";
            this.призыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.призыToolStripMenuItem.Text = "Призы";
            this.призыToolStripMenuItem.Click += new System.EventHandler(this.призыToolStripMenuItem_Click);
            // 
            // сеансыToolStripMenuItem
            // 
            this.сеансыToolStripMenuItem.Image = global::CinemaReferenceService.Properties.Resources.seanses;
            this.сеансыToolStripMenuItem.Name = "сеансыToolStripMenuItem";
            this.сеансыToolStripMenuItem.Size = new System.Drawing.Size(242, 40);
            this.сеансыToolStripMenuItem.Text = "Сеансы";
            this.сеансыToolStripMenuItem.Click += new System.EventHandler(this.сеансыToolStripMenuItem_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справочникиToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(246, 84);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(245, 40);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.exit;
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(345, 40);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.info;
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(345, 40);
            this.оПрограммеToolStripMenuItem1.Text = "О программе...";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem1
            // 
            this.справочникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кинотеатрыToolStripMenuItem1,
            this.залыToolStripMenuItem1,
            this.фильмыToolStripMenuItem1,
            this.актерыToolStripMenuItem1,
            this.призыToolStripMenuItem1,
            this.сеансыToolStripMenuItem1});
            this.справочникиToolStripMenuItem1.Name = "справочникиToolStripMenuItem1";
            this.справочникиToolStripMenuItem1.Size = new System.Drawing.Size(245, 40);
            this.справочникиToolStripMenuItem1.Text = "Справочники";
            // 
            // кинотеатрыToolStripMenuItem1
            // 
            this.кинотеатрыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.cinema;
            this.кинотеатрыToolStripMenuItem1.Name = "кинотеатрыToolStripMenuItem1";
            this.кинотеатрыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.кинотеатрыToolStripMenuItem1.Text = "Кинотеатры";
            this.кинотеатрыToolStripMenuItem1.Click += new System.EventHandler(this.кинотеатрыToolStripMenuItem_Click);
            // 
            // залыToolStripMenuItem1
            // 
            this.залыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.hall;
            this.залыToolStripMenuItem1.Name = "залыToolStripMenuItem1";
            this.залыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.залыToolStripMenuItem1.Text = "Залы";
            this.залыToolStripMenuItem1.Click += new System.EventHandler(this.залыToolStripMenuItem_Click);
            // 
            // фильмыToolStripMenuItem1
            // 
            this.фильмыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.film;
            this.фильмыToolStripMenuItem1.Name = "фильмыToolStripMenuItem1";
            this.фильмыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.фильмыToolStripMenuItem1.Text = "Фильмы";
            this.фильмыToolStripMenuItem1.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // актерыToolStripMenuItem1
            // 
            this.актерыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.actors;
            this.актерыToolStripMenuItem1.Name = "актерыToolStripMenuItem1";
            this.актерыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.актерыToolStripMenuItem1.Text = "Актеры";
            this.актерыToolStripMenuItem1.Click += new System.EventHandler(this.актерыToolStripMenuItem_Click);
            // 
            // призыToolStripMenuItem1
            // 
            this.призыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.prize;
            this.призыToolStripMenuItem1.Name = "призыToolStripMenuItem1";
            this.призыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.призыToolStripMenuItem1.Text = "Призы";
            this.призыToolStripMenuItem1.Click += new System.EventHandler(this.призыToolStripMenuItem_Click);
            // 
            // сеансыToolStripMenuItem1
            // 
            this.сеансыToolStripMenuItem1.Image = global::CinemaReferenceService.Properties.Resources.seanses;
            this.сеансыToolStripMenuItem1.Name = "сеансыToolStripMenuItem1";
            this.сеансыToolStripMenuItem1.Size = new System.Drawing.Size(242, 40);
            this.сеансыToolStripMenuItem1.Text = "Сеансы";
            this.сеансыToolStripMenuItem1.Click += new System.EventHandler(this.сеансыToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CinemaReferenceService.Properties.Resources.exit;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton1.Text = "Закрыть программу";
            this.toolStripButton1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::CinemaReferenceService.Properties.Resources.info;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton2.Text = "О программе";
            this.toolStripButton2.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::CinemaReferenceService.Properties.Resources.cinema;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton3.Text = "Справочник по кинотеатрам";
            this.toolStripButton3.Click += new System.EventHandler(this.кинотеатрыToolStripMenuItem_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::CinemaReferenceService.Properties.Resources.hall;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton4.Text = "Справочник по залам";
            this.toolStripButton4.Click += new System.EventHandler(this.залыToolStripMenuItem_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::CinemaReferenceService.Properties.Resources.film;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton5.Text = "Справочник по фильмам";
            this.toolStripButton5.Click += new System.EventHandler(this.фильмыToolStripMenuItem_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::CinemaReferenceService.Properties.Resources.actors;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton7.Text = "Справочник по актерам";
            this.toolStripButton7.Click += new System.EventHandler(this.актерыToolStripMenuItem_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::CinemaReferenceService.Properties.Resources.prize;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 39);
            this.toolStripButton8.Text = "Справочник по призам";
            this.toolStripButton8.Click += new System.EventHandler(this.призыToolStripMenuItem_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(120, 39);
            this.toolStripButton9.Text = "Запросы";
            this.toolStripButton9.Click += new System.EventHandler(this.запросыToolStripMenuItem_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 23);
            this.toolStripButton6.Text = "Справочник по актерам";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::CinemaReferenceService.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::CinemaReferenceService.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник по кинотеатрам";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинотеатрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem залыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem кинотеатрыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem залыToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem призыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem актерыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильмыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem актерыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem призыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сеансыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
    }
}

