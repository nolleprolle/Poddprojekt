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
            txtUrlInput = new TextBox();
            lblUrlInput = new Label();
            btnGetInfo = new Button();
            dgvEpisodes = new DataGridView();
            rtxtEpisodeInfo = new RichTextBox();
            btnSave = new Button();
            txtPoddName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).BeginInit();
            SuspendLayout();
            // 
            // txtUrlInput
            // 
            txtUrlInput.Location = new Point(54, 85);
            txtUrlInput.Name = "txtUrlInput";
            txtUrlInput.Size = new Size(231, 31);
            txtUrlInput.TabIndex = 0;
            // 
            // lblUrlInput
            // 
            lblUrlInput.AutoSize = true;
            lblUrlInput.Location = new Point(54, 57);
            lblUrlInput.Name = "lblUrlInput";
            lblUrlInput.Size = new Size(233, 25);
            lblUrlInput.TabIndex = 1;
            lblUrlInput.Text = "Ange källans URL (RSS-länk)";
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(56, 122);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(112, 34);
            btnGetInfo.TabIndex = 2;
            btnGetInfo.Text = "Hämta";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += btnGetInfo_Click;
            // 
            // dgvEpisodes
            // 
            dgvEpisodes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEpisodes.Location = new Point(54, 188);
            dgvEpisodes.Name = "dgvEpisodes";
            dgvEpisodes.RowHeadersWidth = 62;
            dgvEpisodes.Size = new Size(557, 440);
            dgvEpisodes.TabIndex = 3;
            // 
            // rtxtEpisodeInfo
            // 
            rtxtEpisodeInfo.Location = new Point(627, 188);
            rtxtEpisodeInfo.Name = "rtxtEpisodeInfo";
            rtxtEpisodeInfo.Size = new Size(557, 440);
            rtxtEpisodeInfo.TabIndex = 6;
            rtxtEpisodeInfo.Text = "";
            rtxtEpisodeInfo.TextChanged += richTextBox1_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(54, 634);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(272, 34);
            btnSave.TabIndex = 7;
            btnSave.Text = "Spara ner flödet till ditt register.";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_click;
            // 
            // txtPoddName
            // 
            txtPoddName.AccessibleName = "Vänligen ";
            txtPoddName.Location = new Point(627, 637);
            txtPoddName.Name = "txtPoddName";
            txtPoddName.Size = new Size(200, 31);
            txtPoddName.TabIndex = 8;
            txtPoddName.TextChanged += txtPoddName_TextChanged;
            // 
            // FirstWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 671);
            Controls.Add(txtPoddName);
            Controls.Add(btnSave);
            Controls.Add(rtxtEpisodeInfo);
            Controls.Add(dgvEpisodes);
            Controls.Add(btnGetInfo);
            Controls.Add(lblUrlInput);
            Controls.Add(txtUrlInput);
            Name = "FirstWindow";
            Text = "FirstWindow";
            ((System.ComponentModel.ISupportInitialize)dgvEpisodes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrlInput;
        private Label lblUrlInput;
        private Button btnGetInfo;
        private DataGridView dgvEpisodes;
        private RichTextBox rtxtEpisodeInfo;
        private Button btnSave;
        private TextBox txtPoddName;
    }
}