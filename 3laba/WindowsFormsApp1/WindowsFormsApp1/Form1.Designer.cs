namespace WindowsFormsApp1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PreDrawTimer = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multilineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillColorView = new System.Windows.Forms.Button();
            this.clearPaintButton = new System.Windows.Forms.Button();
            this.penColorButton = new System.Windows.Forms.Button();
            this.fillColorButton = new System.Windows.Forms.Button();
            this.numberOfTopsLabel = new System.Windows.Forms.Label();
            this.penColorView = new System.Windows.Forms.Button();
            this.thicknessLabel = new System.Windows.Forms.Label();
            this.numberOfTopsUpDown = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thicknessUpDown = new System.Windows.Forms.NumericUpDown();
            this.instrumentalPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numberOfTopsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.thicknessUpDown)).BeginInit();
            this.instrumentalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreDrawTimer
            // 
            this.PreDrawTimer.Interval = 10;
            this.PreDrawTimer.Tick += new System.EventHandler(this.PreDrawTimer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem1, this.shapeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1328, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItem2, this.toolStripMenuItem3, this.toolStripMenuItem4, this.toolStripMenuItem5, this.toolStripMenuItem6});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 24);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem2.Text = "Открыть";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem3.Text = "Сохранить";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem4.Text = "Сохранить как";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem5.Text = "Отменить";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(230, 24);
            this.toolStripMenuItem6.Text = "Вернуть";
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.lineToolStripMenuItem, this.multilineToolStripMenuItem, this.rectangleToolStripMenuItem, this.polygonToolStripMenuItem, this.ellipseToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.shapeToolStripMenuItem.Text = "Фигура";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.lineToolStripMenuItem.Text = "Линия";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // multilineToolStripMenuItem
            // 
            this.multilineToolStripMenuItem.Name = "multilineToolStripMenuItem";
            this.multilineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.multilineToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.multilineToolStripMenuItem.Text = "Ломанная";
            this.multilineToolStripMenuItem.Click += new System.EventHandler(this.multilineToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.rectangleToolStripMenuItem.Text = "Прямоугольник";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.polygonToolStripMenuItem.Text = "Многоугольник";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.polygonToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys) ((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(236, 24);
            this.ellipseToolStripMenuItem.Text = "Эллипс";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // fillColorView
            // 
            this.fillColorView.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fillColorView.Location = new System.Drawing.Point(832, 9);
            this.fillColorView.Margin = new System.Windows.Forms.Padding(4);
            this.fillColorView.Name = "fillColorView";
            this.fillColorView.Size = new System.Drawing.Size(52, 24);
            this.fillColorView.TabIndex = 15;
            this.fillColorView.UseVisualStyleBackColor = true;
            this.fillColorView.Click += new System.EventHandler(this.fillColorView_Click);
            // 
            // clearPaintButton
            // 
            this.clearPaintButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearPaintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.clearPaintButton.Location = new System.Drawing.Point(1104, 6);
            this.clearPaintButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearPaintButton.Name = "clearPaintButton";
            this.clearPaintButton.Size = new System.Drawing.Size(220, 27);
            this.clearPaintButton.TabIndex = 18;
            this.clearPaintButton.Text = "Очистить поле";
            this.clearPaintButton.UseVisualStyleBackColor = true;
            this.clearPaintButton.Click += new System.EventHandler(this.clearPaintButton_Click);
            // 
            // penColorButton
            // 
            this.penColorButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penColorButton.Location = new System.Drawing.Point(436, 9);
            this.penColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.penColorButton.Name = "penColorButton";
            this.penColorButton.Size = new System.Drawing.Size(160, 24);
            this.penColorButton.TabIndex = 21;
            this.penColorButton.Text = "Цвет линии";
            this.penColorButton.UseVisualStyleBackColor = true;
            this.penColorButton.Click += new System.EventHandler(this.penColorButton_Click);
            // 
            // fillColorButton
            // 
            this.fillColorButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fillColorButton.Location = new System.Drawing.Point(664, 9);
            this.fillColorButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillColorButton.Name = "fillColorButton";
            this.fillColorButton.Size = new System.Drawing.Size(160, 24);
            this.fillColorButton.TabIndex = 22;
            this.fillColorButton.Text = "Цвет заливки";
            this.fillColorButton.UseVisualStyleBackColor = true;
            this.fillColorButton.Click += new System.EventHandler(this.fillColorButton_Click);
            // 
            // numberOfTopsLabel
            // 
            this.numberOfTopsLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberOfTopsLabel.Location = new System.Drawing.Point(220, 13);
            this.numberOfTopsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfTopsLabel.Name = "numberOfTopsLabel";
            this.numberOfTopsLabel.Size = new System.Drawing.Size(148, 21);
            this.numberOfTopsLabel.TabIndex = 23;
            this.numberOfTopsLabel.Text = "Количество вершин";
            this.numberOfTopsLabel.Visible = false;
            // 
            // penColorView
            // 
            this.penColorView.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.penColorView.BackColor = System.Drawing.Color.Black;
            this.penColorView.Location = new System.Drawing.Point(604, 9);
            this.penColorView.Margin = new System.Windows.Forms.Padding(4);
            this.penColorView.Name = "penColorView";
            this.penColorView.Size = new System.Drawing.Size(52, 24);
            this.penColorView.TabIndex = 25;
            this.penColorView.UseVisualStyleBackColor = false;
            this.penColorView.Click += new System.EventHandler(this.penColorView_Click);
            // 
            // thicknessLabel
            // 
            this.thicknessLabel.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thicknessLabel.Location = new System.Drawing.Point(4, 13);
            this.thicknessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.thicknessLabel.Name = "thicknessLabel";
            this.thicknessLabel.Size = new System.Drawing.Size(148, 21);
            this.thicknessLabel.TabIndex = 27;
            this.thicknessLabel.Text = "Толщина линии";
            // 
            // numberOfTopsUpDown
            // 
            this.numberOfTopsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numberOfTopsUpDown.Location = new System.Drawing.Point(376, 11);
            this.numberOfTopsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.numberOfTopsUpDown.Maximum = new decimal(new int[] {18, 0, 0, 0});
            this.numberOfTopsUpDown.Minimum = new decimal(new int[] {3, 0, 0, 0});
            this.numberOfTopsUpDown.Name = "numberOfTopsUpDown";
            this.numberOfTopsUpDown.Size = new System.Drawing.Size(52, 22);
            this.numberOfTopsUpDown.TabIndex = 28;
            this.numberOfTopsUpDown.Value = new decimal(new int[] {3, 0, 0, 0});
            this.numberOfTopsUpDown.Visible = false;
            this.numberOfTopsUpDown.ValueChanged += new System.EventHandler(this.numberOfTopsUpDown_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1328, 671);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // thicknessUpDown
            // 
            this.thicknessUpDown.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thicknessUpDown.Location = new System.Drawing.Point(160, 11);
            this.thicknessUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.thicknessUpDown.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.thicknessUpDown.Name = "thicknessUpDown";
            this.thicknessUpDown.Size = new System.Drawing.Size(52, 22);
            this.thicknessUpDown.TabIndex = 30;
            this.thicknessUpDown.Value = new decimal(new int[] {1, 0, 0, 0});
            this.thicknessUpDown.ValueChanged += new System.EventHandler(this.thicknessUpDown_ValueChanged);
            // 
            // instrumentalPanel
            // 
            this.instrumentalPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.instrumentalPanel.Controls.Add(this.thicknessLabel);
            this.instrumentalPanel.Controls.Add(this.thicknessUpDown);
            this.instrumentalPanel.Controls.Add(this.clearPaintButton);
            this.instrumentalPanel.Controls.Add(this.fillColorButton);
            this.instrumentalPanel.Controls.Add(this.penColorView);
            this.instrumentalPanel.Controls.Add(this.fillColorView);
            this.instrumentalPanel.Controls.Add(this.numberOfTopsLabel);
            this.instrumentalPanel.Controls.Add(this.numberOfTopsUpDown);
            this.instrumentalPanel.Controls.Add(this.penColorButton);
            this.instrumentalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.instrumentalPanel.Location = new System.Drawing.Point(0, 28);
            this.instrumentalPanel.Name = "instrumentalPanel";
            this.instrumentalPanel.Size = new System.Drawing.Size(1328, 37);
            this.instrumentalPanel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 699);
            this.Controls.Add(this.instrumentalPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numberOfTopsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.thicknessUpDown)).EndInit();
            this.instrumentalPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel instrumentalPanel;

        #endregion
        private System.Windows.Forms.Timer PreDrawTimer;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multilineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
        private System.Windows.Forms.Button fillColorView;
        private System.Windows.Forms.Button clearPaintButton;
        private System.Windows.Forms.Button penColorButton;
        private System.Windows.Forms.Button fillColorButton;
        private System.Windows.Forms.Label numberOfTopsLabel;
        private System.Windows.Forms.Button penColorView;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Label thicknessLabel;
        private System.Windows.Forms.NumericUpDown numberOfTopsUpDown;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown thicknessUpDown;
    }
}

