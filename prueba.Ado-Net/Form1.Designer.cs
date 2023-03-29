namespace prueba.Ado_Net
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
            this.pictureBPokemons = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.EliminarLogico = new System.Windows.Forms.Button();
            this.Filtro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.Campo = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.Criterio = new System.Windows.Forms.Label();
            this.FiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBPokemons
            // 
            this.pictureBPokemons.Location = new System.Drawing.Point(569, 81);
            this.pictureBPokemons.Name = "pictureBPokemons";
            this.pictureBPokemons.Size = new System.Drawing.Size(206, 224);
            this.pictureBPokemons.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBPokemons.TabIndex = 7;
            this.pictureBPokemons.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(25, 81);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(509, 224);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged_1);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(25, 345);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(127, 38);
            this.agregar.TabIndex = 8;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click_1);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(192, 345);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(137, 38);
            this.Modificar.TabIndex = 9;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(358, 345);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(129, 38);
            this.Eliminar.TabIndex = 10;
            this.Eliminar.Text = "Borrar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // EliminarLogico
            // 
            this.EliminarLogico.Location = new System.Drawing.Point(518, 345);
            this.EliminarLogico.Name = "EliminarLogico";
            this.EliminarLogico.Size = new System.Drawing.Size(122, 38);
            this.EliminarLogico.TabIndex = 11;
            this.EliminarLogico.Text = "Borrar logico";
            this.EliminarLogico.UseVisualStyleBackColor = true;
            this.EliminarLogico.Click += new System.EventHandler(this.EliminarLogico_Click);
            // 
            // Filtro
            // 
            this.Filtro.AutoSize = true;
            this.Filtro.Location = new System.Drawing.Point(198, 39);
            this.Filtro.Name = "Filtro";
            this.Filtro.Size = new System.Drawing.Size(26, 13);
            this.Filtro.TabIndex = 12;
            this.Filtro.Text = "filtro";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(255, 32);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(136, 20);
            this.txtFiltro.TabIndex = 13;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnFiltro.Location = new System.Drawing.Point(654, 399);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(121, 34);
            this.btnFiltro.TabIndex = 14;
            this.btnFiltro.Text = "buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click_1);
            // 
            // Campo
            // 
            this.Campo.AutoSize = true;
            this.Campo.Location = new System.Drawing.Point(12, 420);
            this.Campo.Name = "Campo";
            this.Campo.Size = new System.Drawing.Size(40, 13);
            this.Campo.TabIndex = 15;
            this.Campo.Text = "Campo";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(281, 412);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(132, 21);
            this.cboCriterio.TabIndex = 16;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(66, 412);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 17;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // Criterio
            // 
            this.Criterio.AutoSize = true;
            this.Criterio.Location = new System.Drawing.Point(229, 420);
            this.Criterio.Name = "Criterio";
            this.Criterio.Size = new System.Drawing.Size(41, 13);
            this.Criterio.TabIndex = 19;
            this.Criterio.Text = "Criteriio";
            // 
            // FiltroAvanzado
            // 
            this.FiltroAvanzado.AutoSize = true;
            this.FiltroAvanzado.Location = new System.Drawing.Point(435, 415);
            this.FiltroAvanzado.Name = "FiltroAvanzado";
            this.FiltroAvanzado.Size = new System.Drawing.Size(29, 13);
            this.FiltroAvanzado.TabIndex = 20;
            this.FiltroAvanzado.Text = "Filtro";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(470, 412);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.FiltroAvanzado);
            this.Controls.Add(this.Criterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.Campo);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.Filtro);
            this.Controls.Add(this.EliminarLogico);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.pictureBPokemons);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBPokemons;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button EliminarLogico;
        private System.Windows.Forms.Label Filtro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label Campo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label Criterio;
        private System.Windows.Forms.Label FiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
    }
}

