
namespace Películas
{
    partial class fPeliculas
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
            this.tPeliculas = new System.Windows.Forms.TextBox();
            this.lTitulo = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.lCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tPeliculas
            // 
            this.tPeliculas.Location = new System.Drawing.Point(71, 26);
            this.tPeliculas.Name = "tPeliculas";
            this.tPeliculas.Size = new System.Drawing.Size(318, 20);
            this.tPeliculas.TabIndex = 0;
            this.tPeliculas.TextChanged += new System.EventHandler(this.tPeliculas_TextChanged);
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Location = new System.Drawing.Point(27, 29);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(38, 13);
            this.lTitulo.TabIndex = 1;
            this.lTitulo.Text = "Título:";
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(71, 68);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(75, 23);
            this.bAgregar.TabIndex = 2;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(152, 68);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 23);
            this.bBuscar.TabIndex = 3;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(233, 68);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(75, 23);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(314, 68);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(75, 23);
            this.bListar.TabIndex = 5;
            this.bListar.Text = "Listar";
            this.bListar.UseVisualStyleBackColor = true;
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(329, 126);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 6;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(30, 111);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(116, 13);
            this.lCantidad.TabIndex = 7;
            this.lCantidad.Text = "Cantidad de películas: ";
            // 
            // fPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 161);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.lTitulo);
            this.Controls.Add(this.tPeliculas);
            this.Name = "fPeliculas";
            this.Text = "Películas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tPeliculas;
        private System.Windows.Forms.Label lTitulo;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lCantidad;
    }
}

