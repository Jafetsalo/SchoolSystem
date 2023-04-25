namespace Insititucion_Educativa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region windows form designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBuscarPersona = new System.Windows.Forms.Button();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.buttonCreatePerson = new System.Windows.Forms.Button();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPersonas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.comboBoxRol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonEliminarPersona = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuscarPersona
            // 
            this.buttonBuscarPersona.Location = new System.Drawing.Point(126, 130);
            this.buttonBuscarPersona.Name = "buttonBuscarPersona";
            this.buttonBuscarPersona.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarPersona.TabIndex = 0;
            this.buttonBuscarPersona.Text = "Ver o Editar";
            this.buttonBuscarPersona.UseVisualStyleBackColor = true;
            this.buttonBuscarPersona.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(121, 38);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(108, 23);
            this.textBoxNombres.TabIndex = 1;
            // 
            // buttonCreatePerson
            // 
            this.buttonCreatePerson.Location = new System.Drawing.Point(414, 207);
            this.buttonCreatePerson.Name = "buttonCreatePerson";
            this.buttonCreatePerson.Size = new System.Drawing.Size(129, 23);
            this.buttonCreatePerson.TabIndex = 2;
            this.buttonCreatePerson.Text = "Crear Persona";
            this.buttonCreatePerson.UseVisualStyleBackColor = true;
            this.buttonCreatePerson.Click += new System.EventHandler(this.buttonCreatePerson_Click);
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(121, 67);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(108, 23);
            this.textBoxApellidos.TabIndex = 3;
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(121, 109);
            this.textBoxDocumento.MaxLength = 100;
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(108, 23);
            this.textBoxDocumento.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Estado Civil";
            // 
            // comboBoxPersonas
            // 
            this.comboBoxPersonas.FormattingEnabled = true;
            this.comboBoxPersonas.Location = new System.Drawing.Point(107, 94);
            this.comboBoxPersonas.Name = "comboBoxPersonas";
            this.comboBoxPersonas.Size = new System.Drawing.Size(121, 23);
            this.comboBoxPersonas.TabIndex = 10;
            this.comboBoxPersonas.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonas_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxEstadoCivil);
            this.groupBox1.Controls.Add(this.textBoxNombres);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDocumento);
            this.groupBox1.Controls.Add(this.textBoxApellidos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(329, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 253);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Persona";
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(121, 138);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEstadoCivil.TabIndex = 10;
            this.comboBoxEstadoCivil.SelectionChangeCommitted += new System.EventHandler(this.comboBoxEstadoCivil_SelectionChangeCommitted);
            // 
            // comboBoxRol
            // 
            this.comboBoxRol.FormattingEnabled = true;
            this.comboBoxRol.Location = new System.Drawing.Point(606, 76);
            this.comboBoxRol.Name = "comboBoxRol";
            this.comboBoxRol.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRol.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(606, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rol";
            // 
            // buttonEliminarPersona
            // 
            this.buttonEliminarPersona.Location = new System.Drawing.Point(126, 169);
            this.buttonEliminarPersona.Name = "buttonEliminarPersona";
            this.buttonEliminarPersona.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarPersona.TabIndex = 14;
            this.buttonEliminarPersona.Text = "Eliminar";
            this.buttonEliminarPersona.UseVisualStyleBackColor = true;
            this.buttonEliminarPersona.Click += new System.EventHandler(this.ButtonEliminarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEliminarPersona);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxRol);
            this.Controls.Add(this.comboBoxPersonas);
            this.Controls.Add(this.buttonCreatePerson);
            this.Controls.Add(this.buttonBuscarPersona);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBuscarPersona;
        private TextBox textBoxNombres;
        private Button buttonCreatePerson;
        private TextBox textBoxApellidos;
        private TextBox textBoxDocumento;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxPersonas;
        private GroupBox groupBox1;
        private ComboBox comboBoxEstadoCivil;
        private ComboBox comboBoxRol;
        private Label label5;
        private Button buttonEliminarPersona;
    }
}