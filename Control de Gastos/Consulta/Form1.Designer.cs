namespace Consulta
{
    partial class Form1
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
            this.Consulta = new System.Windows.Forms.GroupBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Categoria = new System.Windows.Forms.Button();
            this.btn_Concepto = new System.Windows.Forms.Button();
            this.cbx_Categoria = new System.Windows.Forms.ComboBox();
            this.cbx_Concepto = new System.Windows.Forms.ComboBox();
            this.dtp_Fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.cbx_Calidad = new System.Windows.Forms.ComboBox();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.cbx_Calidad);
            this.Consulta.Controls.Add(this.tbx_ID);
            this.Consulta.Controls.Add(this.label5);
            this.Consulta.Controls.Add(this.label4);
            this.Consulta.Controls.Add(this.label3);
            this.Consulta.Controls.Add(this.label2);
            this.Consulta.Controls.Add(this.label1);
            this.Consulta.Controls.Add(this.btn_Agregar);
            this.Consulta.Controls.Add(this.btn_Categoria);
            this.Consulta.Controls.Add(this.btn_Concepto);
            this.Consulta.Controls.Add(this.cbx_Categoria);
            this.Consulta.Controls.Add(this.cbx_Concepto);
            this.Consulta.Controls.Add(this.dtp_Fecha);
            this.Consulta.Location = new System.Drawing.Point(12, 12);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(479, 220);
            this.Consulta.TabIndex = 0;
            this.Consulta.TabStop = false;
            this.Consulta.Text = "Ingresos y Egresos";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(373, 35);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.Size = new System.Drawing.Size(100, 20);
            this.tbx_ID.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Calidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Concepto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(118, 176);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 6;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // btn_Categoria
            // 
            this.btn_Categoria.Location = new System.Drawing.Point(139, 130);
            this.btn_Categoria.Name = "btn_Categoria";
            this.btn_Categoria.Size = new System.Drawing.Size(30, 23);
            this.btn_Categoria.TabIndex = 5;
            this.btn_Categoria.Text = "...";
            this.btn_Categoria.UseVisualStyleBackColor = true;
            this.btn_Categoria.Click += new System.EventHandler(this.btn_Categoria_Click);
            // 
            // btn_Concepto
            // 
            this.btn_Concepto.Location = new System.Drawing.Point(139, 75);
            this.btn_Concepto.Name = "btn_Concepto";
            this.btn_Concepto.Size = new System.Drawing.Size(30, 23);
            this.btn_Concepto.TabIndex = 4;
            this.btn_Concepto.Text = "...";
            this.btn_Concepto.UseVisualStyleBackColor = true;
            this.btn_Concepto.Click += new System.EventHandler(this.btn_Concepto_Click);
            // 
            // cbx_Categoria
            // 
            this.cbx_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Categoria.FormattingEnabled = true;
            this.cbx_Categoria.Location = new System.Drawing.Point(12, 130);
            this.cbx_Categoria.Name = "cbx_Categoria";
            this.cbx_Categoria.Size = new System.Drawing.Size(121, 21);
            this.cbx_Categoria.TabIndex = 3;
            this.cbx_Categoria.SelectedIndexChanged += new System.EventHandler(this.cbx_Categoria_SelectedIndexChanged);
            this.cbx_Categoria.Click += new System.EventHandler(this.cbx_Categoria_Click);
            // 
            // cbx_Concepto
            // 
            this.cbx_Concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Concepto.FormattingEnabled = true;
            this.cbx_Concepto.Location = new System.Drawing.Point(12, 77);
            this.cbx_Concepto.Name = "cbx_Concepto";
            this.cbx_Concepto.Size = new System.Drawing.Size(121, 21);
            this.cbx_Concepto.TabIndex = 2;
            this.cbx_Concepto.SelectedIndexChanged += new System.EventHandler(this.cbx_Concepto_SelectedIndexChanged);
            this.cbx_Concepto.Click += new System.EventHandler(this.cbx_Concepto_Click);
            // 
            // dtp_Fecha
            // 
            this.dtp_Fecha.Location = new System.Drawing.Point(12, 35);
            this.dtp_Fecha.Name = "dtp_Fecha";
            this.dtp_Fecha.Size = new System.Drawing.Size(200, 20);
            this.dtp_Fecha.TabIndex = 0;
            // 
            // dgv_Consulta
            // 
            this.dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consulta.Location = new System.Drawing.Point(10, 243);
            this.dgv_Consulta.Name = "dgv_Consulta";
            this.dgv_Consulta.RowHeadersWidth = 62;
            this.dgv_Consulta.Size = new System.Drawing.Size(480, 199);
            this.dgv_Consulta.TabIndex = 1;
            // 
            // cbx_Calidad
            // 
            this.cbx_Calidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Calidad.FormattingEnabled = true;
            this.cbx_Calidad.Items.AddRange(new object[] {
            "1/10",
            "2/10",
            "3/10",
            "4/10",
            "5/10",
            "6/10",
            "7/10",
            "8/10",
            "9/10",
            "10/10"});
            this.cbx_Calidad.Location = new System.Drawing.Point(12, 178);
            this.cbx_Calidad.Name = "cbx_Calidad";
            this.cbx_Calidad.Size = new System.Drawing.Size(100, 21);
            this.cbx_Calidad.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 450);
            this.Controls.Add(this.dgv_Consulta);
            this.Controls.Add(this.Consulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Consulta.ResumeLayout(false);
            this.Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Consulta;
        private System.Windows.Forms.ComboBox cbx_Categoria;
        private System.Windows.Forms.ComboBox cbx_Concepto;
        private System.Windows.Forms.DateTimePicker dtp_Fecha;
        private System.Windows.Forms.DataGridView dgv_Consulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Categoria;
        private System.Windows.Forms.Button btn_Concepto;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_Calidad;
    }
}

