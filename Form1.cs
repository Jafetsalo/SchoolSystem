using System.Text.Json;

namespace Insititucion_Educativa
{

    public partial class Form1 : Form
    {

        //Crear lista entidades: Dependencia Facultad Labor Curso
        static public List<Persona> ListaPersonas = new List<Persona>();

        static public List<EstadoCivil> ListaEstadoCivil = new List<EstadoCivil>();

        static public List<string> listaRol = new List<string>();

        static public List<Empleado> ListaEmpleado = new List<Empleado>();

        static public List<Administrativo> ListaAdministrativo = new List<Administrativo>();

        static public List<Profesor> ListaProfesor = new List<Profesor>();

        static public List<Estudiante> ListaEstudiante = new List<Estudiante>();

        static public List<Servicios_Varios> ListaEmpleadoServicios = new List<Servicios_Varios>();

        static public List<Curso> ListaCursos = new List<Curso>();

        static public List<Dependencia_Institucion> ListaDependencias = new List<Dependencia_Institucion>();

        static public List<Facultad_Institucion> ListaFacultades = new List<Facultad_Institucion>();

        static public List<Labor> ListaLabores = new List<Labor>();

        static public Persona? PersonaSeleccionada = null;
        static public Administrativo? AdministrativoSeleccionado = null;
        static public Estudiante? EstudianteSeleccionado = null;
        static public Profesor? ProfesorSeleccionado = null;
        static public Servicios_Varios? ServiciosVariosSeleccionado = null;


