
namespace PharmacyProject
{
    partial class frm5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHastaRecete = new System.Windows.Forms.DataGridView();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.btnSalesEdit = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.dgvReceteUrun = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaRecete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(631, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "REÇETE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 91);
            this.panel1.TabIndex = 18;
            // 
            // dgvHastaRecete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvHastaRecete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHastaRecete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastaRecete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHastaRecete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHastaRecete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHastaRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastaRecete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHastaRecete.EnableHeadersVisualStyles = false;
            this.dgvHastaRecete.Location = new System.Drawing.Point(24, 125);
            this.dgvHastaRecete.Name = "dgvHastaRecete";
            this.dgvHastaRecete.RowHeadersWidth = 51;
            this.dgvHastaRecete.RowTemplate.Height = 24;
            this.dgvHastaRecete.Size = new System.Drawing.Size(1369, 266);
            this.dgvHastaRecete.TabIndex = 19;
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.btnSalesCancel.FlatAppearance.BorderSize = 0;
            this.btnSalesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesCancel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesCancel.ForeColor = System.Drawing.Color.White;
            this.btnSalesCancel.Location = new System.Drawing.Point(1269, 736);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(124, 50);
            this.btnSalesCancel.TabIndex = 22;
            this.btnSalesCancel.Text = "SİL";
            this.btnSalesCancel.UseVisualStyleBackColor = false;
            // 
            // btnSalesEdit
            // 
            this.btnSalesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesEdit.FlatAppearance.BorderSize = 0;
            this.btnSalesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesEdit.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalesEdit.Location = new System.Drawing.Point(205, 736);
            this.btnSalesEdit.Name = "btnSalesEdit";
            this.btnSalesEdit.Size = new System.Drawing.Size(124, 50);
            this.btnSalesEdit.TabIndex = 21;
            this.btnSalesEdit.Text = "DÜZENLE";
            this.btnSalesEdit.UseVisualStyleBackColor = false;
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesSave.FlatAppearance.BorderSize = 0;
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesSave.ForeColor = System.Drawing.Color.White;
            this.btnSalesSave.Location = new System.Drawing.Point(45, 736);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(124, 50);
            this.btnSalesSave.TabIndex = 20;
            this.btnSalesSave.Text = "EKLE";
            this.btnSalesSave.UseVisualStyleBackColor = false;
            // 
            // dgvReceteUrun
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvReceteUrun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceteUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceteUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceteUrun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceteUrun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceteUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceteUrun.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceteUrun.EnableHeadersVisualStyles = false;
            this.dgvReceteUrun.Location = new System.Drawing.Point(24, 423);
            this.dgvReceteUrun.Name = "dgvReceteUrun";
            this.dgvReceteUrun.RowHeadersWidth = 51;
            this.dgvReceteUrun.RowTemplate.Height = 24;
            this.dgvReceteUrun.Size = new System.Drawing.Size(1369, 266);
            this.dgvReceteUrun.TabIndex = 23;
            // 
            // frm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 811);
            this.Controls.Add(this.dgvReceteUrun);
            this.Controls.Add(this.btnSalesCancel);
            this.Controls.Add(this.btnSalesEdit);
            this.Controls.Add(this.btnSalesSave);
            this.Controls.Add(this.dgvHastaRecete);
            this.Controls.Add(this.panel1);
            this.Name = "frm5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REÇETE";
            this.Load += new System.EventHandler(this.frm5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaRecete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteUrun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHastaRecete;
        private System.Windows.Forms.Button btnSalesCancel;
        private System.Windows.Forms.Button btnSalesEdit;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.DataGridView dgvReceteUrun;
    }
}