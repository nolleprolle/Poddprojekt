namespace PresentationLayer
{
    partial class FirstWindow
    {
   
        private System.ComponentModel.IContainer components = null;


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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtPoddName = new TextBox();
            btnSave = new Button();
            rtxtEpisodeInfo = new RichTextBox();
            dgvEpisodes = new DataGridView();
            btnGetInfo = new Button();
            lblUrlInput = new Label();
            txtUrlInput = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1370, 636);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtPoddName);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(rtxtEpisodeInfo);
            tabPage1.Controls.Add(dgvEpisodes);
            tabPage1.Controls.Add(btnGetInfo);
            tabPage1.Controls.Add(lblUrlInput);
            tabPage1.Controls.Add(txtUrlInput);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 603);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(242, 92);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.Location = new Point(499, 512);
            txtPoddName.Margin = new Padding(2);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(161, 27);
            txtPoddName.TabIndex = 15;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(40, 509);
            btnSave.Margin = new Padding(2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(218, 27);
            btnSave.TabIndex = 14;
            btnSave.Text = "Spara ner flödet till ditt register.";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rtxtEpisodeInfo
            // 
            rtxtEpisodeInfo.Location = new Point(499, 152);
            rtxtEpisodeInfo.Margin = new Padding(2);
            rtxtEpisodeInfo.Name = "rtxtEpisodeInfo";
            rtxtEpisodeInfo.Size = new Size(446, 353);
            rtxtEpisodeInfo.TabIndex = 13;
            rtxtEpisodeInfo.Text = "";
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Location = new Point(40, 152);
            dgvEpisodes.Margin = new Padding(2);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(446, 352);
            dgvEpisodes.TabIndex = 12;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(42, 100);
            btnGetInfo.Margin = new Padding(2);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(90, 27);
            btnGetInfo.TabIndex = 11;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = true;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(40, 48);
            lblUrlInput.Margin = new Padding(2, 0, 2, 0);
            lblUrlInput.Name = "lblUrlInput";
            lblUrlInput.Size = new Size(195, 20);
            lblUrlInput.TabIndex = 10;
            lblUrlInput.Text = "Ange källans URL (RSS-länk)";
            // 
            // txtUrlInput
            // 
            txtUrlInput.Location = new Point(40, 70);
            txtUrlInput.Margin = new Padding(2);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(186, 27);
            txtUrlInput.TabIndex = 9;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1451, 733);
            Controls.Add(tabControl1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FirstWindow";
            Text = "FirstWindow";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPoddName;
        private Button btnSave;
        private RichTextBox rtxtEpisodeInfo;
        private DataGridView dgvEpisodes;
        private Button btnGetInfo;
        private Label lblUrlInput;
        private TextBox txtUrlInput;
    }
}