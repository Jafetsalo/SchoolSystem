﻿namespace Insititucion_Educativa
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEstudiante = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMateriasEstudiante = new System.Windows.Forms.ComboBox();
            this.buttonAnadirMateriaEstudiante = new System.Windows.Forms.Button();
            this.buttonEliminarMateriaEstudiante = new System.Windows.Forms.Button();
            this.listBoxMateriasEstudiante = new System.Windows.Forms.ListBox();
            this.tabProfesor = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFacultad = new System.Windows.Forms.Label();
            this.buttonFacultadModificar = new System.Windows.Forms.Button();
            this.comboBoxFacultad = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxMateriasProfesor = new System.Windows.Forms.ComboBox();
            this.buttonMateriaAnadirProfesor = new System.Windows.Forms.Button();
            this.buttonMateriaEliminarProfesor = new System.Windows.Forms.Button();
            this.listBoxMateriasProfesor = new System.Windows.Forms.ListBox();
            this.tabAdministrativo = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDependenciaConfirmar = new System.Windows.Forms.Button();
            this.labelDependenciaMostrar = new System.Windows.Forms.Label();
            this.comboBoxDependencia = new System.Windows.Forms.ComboBox();
            this.tabServicios_Varios = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxLabores = new System.Windows.Forms.ComboBox();
            this.buttonLaborAnadir = new System.Windows.Forms.Button();
            this.buttonLaborEliminar = new System.Windows.Forms.Button();
            this.listBoxLabores = new System.Windows.Forms.ListBox();
            this.tabPersona = new System.Windows.Forms.TabPage();
            this.labelRol = new System.Windows.Forms.Label();
            this.textBoxDocumento = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelEstadoCivil = new System.Windows.Forms.Label();
            this.buttonModificarEstadoCivil = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabEstudiante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabProfesor.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabAdministrativo.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabServicios_Varios.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEstudiante);
            this.tabControl1.Controls.Add(this.tabProfesor);
            this.tabControl1.Controls.Add(this.tabAdministrativo);
            this.tabControl1.Controls.Add(this.tabServicios_Varios);
            this.tabControl1.Controls.Add(this.tabPersona);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 446);
            this.tabControl1.TabIndex = 4;
            // 
            // tabEstudiante
            // 
            this.tabEstudiante.Controls.Add(this.groupBox1);
            this.tabEstudiante.Location = new System.Drawing.Point(4, 24);
            this.tabEstudiante.Name = "tabEstudiante";
            this.tabEstudiante.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstudiante.Size = new System.Drawing.Size(662, 418);
            this.tabEstudiante.TabIndex = 0;
            this.tabEstudiante.Text = "Estudiante";
            this.tabEstudiante.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMateriasEstudiante);
            this.groupBox1.Controls.Add(this.buttonAnadirMateriaEstudiante);
            this.groupBox1.Controls.Add(this.buttonEliminarMateriaEstudiante);
            this.groupBox1.Controls.Add(this.listBoxMateriasEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 212);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materias";
            // 
            // comboBoxMateriasEstudiante
            // 
            this.comboBoxMateriasEstudiante.FormattingEnabled = true;
            this.comboBoxMateriasEstudiante.Location = new System.Drawing.Point(20, 45);
            this.comboBoxMateriasEstudiante.Name = "comboBoxMateriasEstudiante";
            this.comboBoxMateriasEstudiante.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMateriasEstudiante.TabIndex = 4;
            // 
            // buttonAnadirMateriaEstudiante
            // 
            this.buttonAnadirMateriaEstudiante.Location = new System.Drawing.Point(147, 44);
            this.buttonAnadirMateriaEstudiante.Name = "buttonAnadirMateriaEstudiante";
            this.buttonAnadirMateriaEstudiante.Size = new System.Drawing.Size(75, 23);
            this.buttonAnadirMateriaEstudiante.TabIndex = 3;
            this.buttonAnadirMateriaEstudiante.Text = "Añadir";
            this.buttonAnadirMateriaEstudiante.UseVisualStyleBackColor = true;
            this.buttonAnadirMateriaEstudiante.Click += new System.EventHandler(this.buttonAnadirMateriaEstudiante_Click);
            // 
            // buttonEliminarMateriaEstudiante
            // 
            this.buttonEliminarMateriaEstudiante.Location = new System.Drawing.Point(147, 84);
            this.buttonEliminarMateriaEstudiante.Name = "buttonEliminarMateriaEstudiante";
            this.buttonEliminarMateriaEstudiante.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarMateriaEstudiante.TabIndex = 2;
            this.buttonEliminarMateriaEstudiante.Text = "Eliminar";
            this.buttonEliminarMateriaEstudiante.UseVisualStyleBackColor = true;
            this.buttonEliminarMateriaEstudiante.Click += new System.EventHandler(this.buttonEliminarMateriaEstudiante_Click);
            // 
            // listBoxMateriasEstudiante
            // 
            this.listBoxMateriasEstudiante.FormattingEnabled = true;
            this.listBoxMateriasEstudiante.ItemHeight = 15;
            this.listBoxMateriasEstudiante.Location = new System.Drawing.Point(21, 84);
            this.listBoxMateriasEstudiante.Name = "listBoxMateriasEstudiante";
            this.listBoxMateriasEstudiante.Size = new System.Drawing.Size(120, 94);
            this.listBoxMateriasEstudiante.TabIndex = 1;
            // 
            // tabProfesor
            // 
            this.tabProfesor.Controls.Add(this.groupBox2);
            this.tabProfesor.Controls.Add(this.groupBox4);
            this.tabProfesor.Location = new System.Drawing.Point(4, 24);
            this.tabProfesor.Name = "tabProfesor";
            this.tabProfesor.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfesor.Size = new System.Drawing.Size(662, 418);
            this.tabProfesor.TabIndex = 1;
            this.tabProfesor.Text = "Profesor";
            this.tabProfesor.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFacultad);
            this.groupBox2.Controls.Add(this.buttonFacultadModificar);
            this.groupBox2.Controls.Add(this.comboBoxFacultad);
            this.groupBox2.Location = new System.Drawing.Point(331, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 178);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Facultad";
            // 
            // labelFacultad
            // 
            this.labelFacultad.AutoSize = true;
            this.labelFacultad.Location = new System.Drawing.Point(25, 134);
            this.labelFacultad.Name = "labelFacultad";
            this.labelFacultad.Size = new System.Drawing.Size(38, 15);
            this.labelFacultad.TabIndex = 2;
            this.labelFacultad.Text = "label1";
            // 
            // buttonFacultadModificar
            // 
            this.buttonFacultadModificar.Location = new System.Drawing.Point(181, 43);
            this.buttonFacultadModificar.Name = "buttonFacultadModificar";
            this.buttonFacultadModificar.Size = new System.Drawing.Size(75, 23);
            this.buttonFacultadModificar.TabIndex = 1;
            this.buttonFacultadModificar.Text = "Modificar";
            this.buttonFacultadModificar.UseVisualStyleBackColor = true;
            this.buttonFacultadModificar.Click += ButtonFacultadModificar_Click;
            // 
            // comboBoxFacultad
            // 
            this.comboBoxFacultad.FormattingEnabled = true;
            this.comboBoxFacultad.Location = new System.Drawing.Point(6, 43);
            this.comboBoxFacultad.Name = "comboBoxFacultad";
            this.comboBoxFacultad.Size = new System.Drawing.Size(121, 23);
            this.comboBoxFacultad.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBoxMateriasProfesor);
            this.groupBox4.Controls.Add(this.buttonMateriaAnadirProfesor);
            this.groupBox4.Controls.Add(this.buttonMateriaEliminarProfesor);
            this.groupBox4.Controls.Add(this.listBoxMateriasProfesor);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 212);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Materias";
            // 
            // comboBoxMateriasProfesor
            // 
            this.comboBoxMateriasProfesor.FormattingEnabled = true;
            this.comboBoxMateriasProfesor.Location = new System.Drawing.Point(21, 43);
            this.comboBoxMateriasProfesor.Name = "comboBoxMateriasProfesor";
            this.comboBoxMateriasProfesor.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMateriasProfesor.TabIndex = 4;
            // 
            // buttonMateriaAnadirProfesor
            // 
            this.buttonMateriaAnadirProfesor.Location = new System.Drawing.Point(147, 44);
            this.buttonMateriaAnadirProfesor.Name = "buttonMateriaAnadirProfesor";
            this.buttonMateriaAnadirProfesor.Size = new System.Drawing.Size(75, 23);
            this.buttonMateriaAnadirProfesor.TabIndex = 3;
            this.buttonMateriaAnadirProfesor.Text = "Añadir";
            this.buttonMateriaAnadirProfesor.UseVisualStyleBackColor = true;
            this.buttonMateriaAnadirProfesor.Click += new System.EventHandler(this.buttonMateriaAnadirProfesor_Click);
            // 
            // buttonMateriaEliminarProfesor
            // 
            this.buttonMateriaEliminarProfesor.Location = new System.Drawing.Point(147, 84);
            this.buttonMateriaEliminarProfesor.Name = "buttonMateriaEliminarProfesor";
            this.buttonMateriaEliminarProfesor.Size = new System.Drawing.Size(75, 23);
            this.buttonMateriaEliminarProfesor.TabIndex = 2;
            this.buttonMateriaEliminarProfesor.Text = "Eliminar";
            this.buttonMateriaEliminarProfesor.UseVisualStyleBackColor = true;
            this.buttonMateriaEliminarProfesor.Click += new System.EventHandler(this.buttonMateriaEliminarProfesor_Click);
            // 
            // listBoxMateriasProfesor
            // 
            this.listBoxMateriasProfesor.FormattingEnabled = true;
            this.listBoxMateriasProfesor.ItemHeight = 15;
            this.listBoxMateriasProfesor.Location = new System.Drawing.Point(21, 84);
            this.listBoxMateriasProfesor.Name = "listBoxMateriasProfesor";
            this.listBoxMateriasProfesor.Size = new System.Drawing.Size(120, 94);
            this.listBoxMateriasProfesor.TabIndex = 1;
            // 
            // tabAdministrativo
            // 
            this.tabAdministrativo.Controls.Add(this.groupBox5);
            this.tabAdministrativo.Location = new System.Drawing.Point(4, 24);
            this.tabAdministrativo.Name = "tabAdministrativo";
            this.tabAdministrativo.Size = new System.Drawing.Size(662, 418);
            this.tabAdministrativo.TabIndex = 2;
            this.tabAdministrativo.Text = "Administrativo";
            this.tabAdministrativo.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDependenciaConfirmar);
            this.groupBox5.Controls.Add(this.labelDependenciaMostrar);
            this.groupBox5.Controls.Add(this.comboBoxDependencia);
            this.groupBox5.Location = new System.Drawing.Point(31, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(331, 201);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dependencia";
            // 
            // buttonDependenciaConfirmar
            // 
            this.buttonDependenciaConfirmar.Location = new System.Drawing.Point(159, 32);
            this.buttonDependenciaConfirmar.Name = "buttonDependenciaConfirmar";
            this.buttonDependenciaConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonDependenciaConfirmar.TabIndex = 2;
            this.buttonDependenciaConfirmar.Text = "Confirmar";
            this.buttonDependenciaConfirmar.UseVisualStyleBackColor = true;
            this.buttonDependenciaConfirmar.Click += new System.EventHandler(this.buttonDependenciaConfirmar_Click);
            // 
            // labelDependenciaMostrar
            // 
            this.labelDependenciaMostrar.AutoSize = true;
            this.labelDependenciaMostrar.Location = new System.Drawing.Point(6, 156);
            this.labelDependenciaMostrar.Name = "labelDependenciaMostrar";
            this.labelDependenciaMostrar.Size = new System.Drawing.Size(38, 15);
            this.labelDependenciaMostrar.TabIndex = 1;
            this.labelDependenciaMostrar.Text = "label1";
            // 
            // comboBoxDependencia
            // 
            this.comboBoxDependencia.FormattingEnabled = true;
            this.comboBoxDependencia.Location = new System.Drawing.Point(6, 32);
            this.comboBoxDependencia.Name = "comboBoxDependencia";
            this.comboBoxDependencia.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDependencia.TabIndex = 0;
            // 
            // tabServicios_Varios
            // 
            this.tabServicios_Varios.Controls.Add(this.groupBox6);
            this.tabServicios_Varios.Location = new System.Drawing.Point(4, 24);
            this.tabServicios_Varios.Name = "tabServicios_Varios";
            this.tabServicios_Varios.Size = new System.Drawing.Size(662, 418);
            this.tabServicios_Varios.TabIndex = 3;
            this.tabServicios_Varios.Text = "Servicios Varios";
            this.tabServicios_Varios.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxLabores);
            this.groupBox6.Controls.Add(this.buttonLaborAnadir);
            this.groupBox6.Controls.Add(this.buttonLaborEliminar);
            this.groupBox6.Controls.Add(this.listBoxLabores);
            this.groupBox6.Location = new System.Drawing.Point(8, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(317, 212);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Labores";
            // 
            // comboBoxLabores
            // 
            this.comboBoxLabores.FormattingEnabled = true;
            this.comboBoxLabores.Location = new System.Drawing.Point(20, 44);
            this.comboBoxLabores.Name = "comboBoxLabores";
            this.comboBoxLabores.Size = new System.Drawing.Size(121, 23);
            this.comboBoxLabores.TabIndex = 4;
            // 
            // buttonLaborAnadir
            // 
            this.buttonLaborAnadir.Location = new System.Drawing.Point(147, 44);
            this.buttonLaborAnadir.Name = "buttonLaborAnadir";
            this.buttonLaborAnadir.Size = new System.Drawing.Size(75, 23);
            this.buttonLaborAnadir.TabIndex = 3;
            this.buttonLaborAnadir.Text = "Añadir";
            this.buttonLaborAnadir.UseVisualStyleBackColor = true;
            // 
            // buttonLaborEliminar
            // 
            this.buttonLaborEliminar.Location = new System.Drawing.Point(147, 84);
            this.buttonLaborEliminar.Name = "buttonLaborEliminar";
            this.buttonLaborEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonLaborEliminar.TabIndex = 2;
            this.buttonLaborEliminar.Text = "Eliminar";
            this.buttonLaborEliminar.UseVisualStyleBackColor = true;
            // 
            // listBoxLabores
            // 
            this.listBoxLabores.FormattingEnabled = true;
            this.listBoxLabores.ItemHeight = 15;
            this.listBoxLabores.Location = new System.Drawing.Point(21, 84);
            this.listBoxLabores.Name = "listBoxLabores";
            this.listBoxLabores.Size = new System.Drawing.Size(120, 94);
            this.listBoxLabores.TabIndex = 1;
            // 
            // tabPersona
            // 
            this.tabPersona.Controls.Add(this.buttonModificarEstadoCivil);
            this.tabPersona.Controls.Add(this.labelEstadoCivil);
            this.tabPersona.Controls.Add(this.labelRol);
            this.tabPersona.Controls.Add(this.textBoxDocumento);
            this.tabPersona.Controls.Add(this.textBoxApellidos);
            this.tabPersona.Controls.Add(this.textBoxNombre);
            this.tabPersona.Controls.Add(this.comboBoxEstadoCivil);
            this.tabPersona.Controls.Add(this.label4);
            this.tabPersona.Controls.Add(this.label2);
            this.tabPersona.Controls.Add(this.label3);
            this.tabPersona.Controls.Add(this.label5);
            this.tabPersona.Controls.Add(this.label6);
            this.tabPersona.Location = new System.Drawing.Point(4, 24);
            this.tabPersona.Name = "tabPersona";
            this.tabPersona.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersona.Size = new System.Drawing.Size(662, 418);
            this.tabPersona.TabIndex = 4;
            this.tabPersona.Text = "Perfil Persona";
            this.tabPersona.UseVisualStyleBackColor = true;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Location = new System.Drawing.Point(138, 303);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(38, 15);
            this.labelRol.TabIndex = 23;
            this.labelRol.Text = "label1";
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(138, 178);
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(225, 23);
            this.textBoxDocumento.TabIndex = 22;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(138, 126);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(225, 23);
            this.textBoxApellidos.TabIndex = 21;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(138, 71);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(225, 23);
            this.textBoxNombre.TabIndex = 20;
            // 
            // comboBoxEstadoCivil
            // 
            this.comboBoxEstadoCivil.FormattingEnabled = true;
            this.comboBoxEstadoCivil.Location = new System.Drawing.Point(242, 225);
            this.comboBoxEstadoCivil.Name = "comboBoxEstadoCivil";
            this.comboBoxEstadoCivil.Size = new System.Drawing.Size(121, 23);
            this.comboBoxEstadoCivil.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado Civil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Rol";
            // 
            // labelEstadoCivil
            // 
            this.labelEstadoCivil.AutoSize = true;
            this.labelEstadoCivil.Location = new System.Drawing.Point(138, 233);
            this.labelEstadoCivil.Name = "labelEstadoCivil";
            this.labelEstadoCivil.Size = new System.Drawing.Size(38, 15);
            this.labelEstadoCivil.TabIndex = 24;
            this.labelEstadoCivil.Text = "label1";
            // 
            // buttonModificarEstadoCivil
            // 
            this.buttonModificarEstadoCivil.Location = new System.Drawing.Point(288, 254);
            this.buttonModificarEstadoCivil.Name = "buttonModificarEstadoCivil";
            this.buttonModificarEstadoCivil.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarEstadoCivil.TabIndex = 25;
            this.buttonModificarEstadoCivil.Text = "Modificar";
            this.buttonModificarEstadoCivil.UseVisualStyleBackColor = true;
            this.buttonModificarEstadoCivil.Click += ButtonModificarEstadoCivil_Click;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEstudiante.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabProfesor.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tabAdministrativo.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabServicios_Varios.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPersona.ResumeLayout(false);
            this.tabPersona.PerformLayout();
            this.ResumeLayout(false);

        }




        #endregion
        private TabControl tabControl1;
        private TabPage tabEstudiante;
        private TabPage tabProfesor;
        private TabPage tabAdministrativo;
        private TabPage tabServicios_Varios;
        private GroupBox groupBox1;
        private Button buttonAnadirMateriaEstudiante;
        private Button buttonEliminarMateriaEstudiante;
        private ListBox listBoxMateriasEstudiante;
        private GroupBox groupBox2;
        private Label labelFacultad;
        private Button buttonFacultadModificar;
        private ComboBox comboBoxFacultad;
        private GroupBox groupBox4;
        private Button buttonMateriaAnadirProfesor;
        private Button buttonMateriaEliminarProfesor;
        private ListBox listBoxMateriasProfesor;
        private GroupBox groupBox5;
        private Button buttonDependenciaConfirmar;
        private Label labelDependenciaMostrar;
        private ComboBox comboBoxDependencia;
        private GroupBox groupBox6;
        private Button buttonLaborAnadir;
        private Button buttonLaborEliminar;
        private ListBox listBoxLabores;
        private ComboBox comboBoxLabores;
        private ComboBox comboBoxMateriasEstudiante;
        private ComboBox comboBoxMateriasProfesor;
        private TabPage tabPersona;
        private Label labelRol;
        private TextBox textBoxDocumento;
        private TextBox textBoxApellidos;
        private TextBox textBoxNombre;
        private ComboBox comboBoxEstadoCivil;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Button buttonModificarEstadoCivil;
        private Label labelEstadoCivil;
    }
}