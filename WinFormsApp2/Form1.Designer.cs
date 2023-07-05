namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvSueldo = new System.Windows.Forms.DataGridView();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.ASR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo_Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(99, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(488, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "resetear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvSueldo
            // 
            this.dgvSueldo.BackgroundColor = System.Drawing.Color.White;
            this.dgvSueldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSueldo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASR,
            this.AFP,
            this.ISR,
            this.Total_Descuento,
            this.Sueldo_Neto});
            this.dgvSueldo.Location = new System.Drawing.Point(12, 63);
            this.dgvSueldo.Name = "dgvSueldo";
            this.dgvSueldo.RowHeadersWidth = 62;
            this.dgvSueldo.RowTemplate.Height = 33;
            this.dgvSueldo.Size = new System.Drawing.Size(749, 277);
            this.dgvSueldo.TabIndex = 2;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(12, 26);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(214, 31);
            this.txtSueldo.TabIndex = 3;
            // 
            // ASR
            // 
            this.ASR.FillWeight = 90F;
            this.ASR.HeaderText = "ASR";
            this.ASR.MinimumWidth = 8;
            this.ASR.Name = "ASR";
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.MinimumWidth = 8;
            this.AFP.Name = "AFP";
            this.AFP.Width = 150;
            // 
            // ISR
            // 
            this.ISR.HeaderText = "ISR";
            this.ISR.MinimumWidth = 8;
            this.ISR.Name = "ISR";
            this.ISR.Width = 150;
            // 
            // Total_Descuento
            // 
            this.Total_Descuento.HeaderText = "Total Descuento";
            this.Total_Descuento.MinimumWidth = 8;
            this.Total_Descuento.Name = "Total_Descuento";
            // 
            // Sueldo_Neto
            // 
            this.Sueldo_Neto.HeaderText = "Sueldo Neto";
            this.Sueldo_Neto.MinimumWidth = 8;
            this.Sueldo_Neto.Name = "Sueldo_Neto";
            this.Sueldo_Neto.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.dgvSueldo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSueldo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dgvSueldo;
        private TextBox txtSueldo;
        private DataGridViewTextBoxColumn ASR;
        private DataGridViewTextBoxColumn AFP;
        private DataGridViewTextBoxColumn ISR;
        private DataGridViewTextBoxColumn Total_Descuento;
        private DataGridViewTextBoxColumn Sueldo_Neto;
    }
}