        public Form1()
        {

            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            populateLists();

            foreach (EstadoCivil estado in ListaEstadoCivil)
            {
                comboBoxEstadoCivil.Items.Add(estado.Nombre_Estado.ToString());
            }

            foreach (string Rol in listaRol) 
            {
                comboBoxRol.Items.Add(Rol);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string prueba = $"{comboBoxPersonas.SelectedItem.ToString()}";

            }
            catch
            {
                MessageBox.Show("Ninguna persona ha sido seleccionado para MODIFICAR", "Seleccionar una Persona", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form2 form2 = new Form2();
            form2.ShowDialog();


        }

        private void ButtonEliminarPersona_Click(object sender, EventArgs e) 
        {
            try
            {

                string prueba = $"{comboBoxPersonas.SelectedItem.ToString()}";

            }
            catch
            {
                MessageBox.Show("Ninguna persona ha sido seleccionado para ELIMINAR", "Seleccionar una Persona", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Persona persona in ListaPersonas)
            {
                if (comboBoxPersonas.SelectedItem.ToString() == persona.Documento.ToString()) 
                {
                    MessageBox.Show($"Se va eliminó a: {persona.Nombres.ToString()} con cédula {persona.Documento}", "Eliminación en curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListaPersonas.Remove(persona);

                    comboBoxPersonasRefresh();
                    return;
                }
            }


        }

        private void buttonCreatePerson_Click(object sender, EventArgs e)
        {
            int documento = 0;

            if (comboBoxRol.SelectedItem == null)
            {
                MessageBox.Show("Debe Seleccionar un Rol o la opción 'Sin rol Asignado' en caso de no disponer de uno", "Seleccione un Rol", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            EstadoCivil estadoSeleccionado = new EstadoCivil("Vacío",0);
            try
            {

                string prueba = $"{comboBoxEstadoCivil.SelectedItem.ToString()}";

            }
            catch 
            {
                MessageBox.Show("El estado civil no ha sido seleccionado", "Seleccionar un Estado Civil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            foreach (Persona persona in ListaPersonas)
                {
                    if (textBoxDocumento.Text == persona.Documento.ToString())
                    {
                        MessageBox.Show($"Ya existe una persona con el documento {persona.Documento}", "Documento ya existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            
            
            foreach (EstadoCivil estado in ListaEstadoCivil) 
            {
                if (estado.Nombre_Estado == comboBoxEstadoCivil.SelectedItem.ToString()) 
                {
                    estadoSeleccionado = estado;
                }
            }
            

            try
            {
                documento = Convert.ToInt32(textBoxDocumento.Text.ToString());
                string nombre = textBoxNombres.Text.ToString();
                string apellido = textBoxApellidos.Text.ToString();

                createPersona(nombre, apellido, documento, estadoSeleccionado);
                
            }
            catch 
            {
                MessageBox.Show("El documento ingresado no tiene el formato adecuado", "Solo numeros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            comboBoxPersonasRefresh();

            //if role is selected we can create appropiate instances of clases
            //Debemos encontrar como enlazar persona y el rol que se crea.
            //Estoy pensando en añadir ID en todas entidades que heredan de persona
            //o colocar persona como componente de entidades, pero eso arruina herencia
            //Tenemos persona, estudiante, administrativo, empleado, servicios varios y profesor
            //La solución fue crear las entidades y sus listas con documento, así solo corremos búsqueda y listo




            if (comboBoxRol.Text.ToString() == "Sin rol Asignado")
            {
                //Usuario desea crear persona
                MessageBox.Show($"Se creó Persona sin Rol");
            }
            else
            {
                //Usuario elige rol y debemos así crearlo
                string RolSeleccionado = comboBoxRol.Text.ToString();
                if (RolSeleccionado == "Empleado")
                {
                    ListaEmpleado.Add(new Empleado(documento));

                }

                if (RolSeleccionado == "Administrativo")
                {
                    ListaAdministrativo.Add(new Administrativo(documento, new Dependencia_Institucion()));
                }
                if (RolSeleccionado == "Estudiante")
                {
                    ListaEstudiante.Add(new Estudiante(documento));
                }
                if (RolSeleccionado == "Profesor") 
                {
                    ListaProfesor.Add(new Profesor(documento, new Facultad_Institucion()));
                }
                if (RolSeleccionado == "Servicios varios") 
                {
                    ListaEmpleadoServicios.Add(new Servicios_Varios(new Dependencia_Institucion(),documento));
                }

                MessageBox.Show($"El rol elegido es : {RolSeleccionado}");

            }


        }

        private void comboBoxEstadoCivil_SelectionChangeCommitted(object sender, EventArgs e)
        {
           //empty eventhandler 
        }

        private void comboBoxPersonas_SelectedIndexChanged(object sender, EventArgs e) 
        {
            foreach (Persona persona in ListaPersonas)
            {
                if (comboBoxPersonas.SelectedItem.ToString() == persona.Documento.ToString())
                {
                    PersonaSeleccionada = persona;
                    MessageBox.Show($"Ha seleccionado a {persona.Nombres} con Documento {persona.Documento} ", "Persona seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }
        }

        public void comboBoxPersonasRefresh() 
        {
            comboBoxPersonas.Items.Clear();

            foreach (Persona p in ListaPersonas)
            {
                comboBoxPersonas.Items.Add(p.Documento);
            }

            comboBoxPersonas.Text = "Vacío";
        }

        public void createPersona(string nombre, string apellido, int documento, EstadoCivil estadoSeleccionado) 
        {
            Persona persona = new Persona(nombre, apellido, documento, estadoSeleccionado);
            ListaPersonas.Add(persona);
            MessageBox.Show($"Persona creada correctamente | Nombre {persona.Nombres} | Apellido {persona.Apellidos} " +
                $"| Documento {persona.Documento}, Estado Civil {estadoSeleccionado.Nombre_Estado} ");
        }
        public void populateLists() 
        {
            //In the future we could populate from a popular database system such as SQLServer

            ListaLabores.Add(new Labor("Limpieza", 0));
            ListaLabores.Add(new Labor("Mantenimiento locativo", 1));
            ListaLabores.Add(new Labor("Soporte técnico", 2));
            ListaLabores.Add(new Labor("Compras y adquisiciones", 3));
            ListaLabores.Add(new Labor("Seguridad", 4));


            ListaEstadoCivil.Add(new EstadoCivil("Soltero/a", 1));
            ListaEstadoCivil.Add(new EstadoCivil("Casado/a", 2));
            ListaEstadoCivil.Add(new EstadoCivil("Union Libre", 3));
            ListaEstadoCivil.Add(new EstadoCivil("Viudo/a", 4));
            ListaEstadoCivil.Add(new EstadoCivil("No registra", 5));

            ListaFacultades.Add(new Facultad_Institucion("Ciencias Humanas")); ListaFacultades.Add(new Facultad_Institucion("Ingenierías"));
            ListaFacultades.Add(new Facultad_Institucion("Diseño y Arte"));

            ListaCursos.Add(new Curso(1, "Matemáticas Operativas", ListaFacultades.ElementAt(1)));
            ListaCursos.Add(new Curso(2, "Calculo", ListaFacultades.ElementAt(1)));
            ListaCursos.Add(new Curso(3, "Lengua Materna", ListaFacultades.ElementAt(0)));
            ListaCursos.Add(new Curso(4, "Lenguas Modernas", ListaFacultades.ElementAt(0)));
            ListaCursos.Add(new Curso(5, "Desarrollo Humano", ListaFacultades.ElementAt(0)));
            ListaCursos.Add(new Curso(6, "Historia Contemporánea", ListaFacultades.ElementAt(0)));
            ListaCursos.Add(new Curso(7, "Circuitos Electrónicos", ListaFacultades.ElementAt(1)));
            ListaCursos.Add(new Curso(8, "Dibujo Técnico", ListaFacultades.ElementAt(2)));

            ListaDependencias.Add(new Dependencia_Institucion("Financiera"));
            ListaDependencias.Add(new Dependencia_Institucion("Extensión"));
            ListaDependencias.Add(new Dependencia_Institucion("Deportiva"));
            ListaDependencias.Add(new Dependencia_Institucion("Académica"));

            listaRol.Add("Empleado"); listaRol.Add("Administrativo"); listaRol.Add("Profesor");
            listaRol.Add("Servicios varios"); listaRol.Add("Estudiante"); listaRol.Add("Sin rol Asignado");
        }


    }
}