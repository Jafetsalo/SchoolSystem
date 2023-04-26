﻿using System.Windows.Forms;

namespace Insititucion_Educativa
{
    public partial class Form2 : Form
    {
        //Crear lista entidades: Dependencia Facultad Labor Curso
        //
        string RolSeleccionado = "";
        public Form2()
        {



            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {


            RolSeleccionado = busquedaRolPersona(Form1.PersonaSeleccionada);
            clearForm();
            populateComboBox();
            populateListBox();
            populateLabel();
            
        }

        private void clearForm() 
        {
            comboBoxLabores.Items.Clear();
            comboBoxDependencia.Items.Clear();
            comboBoxFacultad.Items.Clear();
            comboBoxLabores.Items.Clear();
            comboBoxMateriasEstudiante.Items.Clear();
            comboBoxMateriasProfesor.Items.Clear();
            listBoxLabores.Items.Clear();
            listBoxMateriasEstudiante.Items.Clear();
            listBoxMateriasProfesor.Items.Clear();
            labelDependenciaMostrar.Text = "No asignado";
            labelFacultad.Text = "No asignado";
        }

        private void populateComboBox()
        {


            foreach (Labor labor in Form1.ListaLabores)
            {
                comboBoxLabores.Items.Add(labor.Nombre_Labor.ToString());
            }

            foreach (Dependencia_Institucion dependencia_ in Form1.ListaDependencias)
            {
                comboBoxDependencia.Items.Add(dependencia_.Nombre_Dependencia.ToString());
            }

            foreach (Curso curso in Form1.ListaCursos)
            {
                comboBoxMateriasEstudiante.Items.Add(curso.Nombre_Curso.ToString());
                comboBoxMateriasProfesor.Items.Add(curso.Nombre_Curso.ToString());
            }


            foreach (Facultad_Institucion facultad in Form1.ListaFacultades)
            {
                comboBoxFacultad.Items.Add(facultad.Nombre_Facultad.ToString());
            }
        }

        private void populateListBox() 
        {



            if (RolSeleccionado == "Estudiante") 
            {
                Estudiante estudiante = Form1.EstudianteSeleccionado;

                foreach (Curso curso in estudiante.Cursos_Actuales)
                {
                    listBoxMateriasEstudiante.Items.Add(curso.Nombre_Curso);
                }
            }

            if (RolSeleccionado == "Profesor")
            {

                Profesor profesor = Form1.ProfesorSeleccionado;
                foreach (Curso curso in profesor.Cursos_Dictados)
                {
                    listBoxMateriasProfesor.Items.Add(curso.Nombre_Curso);
                }

            }

            if (RolSeleccionado == "Servicios varios") 
            {
                Servicios_Varios servicios_Varios = Form1.ServiciosVariosSeleccionado;
                foreach (Labor labor in servicios_Varios.Labores_Actuales)
                {
                    listBoxLabores.Items.Add(labor.Nombre_Labor);
                }

            }
        }

        private void populateLabel() 
        {
            if (RolSeleccionado == "Administrativo")
            {
                Administrativo administrativo = Form1.AdministrativoSeleccionado;

                foreach (Dependencia_Institucion dependencia in Form1.ListaDependencias)
                {
                    if (administrativo.Dependencia == dependencia)
                    {
                        labelDependenciaMostrar.Text = dependencia.Nombre_Dependencia;
                    }

                }
            }


            if (RolSeleccionado == "Profesor") 
            {

                Profesor profesor = Form1.ProfesorSeleccionado;

                foreach (Facultad_Institucion facultad in Form1.ListaFacultades)
                {
                    if (profesor.Facultad == facultad)
                    {
                        labelFacultad.Text = facultad.Nombre_Facultad;
                    }

                }
            }

        }

        private string busquedaRolPersona(Persona? personaSeleccionada) 
        {

            if (personaSeleccionada != null) 
            { int documentoRef = personaSeleccionada.Documento;

                foreach (Empleado empleado in Form1.ListaEmpleado)
                {
                    if (documentoRef == empleado.Documento)
                    {
                        RolSeleccionado = "Empleado";
                    }

                }

                foreach (Administrativo administrativo in Form1.ListaAdministrativo)
                {
                    if (documentoRef == administrativo.Documento)
                    {
                        RolSeleccionado = "Administrativo";
                        Form1.AdministrativoSeleccionado = administrativo;
                        hideTabMenus(2, false, false, true, false);
                    }

                }

                foreach (Estudiante estudiante in Form1.ListaEstudiante)
                {
                    if (documentoRef == estudiante.Documento)
                    {
                        RolSeleccionado = "Estudiante";
                        Form1.EstudianteSeleccionado = estudiante;
                        hideTabMenus(0, true, false, false, false);
                    }
                }

                foreach (Profesor profesor in Form1.ListaProfesor)
                {
                    if (documentoRef == profesor.Documento)
                    {
                        RolSeleccionado = "Profesor";
                        Form1.ProfesorSeleccionado = profesor;
                        hideTabMenus(1, false, true, false, false);
                    }
                }

                foreach (Servicios_Varios servicios_Varios in Form1.ListaEmpleadoServicios)
                {
                    if (documentoRef == servicios_Varios.Documento)
                    {
                        RolSeleccionado = "Servicios varios";
                        Form1.ServiciosVariosSeleccionado = servicios_Varios;
                        hideTabMenus(3, false, false, false, true);
                    }
                }
            }
            

            if (RolSeleccionado != "") { MessageBox.Show($"El rol de la persona seleccionada {personaSeleccionada.Nombres} es: {RolSeleccionado}"); }
            else { MessageBox.Show($"La persona {personaSeleccionada.Nombres} no tiene rol {RolSeleccionado}"); }
                

            return RolSeleccionado;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void hideTabMenus(int selectedTab, bool firstTab, bool secondTab, bool thirdTab, bool fourthTab) 
        {
            tabControl1.SelectedIndex = selectedTab;
            tabControl1.Enabled = true;
            tabControl1.TabPages[0].Enabled = firstTab;
            tabControl1.TabPages[1].Enabled = secondTab;
            tabControl1.TabPages[2].Enabled = thirdTab;
            tabControl1.TabPages[3].Enabled = fourthTab;
        }

        private void buttonAnadirMateriaEstudiante_Click(object sender, EventArgs e)
        {
            if (RolSeleccionado == "Estudiante")
            {
                try
                {
                    Curso Agregar = Form1.ListaCursos.ElementAt(comboBoxMateriasEstudiante.SelectedIndex);
                   
                    foreach (Curso curso in Form1.EstudianteSeleccionado.Cursos_Actuales) 
                    {
                        if (curso == Agregar) 
                        {
                            MessageBox.Show($"Curso {curso.Nombre_Curso} ya estaba asignado a Estudiante {Form1.PersonaSeleccionada.Nombres}","Curso asignado",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            return;
                        }
                    }
                    
                    Form1.EstudianteSeleccionado.Cursos_Actuales.Add(Agregar);
                    clearForm();
                    populateComboBox();
                    populateListBox();
                    populateLabel();
                }
                catch
                {
                    MessageBox.Show("No ha elegido curso. Por favor seleccione un curso a continuación", "Seleccione un curso", MessageBoxButtons.OK);
                }
            }
            //Do a check, to find out if this is actually a student
            //Add to local student
            //Find reference to student in form1 list
            //modify in that list the actual student
        }

        private void buttonEliminarMateriaEstudiante_Click(object sender, EventArgs e)
        {
            if (RolSeleccionado == "Estudiante")
            {
                try
                {
                    listBoxMateriasEstudiante.SelectedItem.ToString();

                    Curso Eliminar;

                    foreach (Curso curso in Form1.EstudianteSeleccionado.Cursos_Actuales)
                    {
                        if (curso.Nombre_Curso == listBoxMateriasEstudiante.SelectedItem.ToString())
                        {
                            Eliminar = curso;
                            Form1.EstudianteSeleccionado.Cursos_Actuales.Remove(Eliminar);
                            clearForm();
                            populateComboBox();
                            populateListBox();
                            populateLabel();
                            return;
                        }
                    }

                }
                catch
                {
                  MessageBox.Show("No ha elegido curso a eliminar. Por favor seleccione un curso a continuación", "Seleccione un curso", MessageBoxButtons.OK);
                }


            }
        }
    }

    /*
   Elaborar un proyecto de software en un IDE de su elección que gestione la información de las personas vinculadas a una institución educativa, 
    las cuales se pueden clasificar de la siguiente forma: estudiantes, profesores, administrativos, servicios varios.

Se detalla a continuación la información que debe gestionar:

Por cada persona, se debe conocer su nombre y apellidos, número de identificación y su estado civil.
Para todos los empleados, almacenar su año de incorporación a la institución.
El personal administrativo debe registrar la dependencia a la cual pertenece.
Para los profesores, registrar la facultad a la que pertenecen
En cuanto a los estudiantes, se requiere almacenar el curso en el que están matriculados.
El personal de servicios varios, registrar su labor específica.
En el aplicativo se debe evidenciar jerarquía de clases y polimorfismo.

Elaborar métodos en las clases correspondientes que para un número de identificación específico permitan:

Cambio del estado civil de una persona.
Matrícula de un estudiante en un nuevo curso.
Cambio de facultad de un profesor.
Modificación de la labor de un empleado de servicios varios.
Modificar la dependencia a la que pertenece el personal administrativo.
     */

}
