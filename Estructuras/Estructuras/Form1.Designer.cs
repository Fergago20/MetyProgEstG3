namespace Estructuras
{
    partial class Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblValorcdeX = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPuntos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValorcdeX
            // 
            this.lblValorcdeX.AutoSize = true;
            this.lblValorcdeX.Location = new System.Drawing.Point(89, 49);
            this.lblValorcdeX.Name = "lblValorcdeX";
            this.lblValorcdeX.Size = new System.Drawing.Size(69, 16);
            this.lblValorcdeX.TabIndex = 0;
            this.lblValorcdeX.Text = "Valor de X";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(92, 80);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 22);
            this.tbX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor de Y";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(92, 173);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 22);
            this.tbY.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 228);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 31);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar Valores";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPuntos
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPuntos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPuntos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPuntos.Location = new System.Drawing.Point(475, 228);
            this.dgvPuntos.Name = "dgvPuntos";
            this.dgvPuntos.RowHeadersWidth = 51;
            this.dgvPuntos.RowTemplate.Height = 24;
            this.dgvPuntos.Size = new System.Drawing.Size(227, 193);
            this.dgvPuntos.TabIndex = 5;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvPuntos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblValorcdeX);
            this.Name = "Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorcdeX;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPuntos;
    }
}

