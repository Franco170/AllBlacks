
namespace TP_Client
{
    partial class DetalleTareaForm
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.labelNumeroTarjeta = new System.Windows.Forms.Label();
            this.labelNombreTarjeta = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelPrioridadTarea = new System.Windows.Forms.Label();
            this.labelEstadoTarea = new System.Windows.Forms.Label();
            this.labelAutorTarea = new System.Windows.Forms.Label();
            this.labelEncargadoTarea = new System.Windows.Forms.Label();
            this.textBoxEncargado = new System.Windows.Forms.TextBox();
            this.labelNumerito = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.linkLabelEditar = new System.Windows.Forms.LinkLabel();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.comboBoxPrioridad = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(284, 35);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(135, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(27, 204);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(394, 100);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(304, 85);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(115, 20);
            this.textBoxAutor.TabIndex = 5;
            // 
            // labelNumeroTarjeta
            // 
            this.labelNumeroTarjeta.AutoSize = true;
            this.labelNumeroTarjeta.Location = new System.Drawing.Point(24, 38);
            this.labelNumeroTarjeta.Name = "labelNumeroTarjeta";
            this.labelNumeroTarjeta.Size = new System.Drawing.Size(101, 13);
            this.labelNumeroTarjeta.TabIndex = 6;
            this.labelNumeroTarjeta.Text = "Número de Tarjeta: ";
            // 
            // labelNombreTarjeta
            // 
            this.labelNombreTarjeta.AutoSize = true;
            this.labelNombreTarjeta.Location = new System.Drawing.Point(201, 38);
            this.labelNombreTarjeta.Name = "labelNombreTarjeta";
            this.labelNombreTarjeta.Size = new System.Drawing.Size(77, 13);
            this.labelNombreTarjeta.TabIndex = 7;
            this.labelNombreTarjeta.Text = "Título/Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(24, 188);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 8;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelPrioridadTarea
            // 
            this.labelPrioridadTarea.AutoSize = true;
            this.labelPrioridadTarea.Location = new System.Drawing.Point(47, 134);
            this.labelPrioridadTarea.Name = "labelPrioridadTarea";
            this.labelPrioridadTarea.Size = new System.Drawing.Size(48, 13);
            this.labelPrioridadTarea.TabIndex = 9;
            this.labelPrioridadTarea.Text = "Prioridad";
            // 
            // labelEstadoTarea
            // 
            this.labelEstadoTarea.AutoSize = true;
            this.labelEstadoTarea.Location = new System.Drawing.Point(47, 91);
            this.labelEstadoTarea.Name = "labelEstadoTarea";
            this.labelEstadoTarea.Size = new System.Drawing.Size(40, 13);
            this.labelEstadoTarea.TabIndex = 10;
            this.labelEstadoTarea.Text = "Estado";
            // 
            // labelAutorTarea
            // 
            this.labelAutorTarea.AutoSize = true;
            this.labelAutorTarea.Location = new System.Drawing.Point(254, 88);
            this.labelAutorTarea.Name = "labelAutorTarea";
            this.labelAutorTarea.Size = new System.Drawing.Size(32, 13);
            this.labelAutorTarea.TabIndex = 11;
            this.labelAutorTarea.Text = "Autor";
            // 
            // labelEncargadoTarea
            // 
            this.labelEncargadoTarea.AutoSize = true;
            this.labelEncargadoTarea.Location = new System.Drawing.Point(254, 134);
            this.labelEncargadoTarea.Name = "labelEncargadoTarea";
            this.labelEncargadoTarea.Size = new System.Drawing.Size(59, 13);
            this.labelEncargadoTarea.TabIndex = 12;
            this.labelEncargadoTarea.Text = "Encargado";
            // 
            // textBoxEncargado
            // 
            this.textBoxEncargado.Location = new System.Drawing.Point(319, 131);
            this.textBoxEncargado.Name = "textBoxEncargado";
            this.textBoxEncargado.Size = new System.Drawing.Size(100, 20);
            this.textBoxEncargado.TabIndex = 13;
            // 
            // labelNumerito
            // 
            this.labelNumerito.AutoSize = true;
            this.labelNumerito.Location = new System.Drawing.Point(122, 38);
            this.labelNumerito.Name = "labelNumerito";
            this.labelNumerito.Size = new System.Drawing.Size(19, 13);
            this.labelNumerito.TabIndex = 14;
            this.labelNumerito.Text = "00";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(397, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // linkLabelEditar
            // 
            this.linkLabelEditar.AutoSize = true;
            this.linkLabelEditar.Location = new System.Drawing.Point(24, 331);
            this.linkLabelEditar.Name = "linkLabelEditar";
            this.linkLabelEditar.Size = new System.Drawing.Size(70, 13);
            this.linkLabelEditar.TabIndex = 16;
            this.linkLabelEditar.TabStop = true;
            this.linkLabelEditar.Text = "Editar Tarjeta";
            this.linkLabelEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEditar_LinkClicked);
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
            this.comboBoxEstado.Location = new System.Drawing.Point(104, 88);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(105, 21);
            this.comboBoxEstado.TabIndex = 17;
            // 
            // comboBoxPrioridad
            // 
            this.comboBoxPrioridad.FormattingEnabled = true;
            this.comboBoxPrioridad.Items.AddRange(new object[] {
            "Alta",
            "Media",
            "Baja"});
            this.comboBoxPrioridad.Location = new System.Drawing.Point(104, 131);
            this.comboBoxPrioridad.Name = "comboBoxPrioridad";
            this.comboBoxPrioridad.Size = new System.Drawing.Size(105, 21);
            this.comboBoxPrioridad.TabIndex = 18;
            // 
            // DetalleTareaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.comboBoxPrioridad);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.linkLabelEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.labelNumerito);
            this.Controls.Add(this.textBoxEncargado);
            this.Controls.Add(this.labelEncargadoTarea);
            this.Controls.Add(this.labelAutorTarea);
            this.Controls.Add(this.labelEstadoTarea);
            this.Controls.Add(this.labelPrioridadTarea);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombreTarjeta);
            this.Controls.Add(this.labelNumeroTarjeta);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "DetalleTareaForm";
            this.Text = "DetalleTareaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.Label labelNumeroTarjeta;
        private System.Windows.Forms.Label labelNombreTarjeta;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelPrioridadTarea;
        private System.Windows.Forms.Label labelEstadoTarea;
        private System.Windows.Forms.Label labelAutorTarea;
        private System.Windows.Forms.Label labelEncargadoTarea;
        private System.Windows.Forms.TextBox textBoxEncargado;
        private System.Windows.Forms.Label labelNumerito;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.LinkLabel linkLabelEditar;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.ComboBox comboBoxPrioridad;
    }
}