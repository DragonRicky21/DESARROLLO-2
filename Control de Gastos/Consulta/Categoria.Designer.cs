namespace Consulta
{
    partial class Categoria
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
            this.gbx_Categoria = new System.Windows.Forms.GroupBox();
            this.lbl_CreatedDate = new System.Windows.Forms.Label();
            this.checkbox_Visible = new System.Windows.Forms.CheckBox();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.tbx_Descripcion = new System.Windows.Forms.TextBox();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Categoria = new System.Windows.Forms.DataGridView();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gbx_Categoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Categoria
            // 
            this.gbx_Categoria.Controls.Add(this.lbl_CreatedDate);
            this.gbx_Categoria.Controls.Add(this.checkbox_Visible);
            this.gbx_Categoria.Controls.Add(this.tbx_ID);
            this.gbx_Categoria.Controls.Add(this.tbx_Descripcion);
            this.gbx_Categoria.Controls.Add(this.tbx_Nombre);
            this.gbx_Categoria.Controls.Add(this.label3);
            this.gbx_Categoria.Controls.Add(this.label2);
            this.gbx_Categoria.Controls.Add(this.label1);
            this.gbx_Categoria.Enabled = false;
            this.gbx_Categoria.Location = new System.Drawing.Point(15, 16);
            this.gbx_Categoria.Name = "gbx_Categoria";
            this.gbx_Categoria.Size = new System.Drawing.Size(348, 266);
            this.gbx_Categoria.TabIndex = 0;
            this.gbx_Categoria.TabStop = false;
            this.gbx_Categoria.Text = "Gestion de Categoria";
            // 
            // lbl_CreatedDate
            // 
            this.lbl_CreatedDate.AutoSize = true;
            this.lbl_CreatedDate.Location = new System.Drawing.Point(255, 223);
            this.lbl_CreatedDate.Name = "lbl_CreatedDate";
            this.lbl_CreatedDate.Size = new System.Drawing.Size(16, 13);
            this.lbl_CreatedDate.TabIndex = 7;
            this.lbl_CreatedDate.Text = "...";
            this.lbl_CreatedDate.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkbox_Visible
            // 
            this.checkbox_Visible.AutoSize = true;
            this.checkbox_Visible.Location = new System.Drawing.Point(9, 219);
            this.checkbox_Visible.Name = "checkbox_Visible";
            this.checkbox_Visible.Size = new System.Drawing.Size(105, 17);
            this.checkbox_Visible.TabIndex = 6;
            this.checkbox_Visible.Text = "Visible al Publico";
            this.checkbox_Visible.UseVisualStyleBackColor = true;
            // 
            // tbx_ID
            // 
            this.tbx_ID.Location = new System.Drawing.Point(233, 42);
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.ReadOnly = true;
            this.tbx_ID.Size = new System.Drawing.Size(100, 20);
            this.tbx_ID.TabIndex = 5;
            // 
            // tbx_Descripcion
            // 
            this.tbx_Descripcion.Location = new System.Drawing.Point(9, 112);
            this.tbx_Descripcion.Multiline = true;
            this.tbx_Descripcion.Name = "tbx_Descripcion";
            this.tbx_Descripcion.Size = new System.Drawing.Size(324, 101);
            this.tbx_Descripcion.TabIndex = 4;
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Location = new System.Drawing.Point(9, 73);
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(100, 20);
            this.tbx_Nombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // dgv_Categoria
            // 
            this.dgv_Categoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Categoria.Location = new System.Drawing.Point(369, 26);
            this.dgv_Categoria.Name = "dgv_Categoria";
            this.dgv_Categoria.Size = new System.Drawing.Size(419, 306);
            this.dgv_Categoria.TabIndex = 1;
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.BackColor = System.Drawing.Color.Lime;
            this.btn_Nuevo.Location = new System.Drawing.Point(15, 308);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_Nuevo.TabIndex = 2;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = false;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.Location = new System.Drawing.Point(96, 308);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_Cancelar.Location = new System.Drawing.Point(273, 308);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.dgv_Categoria);
            this.Controls.Add(this.gbx_Categoria);
            this.Name = "Categoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.Categoria_Load);
            this.gbx_Categoria.ResumeLayout(false);
            this.gbx_Categoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Categoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Categoria;
        private System.Windows.Forms.DataGridView dgv_Categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CreatedDate;
        private System.Windows.Forms.CheckBox checkbox_Visible;
        private System.Windows.Forms.TextBox tbx_ID;
        private System.Windows.Forms.TextBox tbx_Descripcion;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}