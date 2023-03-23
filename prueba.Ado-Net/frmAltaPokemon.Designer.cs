namespace winfrom_app
{
    partial class frmAltaPokemon
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
            this.pictureBPokemons = new System.Windows.Forms.PictureBox();
            this.UrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cboDebilidad = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.Debilidad = new System.Windows.Forms.Label();
            this.Tipo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBPokemons
            // 
            this.pictureBPokemons.Location = new System.Drawing.Point(395, 65);
            this.pictureBPokemons.Name = "pictureBPokemons";
            this.pictureBPokemons.Size = new System.Drawing.Size(241, 249);
            this.pictureBPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBPokemons.TabIndex = 49;
            this.pictureBPokemons.TabStop = false;
            // 
            // UrlImagen
            // 
            this.UrlImagen.AutoSize = true;
            this.UrlImagen.Location = new System.Drawing.Point(176, 216);
            this.UrlImagen.Name = "UrlImagen";
            this.UrlImagen.Size = new System.Drawing.Size(58, 13);
            this.UrlImagen.TabIndex = 48;
            this.UrlImagen.Text = "Url Imagen";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(249, 209);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(100, 20);
            this.txtUrlImagen.TabIndex = 39;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(176, 177);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(63, 13);
            this.Descripcion.TabIndex = 47;
            this.Descripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(249, 170);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 38;
            // 
            // cboDebilidad
            // 
            this.cboDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDebilidad.FormattingEnabled = true;
            this.cboDebilidad.Location = new System.Drawing.Point(249, 293);
            this.cboDebilidad.Name = "cboDebilidad";
            this.cboDebilidad.Size = new System.Drawing.Size(100, 21);
            this.cboDebilidad.TabIndex = 41;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(249, 251);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(100, 21);
            this.cboTipo.TabIndex = 40;
            // 
            // Debilidad
            // 
            this.Debilidad.AutoSize = true;
            this.Debilidad.Location = new System.Drawing.Point(176, 301);
            this.Debilidad.Name = "Debilidad";
            this.Debilidad.Size = new System.Drawing.Size(51, 13);
            this.Debilidad.TabIndex = 46;
            this.Debilidad.Text = "Debilidad";
            // 
            // Tipo
            // 
            this.Tipo.AutoSize = true;
            this.Tipo.Location = new System.Drawing.Point(176, 259);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(31, 13);
            this.Tipo.TabIndex = 45;
            this.Tipo.Text = "Tipo ";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(176, 128);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 44;
            this.Nombre.Text = "Nombre";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(249, 121);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 37;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(249, 65);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 35;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(164, 363);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 42;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(290, 363);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 43;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Numero";
            // 
            // FrmAltaPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBPokemons);
            this.Controls.Add(this.UrlImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cboDebilidad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.Debilidad);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaPokemon";
            this.Text = "FrmAltaPokemon";
            this.Load += new System.EventHandler(this.FrmAltaPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBPokemons;
        private System.Windows.Forms.Label UrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cboDebilidad;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label Debilidad;
        private System.Windows.Forms.Label Tipo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Label label1;
    }
}