namespace Aquarium2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРыбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рыбуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.улиткуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.включитьАквариумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1255, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.включитьАквариумToolStripMenuItem,
            this.добавитьРыбуToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // добавитьРыбуToolStripMenuItem
            // 
            this.добавитьРыбуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рыбуToolStripMenuItem,
            this.улиткуToolStripMenuItem});
            this.добавитьРыбуToolStripMenuItem.Name = "добавитьРыбуToolStripMenuItem";
            this.добавитьРыбуToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.добавитьРыбуToolStripMenuItem.Text = "Добавить";
            // 
            // рыбуToolStripMenuItem
            // 
            this.рыбуToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("рыбуToolStripMenuItem.Image")));
            this.рыбуToolStripMenuItem.Name = "рыбуToolStripMenuItem";
            this.рыбуToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.рыбуToolStripMenuItem.Text = "Рыбу";
            this.рыбуToolStripMenuItem.Click += new System.EventHandler(this.рыбуToolStripMenuItem_Click);
            // 
            // улиткуToolStripMenuItem
            // 
            this.улиткуToolStripMenuItem.Name = "улиткуToolStripMenuItem";
            this.улиткуToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.улиткуToolStripMenuItem.Text = "Улитку";
            // 
            // включитьАквариумToolStripMenuItem
            // 
            this.включитьАквариумToolStripMenuItem.Name = "включитьАквариумToolStripMenuItem";
            this.включитьАквариумToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.включитьАквариумToolStripMenuItem.Text = "Включить аквариум";
            this.включитьАквариумToolStripMenuItem.Click += new System.EventHandler(this.включитьАквариумToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 591);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.Form1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРыбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рыбуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem улиткуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem включитьАквариумToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

