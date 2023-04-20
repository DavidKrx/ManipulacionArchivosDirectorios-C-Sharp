
namespace ManipulacionArchivosDirectorios
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
            this.buttonListar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonRenombrarMover = new System.Windows.Forms.Button();
            this.buttonVisualizarFichero = new System.Windows.Forms.Button();
            this.DirectorioActual = new System.Windows.Forms.Label();
            this.DirectorioFichero = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.txtDirectorioActual = new System.Windows.Forms.TextBox();
            this.txtDirectorioFichero = new System.Windows.Forms.TextBox();
            this.buttonModificarFichero = new System.Windows.Forms.Button();
            this.checkboxFichero = new System.Windows.Forms.RadioButton();
            this.checkboxCarpeta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // buttonListar
            // 
            this.buttonListar.Location = new System.Drawing.Point(26, 42);
            this.buttonListar.Name = "buttonListar";
            this.buttonListar.Size = new System.Drawing.Size(150, 25);
            this.buttonListar.TabIndex = 0;
            this.buttonListar.Text = "Listar carpetas y ficheros";
            this.buttonListar.UseVisualStyleBackColor = true;
            this.buttonListar.Click += new System.EventHandler(this.buttonListar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.Location = new System.Drawing.Point(26, 183);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(150, 25);
            this.buttonCrear.TabIndex = 1;
            this.buttonCrear.Text = "Crear";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(182, 183);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(150, 25);
            this.buttonEliminar.TabIndex = 2;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonRenombrarMover
            // 
            this.buttonRenombrarMover.Location = new System.Drawing.Point(338, 183);
            this.buttonRenombrarMover.Name = "buttonRenombrarMover";
            this.buttonRenombrarMover.Size = new System.Drawing.Size(150, 25);
            this.buttonRenombrarMover.TabIndex = 3;
            this.buttonRenombrarMover.Text = "Renombrar o mover";
            this.buttonRenombrarMover.UseVisualStyleBackColor = true;
            this.buttonRenombrarMover.Click += new System.EventHandler(this.buttonRenombrarMover_Click);
            // 
            // buttonVisualizarFichero
            // 
            this.buttonVisualizarFichero.Location = new System.Drawing.Point(26, 283);
            this.buttonVisualizarFichero.Name = "buttonVisualizarFichero";
            this.buttonVisualizarFichero.Size = new System.Drawing.Size(150, 25);
            this.buttonVisualizarFichero.TabIndex = 4;
            this.buttonVisualizarFichero.Text = "Visualizar fichero";
            this.buttonVisualizarFichero.UseVisualStyleBackColor = true;
            this.buttonVisualizarFichero.Click += new System.EventHandler(this.buttonVisualizarFichero_Click);
            // 
            // DirectorioActual
            // 
            this.DirectorioActual.AutoSize = true;
            this.DirectorioActual.Location = new System.Drawing.Point(23, 13);
            this.DirectorioActual.Name = "DirectorioActual";
            this.DirectorioActual.Size = new System.Drawing.Size(84, 13);
            this.DirectorioActual.TabIndex = 5;
            this.DirectorioActual.Text = "Directorio actual";
            // 
            // DirectorioFichero
            // 
            this.DirectorioFichero.AutoSize = true;
            this.DirectorioFichero.Location = new System.Drawing.Point(23, 249);
            this.DirectorioFichero.Name = "DirectorioFichero";
            this.DirectorioFichero.Size = new System.Drawing.Size(99, 13);
            this.DirectorioFichero.TabIndex = 6;
            this.DirectorioFichero.Text = "Directorio o Fichero";
            this.DirectorioFichero.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(26, 71);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(733, 95);
            this.listBox.TabIndex = 7;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(26, 312);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(733, 109);
            this.textBox.TabIndex = 8;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // txtDirectorioActual
            // 
            this.txtDirectorioActual.Location = new System.Drawing.Point(113, 10);
            this.txtDirectorioActual.Name = "txtDirectorioActual";
            this.txtDirectorioActual.Size = new System.Drawing.Size(646, 20);
            this.txtDirectorioActual.TabIndex = 9;
            this.txtDirectorioActual.TextChanged += new System.EventHandler(this.txtDirectorioActual_TextChanged);
            // 
            // txtDirectorioFichero
            // 
            this.txtDirectorioFichero.Location = new System.Drawing.Point(128, 246);
            this.txtDirectorioFichero.Name = "txtDirectorioFichero";
            this.txtDirectorioFichero.Size = new System.Drawing.Size(631, 20);
            this.txtDirectorioFichero.TabIndex = 10;
            this.txtDirectorioFichero.TextChanged += new System.EventHandler(this.txtDirectorioFichero_TextChanged);
            // 
            // buttonModificarFichero
            // 
            this.buttonModificarFichero.Location = new System.Drawing.Point(182, 283);
            this.buttonModificarFichero.Name = "buttonModificarFichero";
            this.buttonModificarFichero.Size = new System.Drawing.Size(150, 25);
            this.buttonModificarFichero.TabIndex = 13;
            this.buttonModificarFichero.Text = "Modificar fichero";
            this.buttonModificarFichero.UseVisualStyleBackColor = true;
            this.buttonModificarFichero.Click += new System.EventHandler(this.buttonModificarFichero_Click);
            // 
            // checkboxFichero
            // 
            this.checkboxFichero.AutoSize = true;
            this.checkboxFichero.Location = new System.Drawing.Point(26, 214);
            this.checkboxFichero.Name = "checkboxFichero";
            this.checkboxFichero.Size = new System.Drawing.Size(60, 17);
            this.checkboxFichero.TabIndex = 14;
            this.checkboxFichero.TabStop = true;
            this.checkboxFichero.Text = "Fichero";
            this.checkboxFichero.UseVisualStyleBackColor = true;
            this.checkboxFichero.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // checkboxCarpeta
            // 
            this.checkboxCarpeta.AutoSize = true;
            this.checkboxCarpeta.Location = new System.Drawing.Point(128, 214);
            this.checkboxCarpeta.Name = "checkboxCarpeta";
            this.checkboxCarpeta.Size = new System.Drawing.Size(62, 17);
            this.checkboxCarpeta.TabIndex = 15;
            this.checkboxCarpeta.TabStop = true;
            this.checkboxCarpeta.Text = "Carpeta";
            this.checkboxCarpeta.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkboxCarpeta);
            this.Controls.Add(this.checkboxFichero);
            this.Controls.Add(this.buttonModificarFichero);
            this.Controls.Add(this.txtDirectorioFichero);
            this.Controls.Add(this.txtDirectorioActual);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.DirectorioFichero);
            this.Controls.Add(this.DirectorioActual);
            this.Controls.Add(this.buttonVisualizarFichero);
            this.Controls.Add(this.buttonRenombrarMover);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.buttonListar);
            this.Name = "Form1";
            this.Text = "Proyecto Ficheros y Carpetas en C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonListar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonRenombrarMover;
        private System.Windows.Forms.Button buttonVisualizarFichero;
        private System.Windows.Forms.Label DirectorioActual;
        private System.Windows.Forms.Label DirectorioFichero;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox txtDirectorioActual;
        private System.Windows.Forms.TextBox txtDirectorioFichero;
        private System.Windows.Forms.Button buttonModificarFichero;
        private System.Windows.Forms.RadioButton checkboxFichero;
        private System.Windows.Forms.RadioButton checkboxCarpeta;
    }
}

