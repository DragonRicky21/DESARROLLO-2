namespace Consulta
{
    partial class Concepto
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
            this.dgv_Concepto = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.gbx_Concepto = new System.Windows.Forms.GroupBox();
            this.lbl_CreatedDate = new System.Windows.Forms.Label();
            this.checkbox_Visible = new System.Windows.Forms.CheckBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concepto)).BeginInit();
            this.gbx_Concepto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Concepto
            // 
            this.dgv_Concepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Concepto.Location = new System.Drawing.Point(537, 23);
            this.dgv_Concepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_Concepto.Name = "dgv_Concepto";
            this.dgv_Concepto.RowHeadersWidth = 62;
            this.dgv_Concepto.Size = new System.Drawing.Size(645, 466);
            this.dgv_Concepto.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(396, 454);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(112, 35);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(130, 454);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(112, 35);
            this.btn_Guardar.TabIndex = 7;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click_1);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.Lime;
            this.btn_Nuevo.Location = new System.Drawing.Point(9, 454);
            this.btn_Nuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(112, 35);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // gbx_Concepto
            // 
            this.gbx_Concepto.Controls.Add(this.lbl_CreatedDate);
            this.gbx_Concepto.Controls.Add(this.checkbox_Visible);
            this.gbx_Concepto.Controls.Add(this.tbx_ID);
            this.gbx_Concepto.Controls.Add(this.tbx_Descripcion);
            this.gbx_Concepto.Controls.Add(this.tbx_Nombre);
            this.gbx_Concepto.Controls.Add(this.label3);
            this.gbx_Concepto.Controls.Add(this.label2);
            this.gbx_Concepto.Controls.Add(this.label1);
            this.gbx_Concepto.Enabled = false;
            this.gbx_Concepto.Location = new System.Drawing.Point(9, 5);
            this.gbx_Concepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Concepto.Name = "gbx_Concepto";
            this.gbx_Concepto.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbx_Concepto.Size = new System.Drawing.Size(522, 409);
            this.gbx_Concepto.TabIndex = 5;
            this.gbx_Concepto.TabStop = false;
            this.gbx_Concepto.Text = "Gestion de Concepto";
            // 
            // lbl_CreatedDate
            // 
            this.lbl_CreatedDate.AutoSize = true;
            this.lbl_CreatedDate.Location = new System.Drawing.Point(382, 343);
            this.lbl_CreatedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CreatedDate.Name = "lbl_CreatedDate";
            this.lbl_CreatedDate.Size = new System.Drawing.Size(21, 20);
            this.lbl_CreatedDate.TabIndex = 7;
            this.lbl_CreatedDate.Text = "...";
            // 
            // checkbox_Visible
            // 
            this.checkbox_Visible.AutoSize = true;
            this.checkbox_Visible.Location = new System.Drawing.Point(14, 337);
            this.checkbox_Visible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkbox_Visible.Name = "checkbox_Visible";
            this.checkbox_Visible.Size = new System.Drawing.Size(152, 24);
            this.checkbox_Visible.TabIndex = 6;
            this.checkbox_Visible.Text = "Visible al Publico";
            this.checkbox_Visible.UseVisualStyleBackColor = true;
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(350, 65);
            this.tbx_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.Size = new System.Drawing.Size(148, 26);
            this.tbx_ID.TabIndex = 5;
            this.tbx_ID.TextChanged += new System.EventHandler(this.tbx_ID_TextChanged);
            // 
            // tbx_Descripcion
            // 
            this.tbx_Descripcion.Location = new System.Drawing.Point(14, 172);
            this.tbx_Descripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Descripcion.Multiline = true;
            this.tbx_Descripcion.Name = "tbx_Descripcion";
            this.tbx_Descripcion.Size = new System.Drawing.Size(484, 153);
            this.tbx_Descripcion.TabIndex = 4;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Location = new System.Drawing.Point(14, 112);
            this.tbx_Nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(148, 26);
            this.tbx_Nombre.TabIndex = 3;
            this.tbx_Nombre.TextChanged += new System.EventHandler(this.tbx_Nombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // Concepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 508);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.gbx_Concepto);
            this.Controls.Add(this.dgv_Concepto);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Concepto";
            this.Text = "Concepto";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Concepto)).EndInit();
            this.gbx_Concepto.ResumeLayout(false);
            this.gbx_Concepto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Concepto;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.GroupBox gbx_Concepto;
        private System.Windows.Forms.Label lbl_CreatedDate;
        private System.Windows.Forms.CheckBox checkbox_Visible;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.TextBox tbx_Descripcion;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}