
namespace TP_Client
{
    partial class NuevaTareaForm
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
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.textBoxDescripción = new System.Windows.Forms.TextBox();
            this.textBoxEncargado = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelEncargado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(70, 80);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(131, 20);
            this.textBoxTitulo.TabIndex = 0;
            // 
            // textBoxDescripción
            // 
            this.textBoxDescripción.Location = new System.Drawing.Point(32, 226);
            this.textBoxDescripción.Multiline = true;
            this.textBoxDescripción.Name = "textBoxDescripción";
            this.textBoxDescripción.Size = new System.Drawing.Size(323, 92);
            this.textBoxDescripción.TabIndex = 1;
            // 
            // textBoxEncargado
            // 
            this.textBoxEncargado.Location = new System.Drawing.Point(297, 80);
            this.textBoxEncargado.Name = "textBoxEncargado";
            this.textBoxEncargado.Size = new System.Drawing.Size(107, 20);
            this.textBoxEncargado.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(29, 83);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Título";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(29, 210);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelEncargado
            // 
            this.labelEncargado.AutoSize = true;
            this.labelEncargado.Location = new System.Drawing.Point(232, 83);
            this.labelEncargado.Name = "labelEncargado";
            this.labelEncargado.Size = new System.Drawing.Size(59, 13);
            this.labelEncargado.TabIndex = 5;
            this.labelEncargado.Text = "Encargado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Por Hacer",
            "En Proceso",
            "Bajo Prueba",
            "Hecho"});
            this.comboBoxEstado.Location = new System.Drawing.Point(80, 160);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 6;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.comboBoxPrioridad.Location = new System.Drawing.Point(283, 160);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrioridad.TabIndex = 7;
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Location = new System.Drawing.Point(280, 144);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(48, 13);
            this.labelPrioridad.TabIndex = 8;
            this.labelPrioridad.Text = "Prioridad";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(77, 144);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(397, 326);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 10;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // NuevaTareaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.labelPrioridad);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.labelEncargado);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textBoxEncargado);
            this.Controls.Add(this.textBoxDescripción);
            this.Controls.Add(this.textBoxTitulo);
            this.Name = "NuevaTareaForm";
            this.Text = "NuevaTareaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxDescripción;
        private System.Windows.Forms.TextBox textBoxEncargado;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelEncargado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button btnCrear;
    }
}