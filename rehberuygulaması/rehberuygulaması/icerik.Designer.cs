namespace rehberuygulaması
{
    partial class icerik
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.veriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(639, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veriEklemeToolStripMenuItem,
            this.veriSilmeToolStripMenuItem,
            this.veriDüzenlemeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 108);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(535, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // veriEklemeToolStripMenuItem
            // 
            this.veriEklemeToolStripMenuItem.Image = global::rehberuygulaması.Properties.Resources.if_administrator_add_67244__1_;
            this.veriEklemeToolStripMenuItem.Name = "veriEklemeToolStripMenuItem";
            this.veriEklemeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.veriEklemeToolStripMenuItem.Text = "Veri Ekleme";
            // 
            // veriSilmeToolStripMenuItem
            // 
            this.veriSilmeToolStripMenuItem.Image = global::rehberuygulaması.Properties.Resources.if_administrator_delete_67245;
            this.veriSilmeToolStripMenuItem.Name = "veriSilmeToolStripMenuItem";
            this.veriSilmeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.veriSilmeToolStripMenuItem.Text = "Veri Silme";
            // 
            // veriDüzenlemeToolStripMenuItem
            // 
            this.veriDüzenlemeToolStripMenuItem.Image = global::rehberuygulaması.Properties.Resources.if_administrator_help_67246;
            this.veriDüzenlemeToolStripMenuItem.Name = "veriDüzenlemeToolStripMenuItem";
            this.veriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.veriDüzenlemeToolStripMenuItem.Text = "Veri Düzenleme";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Image = global::rehberuygulaması.Properties.Resources.png_transparent_exit_sign_exit_sign_orange_circle_stock_photography;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::rehberuygulaması.Properties.Resources.depositphotos_287872354_stock_illustration_search_icon_magnifying_glass_icon;
            this.pictureBox1.Location = new System.Drawing.Point(641, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::rehberuygulaması.Properties.Resources.if_administrator_help_67246;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(535, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 187);
            this.button3.TabIndex = 3;
            this.toolTip1.SetToolTip(this.button3, "Düzenleme İşlemi");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::rehberuygulaması.Properties.Resources.if_administrator_delete_67245;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(316, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 187);
            this.button2.TabIndex = 2;
            this.toolTip1.SetToolTip(this.button2, "Silme İşlemi");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::rehberuygulaması.Properties.Resources.if_administrator_add_67244__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(83, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 187);
            this.button1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.button1, "Kayıt İşlemi");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // icerik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "icerik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber Uygulamam";
            this.Load += new System.EventHandler(this.icerik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}