namespace app_datgridview
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.dgv_Datos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(506, 74);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(84, 30);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "Agragar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(506, 130);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(84, 30);
            this.btn_Eliminar.TabIndex = 1;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Correro";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(194, 74);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(282, 20);
            this.txt_Nombre.TabIndex = 4;
            // 
            // txt_Correo
            // 
            this.txt_Correo.Location = new System.Drawing.Point(194, 120);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(282, 20);
            this.txt_Correo.TabIndex = 5;
            // 
            // dgv_Datos
            // 
            this.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.email});
            this.dgv_Datos.Location = new System.Drawing.Point(141, 199);
            this.dgv_Datos.Name = "dgv_Datos";
            this.dgv_Datos.Size = new System.Drawing.Size(487, 150);
            this.dgv_Datos.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 250;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(618, 74);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(80, 30);
            this.btn_Limpiar.TabIndex = 7;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(618, 130);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(80, 30);
            this.btn_Salir.TabIndex = 8;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.dgv_Datos);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Agregar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.DataGridView dgv_Datos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_Salir;
    }
}

