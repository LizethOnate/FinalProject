namespace FinalProject
{
    partial class MostrarPeliculas
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
            this.dgvCartelera = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbTitulo = new System.Windows.Forms.RadioButton();
            this.rbProductora = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbGenero = new System.Windows.Forms.RadioButton();
            this.rbIdioma = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbTduracion = new System.Windows.Forms.RadioButton();
            this.rbDirector = new System.Windows.Forms.RadioButton();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtInformacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartelera
            // 
            this.dgvCartelera.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgvCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartelera.Location = new System.Drawing.Point(241, 99);
            this.dgvCartelera.Name = "dgvCartelera";
            this.dgvCartelera.Size = new System.Drawing.Size(547, 259);
            this.dgvCartelera.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(425, 376);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbTitulo
            // 
            this.rbTitulo.AutoSize = true;
            this.rbTitulo.BackColor = System.Drawing.Color.Transparent;
            this.rbTitulo.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTitulo.ForeColor = System.Drawing.Color.Black;
            this.rbTitulo.Location = new System.Drawing.Point(27, 158);
            this.rbTitulo.Name = "rbTitulo";
            this.rbTitulo.Size = new System.Drawing.Size(74, 24);
            this.rbTitulo.TabIndex = 2;
            this.rbTitulo.TabStop = true;
            this.rbTitulo.Text = "Titulo";
            this.rbTitulo.UseVisualStyleBackColor = false;
            // 
            // rbProductora
            // 
            this.rbProductora.AutoSize = true;
            this.rbProductora.BackColor = System.Drawing.Color.Transparent;
            this.rbProductora.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProductora.ForeColor = System.Drawing.Color.Black;
            this.rbProductora.Location = new System.Drawing.Point(131, 158);
            this.rbProductora.Name = "rbProductora";
            this.rbProductora.Size = new System.Drawing.Size(111, 24);
            this.rbProductora.TabIndex = 3;
            this.rbProductora.TabStop = true;
            this.rbProductora.Text = "Productora";
            this.rbProductora.UseVisualStyleBackColor = false;
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.BackColor = System.Drawing.Color.Transparent;
            this.rbPais.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPais.ForeColor = System.Drawing.Color.Black;
            this.rbPais.Location = new System.Drawing.Point(27, 181);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(56, 24);
            this.rbPais.TabIndex = 4;
            this.rbPais.TabStop = true;
            this.rbPais.Text = "Pais";
            this.rbPais.UseVisualStyleBackColor = false;
            // 
            // rbGenero
            // 
            this.rbGenero.AutoSize = true;
            this.rbGenero.BackColor = System.Drawing.Color.Transparent;
            this.rbGenero.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGenero.ForeColor = System.Drawing.Color.Black;
            this.rbGenero.Location = new System.Drawing.Point(133, 181);
            this.rbGenero.Name = "rbGenero";
            this.rbGenero.Size = new System.Drawing.Size(81, 24);
            this.rbGenero.TabIndex = 5;
            this.rbGenero.TabStop = true;
            this.rbGenero.Text = "Genero";
            this.rbGenero.UseVisualStyleBackColor = false;
            // 
            // rbIdioma
            // 
            this.rbIdioma.AutoSize = true;
            this.rbIdioma.BackColor = System.Drawing.Color.Transparent;
            this.rbIdioma.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIdioma.ForeColor = System.Drawing.Color.Black;
            this.rbIdioma.Location = new System.Drawing.Point(27, 204);
            this.rbIdioma.Name = "rbIdioma";
            this.rbIdioma.Size = new System.Drawing.Size(80, 24);
            this.rbIdioma.TabIndex = 6;
            this.rbIdioma.TabStop = true;
            this.rbIdioma.Text = "Idioma";
            this.rbIdioma.UseVisualStyleBackColor = false;
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.BackColor = System.Drawing.Color.Transparent;
            this.rbFecha.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFecha.ForeColor = System.Drawing.Color.Black;
            this.rbFecha.Location = new System.Drawing.Point(131, 204);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(70, 24);
            this.rbFecha.TabIndex = 7;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = false;
            // 
            // rbTduracion
            // 
            this.rbTduracion.AutoSize = true;
            this.rbTduracion.BackColor = System.Drawing.Color.Transparent;
            this.rbTduracion.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTduracion.ForeColor = System.Drawing.Color.Black;
            this.rbTduracion.Location = new System.Drawing.Point(27, 227);
            this.rbTduracion.Name = "rbTduracion";
            this.rbTduracion.Size = new System.Drawing.Size(103, 24);
            this.rbTduracion.TabIndex = 8;
            this.rbTduracion.TabStop = true;
            this.rbTduracion.Text = "Tduracion";
            this.rbTduracion.UseVisualStyleBackColor = false;
            // 
            // rbDirector
            // 
            this.rbDirector.AutoSize = true;
            this.rbDirector.BackColor = System.Drawing.Color.Transparent;
            this.rbDirector.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDirector.ForeColor = System.Drawing.Color.Black;
            this.rbDirector.Location = new System.Drawing.Point(131, 227);
            this.rbDirector.Name = "rbDirector";
            this.rbDirector.Size = new System.Drawing.Size(89, 24);
            this.rbDirector.TabIndex = 9;
            this.rbDirector.TabStop = true;
            this.rbDirector.Text = "Director";
            this.rbDirector.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(542, 376);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(713, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // txtInformacion
            // 
            this.txtInformacion.Location = new System.Drawing.Point(460, 63);
            this.txtInformacion.Name = "txtInformacion";
            this.txtInformacion.Size = new System.Drawing.Size(100, 20);
            this.txtInformacion.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Informacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 30);
            this.label3.TabIndex = 16;
            this.label3.Text = "CARETELERA";
            // 
            // MostrarPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.Capturatr1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInformacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.rbDirector);
            this.Controls.Add(this.rbTduracion);
            this.Controls.Add(this.rbFecha);
            this.Controls.Add(this.rbIdioma);
            this.Controls.Add(this.rbGenero);
            this.Controls.Add(this.rbPais);
            this.Controls.Add(this.rbProductora);
            this.Controls.Add(this.rbTitulo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvCartelera);
            this.DoubleBuffered = true;
            this.Name = "MostrarPeliculas";
            this.Text = "MostrarPeliculas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartelera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartelera;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbTitulo;
        private System.Windows.Forms.RadioButton rbProductora;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbGenero;
        private System.Windows.Forms.RadioButton rbIdioma;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbTduracion;
        private System.Windows.Forms.RadioButton rbDirector;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtInformacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}