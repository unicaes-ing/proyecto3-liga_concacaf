namespace LFE.V1._0.Formas
{
    partial class Form_CrearEquipo
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.labelDisponible = new System.Windows.Forms.Label();
            this.labelNoDisponbile = new System.Windows.Forms.Label();
            this.buttonVerificar = new System.Windows.Forms.Button();
            this.textBoxNombreEquipo = new System.Windows.Forms.TextBox();
            this.labelNombreEquipo = new System.Windows.Forms.Label();
            this.labelCreaTuEquipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(302, 471);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(236, 31);
            this.buttonCancelar.TabIndex = 17;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonCrear
            // 
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(302, 412);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(236, 31);
            this.buttonCrear.TabIndex = 16;
            this.buttonCrear.Text = "Crear Equipo";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // labelDisponible
            // 
            this.labelDisponible.AutoSize = true;
            this.labelDisponible.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDisponible.ForeColor = System.Drawing.Color.Lime;
            this.labelDisponible.Location = new System.Drawing.Point(349, 338);
            this.labelDisponible.Name = "labelDisponible";
            this.labelDisponible.Size = new System.Drawing.Size(118, 25);
            this.labelDisponible.TabIndex = 15;
            this.labelDisponible.Text = "Disponible";
            // 
            // labelNoDisponbile
            // 
            this.labelNoDisponbile.AutoSize = true;
            this.labelNoDisponbile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoDisponbile.ForeColor = System.Drawing.Color.Red;
            this.labelNoDisponbile.Location = new System.Drawing.Point(340, 338);
            this.labelNoDisponbile.Name = "labelNoDisponbile";
            this.labelNoDisponbile.Size = new System.Drawing.Size(153, 25);
            this.labelNoDisponbile.TabIndex = 14;
            this.labelNoDisponbile.Text = "No Disponible";
            // 
            // buttonVerificar
            // 
            this.buttonVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerificar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerificar.Location = new System.Drawing.Point(302, 254);
            this.buttonVerificar.Name = "buttonVerificar";
            this.buttonVerificar.Size = new System.Drawing.Size(236, 31);
            this.buttonVerificar.TabIndex = 13;
            this.buttonVerificar.Text = "Verificar Disponibilidad";
            this.buttonVerificar.UseVisualStyleBackColor = true;
            this.buttonVerificar.Click += new System.EventHandler(this.buttonVerificar_Click);
            // 
            // textBoxNombreEquipo
            // 
            this.textBoxNombreEquipo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombreEquipo.Location = new System.Drawing.Point(277, 196);
            this.textBoxNombreEquipo.Name = "textBoxNombreEquipo";
            this.textBoxNombreEquipo.Size = new System.Drawing.Size(282, 34);
            this.textBoxNombreEquipo.TabIndex = 12;
            // 
            // labelNombreEquipo
            // 
            this.labelNombreEquipo.AutoSize = true;
            this.labelNombreEquipo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreEquipo.Location = new System.Drawing.Point(19, 198);
            this.labelNombreEquipo.Name = "labelNombreEquipo";
            this.labelNombreEquipo.Size = new System.Drawing.Size(210, 25);
            this.labelNombreEquipo.TabIndex = 11;
            this.labelNombreEquipo.Text = "Nombre Del Equipo";
            // 
            // labelCreaTuEquipo
            // 
            this.labelCreaTuEquipo.AutoSize = true;
            this.labelCreaTuEquipo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreaTuEquipo.Location = new System.Drawing.Point(156, 9);
            this.labelCreaTuEquipo.Name = "labelCreaTuEquipo";
            this.labelCreaTuEquipo.Size = new System.Drawing.Size(498, 77);
            this.labelCreaTuEquipo.TabIndex = 10;
            this.labelCreaTuEquipo.Text = "Crea Tu Equipo";
            // 
            // Form_CrearEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 538);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.labelDisponible);
            this.Controls.Add(this.labelNoDisponbile);
            this.Controls.Add(this.buttonVerificar);
            this.Controls.Add(this.textBoxNombreEquipo);
            this.Controls.Add(this.labelNombreEquipo);
            this.Controls.Add(this.labelCreaTuEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CrearEquipo";
            this.Text = "Form_CrearEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label labelDisponible;
        private System.Windows.Forms.Label labelNoDisponbile;
        private System.Windows.Forms.Button buttonVerificar;
        private System.Windows.Forms.TextBox textBoxNombreEquipo;
        private System.Windows.Forms.Label labelNombreEquipo;
        private System.Windows.Forms.Label labelCreaTuEquipo;
    }
}