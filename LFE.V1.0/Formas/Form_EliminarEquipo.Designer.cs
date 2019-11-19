namespace LFE.V1._0.Formas
{
    partial class Form_EliminarEquipo
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
            this.labelElimina = new System.Windows.Forms.Label();
            this.checkedListBoxEquipos = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // labelElimina
            // 
            this.labelElimina.AutoSize = true;
            this.labelElimina.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelElimina.Location = new System.Drawing.Point(90, 18);
            this.labelElimina.Name = "labelElimina";
            this.labelElimina.Size = new System.Drawing.Size(555, 77);
            this.labelElimina.TabIndex = 11;
            this.labelElimina.Text = "Elimina tu Equipo";
            // 
            // checkedListBoxEquipos
            // 
            this.checkedListBoxEquipos.FormattingEnabled = true;
            this.checkedListBoxEquipos.Location = new System.Drawing.Point(37, 154);
            this.checkedListBoxEquipos.Name = "checkedListBoxEquipos";
            this.checkedListBoxEquipos.Size = new System.Drawing.Size(247, 364);
            this.checkedListBoxEquipos.TabIndex = 12;
            // 
            // Form_EliminarEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 538);
            this.Controls.Add(this.checkedListBoxEquipos);
            this.Controls.Add(this.labelElimina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EliminarEquipo";
            this.Text = "Form_EliminarEquipo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelElimina;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipos;
    }
}