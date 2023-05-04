
namespace Clue
{
    partial class Gameplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gameplay));
            this.dgvNotebook = new System.Windows.Forms.DataGridView();
            this.lblNotebookHeader = new System.Windows.Forms.Label();
            this.btnRoll = new System.Windows.Forms.Button();
            this.txtSuspect = new System.Windows.Forms.TextBox();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.lblSuspect = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblWeapon = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnAccuse = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNotebook
            // 
            this.dgvNotebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotebook.Location = new System.Drawing.Point(51, 96);
            this.dgvNotebook.Name = "dgvNotebook";
            this.dgvNotebook.RowHeadersWidth = 62;
            this.dgvNotebook.RowTemplate.Height = 28;
            this.dgvNotebook.Size = new System.Drawing.Size(592, 611);
            this.dgvNotebook.TabIndex = 0;
            // 
            // lblNotebookHeader
            // 
            this.lblNotebookHeader.AutoSize = true;
            this.lblNotebookHeader.Font = new System.Drawing.Font("Lucida Sans Typewriter", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotebookHeader.Location = new System.Drawing.Point(168, 38);
            this.lblNotebookHeader.Name = "lblNotebookHeader";
            this.lblNotebookHeader.Size = new System.Drawing.Size(359, 37);
            this.lblNotebookHeader.TabIndex = 1;
            this.lblNotebookHeader.Text = "Detective Notebook";
            // 
            // btnRoll
            // 
            this.btnRoll.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoll.Location = new System.Drawing.Point(1011, 756);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(132, 57);
            this.btnRoll.TabIndex = 2;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // txtSuspect
            // 
            this.txtSuspect.Location = new System.Drawing.Point(108, 715);
            this.txtSuspect.Name = "txtSuspect";
            this.txtSuspect.Size = new System.Drawing.Size(211, 26);
            this.txtSuspect.TabIndex = 3;
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(108, 774);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(211, 26);
            this.txtRoom.TabIndex = 4;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Location = new System.Drawing.Point(432, 741);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(211, 26);
            this.txtWeapon.TabIndex = 5;
            // 
            // lblSuspect
            // 
            this.lblSuspect.AutoSize = true;
            this.lblSuspect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuspect.Location = new System.Drawing.Point(12, 714);
            this.lblSuspect.Name = "lblSuspect";
            this.lblSuspect.Size = new System.Drawing.Size(90, 25);
            this.lblSuspect.TabIndex = 6;
            this.lblSuspect.Text = "Suspect:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(24, 775);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(69, 25);
            this.lblRoom.TabIndex = 7;
            this.lblRoom.Text = "Room:";
            // 
            // lblWeapon
            // 
            this.lblWeapon.AutoSize = true;
            this.lblWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeapon.Location = new System.Drawing.Point(333, 742);
            this.lblWeapon.Name = "lblWeapon";
            this.lblWeapon.Size = new System.Drawing.Size(93, 25);
            this.lblWeapon.TabIndex = 8;
            this.lblWeapon.Text = "Weapon:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(580, 779);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 34);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Submit Final Suspect";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnAccuse
            // 
            this.btnAccuse.Font = new System.Drawing.Font("Maiandra GD", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccuse.Location = new System.Drawing.Point(409, 779);
            this.btnAccuse.Name = "btnAccuse";
            this.btnAccuse.Size = new System.Drawing.Size(145, 34);
            this.btnAccuse.TabIndex = 10;
            this.btnAccuse.Text = "Accuse";
            this.btnAccuse.UseVisualStyleBackColor = true;
            this.btnAccuse.Click += new System.EventHandler(this.btnAccuse_Click);
            // 
            // btnStats
            // 
            this.btnStats.Font = new System.Drawing.Font("Maiandra GD", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStats.Location = new System.Drawing.Point(591, 38);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(97, 37);
            this.btnStats.TabIndex = 11;
            this.btnStats.Text = "Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(678, 611);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 825);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnAccuse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblWeapon);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblSuspect);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtSuspect);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.lblNotebookHeader);
            this.Controls.Add(this.dgvNotebook);
            this.Name = "Gameplay";
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.Gameplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNotebook;
        private System.Windows.Forms.Label lblNotebookHeader;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.TextBox txtSuspect;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.Label lblSuspect;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblWeapon;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnAccuse;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}