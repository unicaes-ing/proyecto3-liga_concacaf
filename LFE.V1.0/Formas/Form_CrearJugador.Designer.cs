namespace LFE.V1._0.Formas
{
    partial class Form_CrearJugador
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
            this.labelCreaTuEquipo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxJugador = new System.Windows.Forms.TextBox();
            this.labelJugadorGoles = new System.Windows.Forms.Label();
            this.textBoxGoles = new System.Windows.Forms.TextBox();
            this.labelPosicion = new System.Windows.Forms.Label();
            this.radioButtonDelantero = new System.Windows.Forms.RadioButton();
            this.radioButtonPortero = new System.Windows.Forms.RadioButton();
            this.radioButtonDefensa = new System.Windows.Forms.RadioButton();
            this.radioButtoncentro = new System.Windows.Forms.RadioButton();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCreaTuEquipo
            // 
            this.labelCreaTuEquipo.AutoSize = true;
            this.labelCreaTuEquipo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreaTuEquipo.Location = new System.Drawing.Point(245, 55);
            this.labelCreaTuEquipo.Name = "labelCreaTuEquipo";
            this.labelCreaTuEquipo.Size = new System.Drawing.Size(315, 44);
            this.labelCreaTuEquipo.TabIndex = 11;
            this.labelCreaTuEquipo.Text = "Crea Tu Jugador";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(41, 153);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(167, 23);
            this.labelNombre.TabIndex = 12;
            this.labelNombre.Text = "Nombre Jugador";
            // 
            // textBoxJugador
            // 
            this.textBoxJugador.Location = new System.Drawing.Point(224, 158);
            this.textBoxJugador.Name = "textBoxJugador";
            this.textBoxJugador.Size = new System.Drawing.Size(289, 20);
            this.textBoxJugador.TabIndex = 13;
            // 
            // labelJugadorGoles
            // 
            this.labelJugadorGoles.AutoSize = true;
            this.labelJugadorGoles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJugadorGoles.Location = new System.Drawing.Point(37, 224);
            this.labelJugadorGoles.Name = "labelJugadorGoles";
            this.labelJugadorGoles.Size = new System.Drawing.Size(171, 23);
            this.labelJugadorGoles.TabIndex = 14;
            this.labelJugadorGoles.Text = "Número de Goles";
            // 
            // textBoxGoles
            // 
            this.textBoxGoles.Location = new System.Drawing.Point(224, 229);
            this.textBoxGoles.Name = "textBoxGoles";
            this.textBoxGoles.Size = new System.Drawing.Size(66, 20);
            this.textBoxGoles.TabIndex = 15;
            this.textBoxGoles.TextChanged += new System.EventHandler(this.textBoxGoles_TextChanged);
            // 
            // labelPosicion
            // 
            this.labelPosicion.AutoSize = true;
            this.labelPosicion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosicion.Location = new System.Drawing.Point(21, 312);
            this.labelPosicion.Name = "labelPosicion";
            this.labelPosicion.Size = new System.Drawing.Size(178, 23);
            this.labelPosicion.TabIndex = 16;
            this.labelPosicion.Text = "Posicion de Juego";
            // 
            // radioButtonDelantero
            // 
            this.radioButtonDelantero.AutoSize = true;
            this.radioButtonDelantero.Location = new System.Drawing.Point(205, 318);
            this.radioButtonDelantero.Name = "radioButtonDelantero";
            this.radioButtonDelantero.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDelantero.TabIndex = 17;
            this.radioButtonDelantero.TabStop = true;
            this.radioButtonDelantero.Text = "Delantero";
            this.radioButtonDelantero.UseVisualStyleBackColor = true;
            // 
            // radioButtonPortero
            // 
            this.radioButtonPortero.AutoSize = true;
            this.radioButtonPortero.Location = new System.Drawing.Point(205, 430);
            this.radioButtonPortero.Name = "radioButtonPortero";
            this.radioButtonPortero.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPortero.TabIndex = 18;
            this.radioButtonPortero.TabStop = true;
            this.radioButtonPortero.Text = "Portero";
            this.radioButtonPortero.UseVisualStyleBackColor = true;
            // 
            // radioButtonDefensa
            // 
            this.radioButtonDefensa.AutoSize = true;
            this.radioButtonDefensa.Location = new System.Drawing.Point(205, 392);
            this.radioButtonDefensa.Name = "radioButtonDefensa";
            this.radioButtonDefensa.Size = new System.Drawing.Size(65, 17);
            this.radioButtonDefensa.TabIndex = 19;
            this.radioButtonDefensa.TabStop = true;
            this.radioButtonDefensa.Text = "Defensa";
            this.radioButtonDefensa.UseVisualStyleBackColor = true;
            // 
            // radioButtoncentro
            // 
            this.radioButtoncentro.AutoSize = true;
            this.radioButtoncentro.Location = new System.Drawing.Point(205, 357);
            this.radioButtoncentro.Name = "radioButtoncentro";
            this.radioButtoncentro.Size = new System.Drawing.Size(102, 17);
            this.radioButtoncentro.TabIndex = 20;
            this.radioButtoncentro.TabStop = true;
            this.radioButtoncentro.Text = "Centro Campista";
            this.radioButtoncentro.UseVisualStyleBackColor = true;
            // 
            // buttonCrear
            // 
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrear.Location = new System.Drawing.Point(482, 343);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(236, 31);
            this.buttonCrear.TabIndex = 21;
            this.buttonCrear.Text = "Crear Jugador";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(482, 416);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(236, 31);
            this.buttonCancelar.TabIndex = 22;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // Form_CrearJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 499);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.radioButtoncentro);
            this.Controls.Add(this.radioButtonDefensa);
            this.Controls.Add(this.radioButtonPortero);
            this.Controls.Add(this.radioButtonDelantero);
            this.Controls.Add(this.labelPosicion);
            this.Controls.Add(this.textBoxGoles);
            this.Controls.Add(this.labelJugadorGoles);
            this.Controls.Add(this.textBoxJugador);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCreaTuEquipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CrearJugador";
            this.Text = "Form_CrearJugador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreaTuEquipo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxJugador;
        private System.Windows.Forms.Label labelJugadorGoles;
        private System.Windows.Forms.TextBox textBoxGoles;
        private System.Windows.Forms.Label labelPosicion;
        private System.Windows.Forms.RadioButton radioButtonDelantero;
        private System.Windows.Forms.RadioButton radioButtonPortero;
        private System.Windows.Forms.RadioButton radioButtonDefensa;
        private System.Windows.Forms.RadioButton radioButtoncentro;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Button buttonCancelar;
    }
}