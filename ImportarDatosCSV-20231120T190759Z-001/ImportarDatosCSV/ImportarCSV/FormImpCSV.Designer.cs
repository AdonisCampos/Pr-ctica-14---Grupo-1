
namespace ImportarCSV
{
    partial class formImpCSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formImpCSV));
            this.lsCSV = new System.Windows.Forms.ListView();
            this.btImportarCSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lsCodificacion = new System.Windows.Forms.ComboBox();
            this.lsComillas = new System.Windows.Forms.ComboBox();
            this.opComillas = new System.Windows.Forms.CheckBox();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opTitulos = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsCSV
            // 
            this.lsCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsCSV.HideSelection = false;
            this.lsCSV.Location = new System.Drawing.Point(12, 62);
            this.lsCSV.Name = "lsCSV";
            this.lsCSV.Size = new System.Drawing.Size(888, 589);
            this.lsCSV.TabIndex = 0;
            this.lsCSV.UseCompatibleStateImageBehavior = false;
            // 
            // btImportarCSV
            // 
            this.btImportarCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btImportarCSV.Location = new System.Drawing.Point(802, 28);
            this.btImportarCSV.Name = "btImportarCSV";
            this.btImportarCSV.Size = new System.Drawing.Size(98, 28);
            this.btImportarCSV.TabIndex = 2;
            this.btImportarCSV.Text = "Importar";
            this.btImportarCSV.UseVisualStyleBackColor = true;
            this.btImportarCSV.Click += new System.EventHandler(this.btImportarCSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lsCodificacion);
            this.groupBox1.Controls.Add(this.lsComillas);
            this.groupBox1.Controls.Add(this.opComillas);
            this.groupBox1.Controls.Add(this.txtSeparador);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.opTitulos);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(611, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Codificación";
            // 
            // lsCodificacion
            // 
            this.lsCodificacion.FormattingEnabled = true;
            this.lsCodificacion.Items.AddRange(new object[] {
            "",
            "UTF-8"});
            this.lsCodificacion.Location = new System.Drawing.Point(682, 19);
            this.lsCodificacion.Name = "lsCodificacion";
            this.lsCodificacion.Size = new System.Drawing.Size(95, 21);
            this.lsCodificacion.Sorted = true;
            this.lsCodificacion.TabIndex = 13;
            this.lsCodificacion.Text = "UTF-8";
            // 
            // lsComillas
            // 
            this.lsComillas.FormattingEnabled = true;
            this.lsComillas.Items.AddRange(new object[] {
            "\'",
            "\""});
            this.lsComillas.Location = new System.Drawing.Point(535, 19);
            this.lsComillas.Name = "lsComillas";
            this.lsComillas.Size = new System.Drawing.Size(42, 21);
            this.lsComillas.Sorted = true;
            this.lsComillas.TabIndex = 12;
            this.lsComillas.Text = "\"";
            // 
            // opComillas
            // 
            this.opComillas.AutoSize = true;
            this.opComillas.Checked = true;
            this.opComillas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opComillas.Location = new System.Drawing.Point(391, 19);
            this.opComillas.Name = "opComillas";
            this.opComillas.Size = new System.Drawing.Size(131, 17);
            this.opComillas.TabIndex = 11;
            this.opComillas.Text = "Campos entre comillas";
            this.opComillas.UseVisualStyleBackColor = true;
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(312, 20);
            this.txtSeparador.MaxLength = 1;
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(20, 20);
            this.txtSeparador.TabIndex = 10;
            this.txtSeparador.Text = ";";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Separador";
            // 
            // opTitulos
            // 
            this.opTitulos.AutoSize = true;
            this.opTitulos.Checked = true;
            this.opTitulos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.opTitulos.Location = new System.Drawing.Point(26, 20);
            this.opTitulos.Name = "opTitulos";
            this.opTitulos.Size = new System.Drawing.Size(183, 17);
            this.opTitulos.TabIndex = 8;
            this.opTitulos.Text = "La primera fila contiene los títulos";
            this.opTitulos.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(887, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formImpCSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 687);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btImportarCSV);
            this.Controls.Add(this.lsCSV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formImpCSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar CSV - ProyectoA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsCSV;
        private System.Windows.Forms.Button btImportarCSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox lsComillas;
        private System.Windows.Forms.CheckBox opComillas;
        private System.Windows.Forms.TextBox txtSeparador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox opTitulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox lsCodificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

