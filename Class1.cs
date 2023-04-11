using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insititucion_Educativa
{
    public class Datos 
    {
        public List<Persona> ListaPersonas = new List<Persona>();

        public List<EstadoCivil> ListaEstadoCivil = new List<EstadoCivil>();

        public List<string> listaRol = new List<string>();

        public List<Empleado> ListaEmpleado = new List<Empleado>();

        public List<Administrativo> ListaAdministrativo = new List<Administrativo>();

        public List<Profesor> ListaProfesor = new List<Profesor>();

        public List<Estudiante> ListaEstudiante = new List<Estudiante>();

        public List<Servicios_Varios> ListaServicios = new List<Servicios_Varios>();

        public List<Curso> ListaCursos = new List<Curso>();

        public List<Dependencia_Institucion> ListaDependencias = new List<Dependencia_Institucion>();

        public List<Facultad_Institucion> ListaFacultades = new List<Facultad_Institucion>();

        public List<Labor> ListaLabores = new List<Labor>();

        
    }

    public class Persona
    {
        public string Nombres;
        public string Apellidos;
        public int Documento;
        EstadoCivil Estado;

        public Persona(string nombres, string apellidos, int documento, EstadoCivil estado_civil) 
        {
            this.Nombres = nombres;
            this.Apellidos = apellidos;
            this.Documento = documento;
            this.Estado = estado_civil;
        }

        public Persona() 
        {
            Nombres = "Vacío";
            Apellidos = "Vacío";
            Documento = 0;
            Estado = new EstadoCivil("Vacío", 0);
        }

        void Cambio_Estado_Civil(EstadoCivil nuevo_estado) 
        {
            this.Estado = nuevo_estado;
        }

    }


    public class Empleado:Persona
    {
        public DateOnly Fecha_Registro;


        public Empleado(int documento) 
        {
            Documento = documento;
            Fecha_Registro = DateOnly.Parse(DateTime.Now.ToString());
        }

        public Empleado()
        {
            
            Fecha_Registro = DateOnly.Parse(DateTime.Now.ToString());
        }

    }

    public class EstadoCivil 
    {
        public string Estado;
        public int IDestado;

       internal EstadoCivil(string estado, int id) 
        {
            this.Estado = estado;
            this.IDestado = id;
        }
    }
    public class Dependencia_Institucion
    {
        public string Nombre_Dependencia;

        public Dependencia_Institucion(string nombre) 
        {
            Nombre_Dependencia = nombre;
        }
        public Dependencia_Institucion()
        {
            Nombre_Dependencia = "Vacío";
        }
    }

    public class Facultad_Institucion : Dependencia_Institucion
    {
        public string Nombre_Facultad;

       internal Facultad_Institucion(string titulo) 
        {
            Nombre_Facultad = titulo;
        }

        public Facultad_Institucion() 
        {
            Nombre_Facultad = "Vacío";
        }

    }

    public class Labor 
    {
        public string Nombre_Labor;
        public int IDlabor;

        internal Labor(string nombre_Labor,int id)
        {
            Nombre_Labor = nombre_Labor;
            IDlabor = id;
        }
        Labor() 
        {
            Nombre_Labor = "Vacío";
            IDlabor = 0;
        }
    }

    public class Administrativo : Empleado
    {
        public Dependencia_Institucion Dependencia;

        void Cambio_Dependencia(Dependencia_Institucion nueva_dependencia)
        {
            this.Dependencia = nueva_dependencia;

        }
        internal Administrativo(int documento, Dependencia_Institucion dependencia) 
        {
            Documento = this.Documento  = documento;
            Dependencia = dependencia;
        }


    }

    public class Profesor : Empleado 
    {
        public Facultad_Institucion Facultad;
        public Profesor(int documento, Facultad_Institucion facultad)
        {
            Documento = documento;
            Facultad = facultad;
            List<Curso> Cursos_Dictados = new List<Curso>();
        }

        void Cambio_Facultad (Facultad_Institucion nueva_facultad)
        {
            this.Facultad = nueva_facultad;

        }
        

    }

    public class Servicios_Varios : Empleado
    {
        

        public Dependencia_Institucion Dependencia;
        List<Labor> Labores_Actuales = new List<Labor>();
        internal Servicios_Varios(Dependencia_Institucion dependencia, int documento)
        {
            Documento = documento;
            Dependencia = dependencia;
        }

        void Limpiar_Labores() 
        {
            Labores_Actuales.Clear();
        }

        void Anadir_Labores(Labor nueva_labor) 
        {
            Labores_Actuales.Add(nueva_labor);
        }


    }

    public class Estudiante : Persona 
    {
        List<Curso> Cursos_Actuales = new List<Curso>();
        internal Estudiante(int documento) 
        {
            Documento = documento;
        }
       
        void Anadir_Curso(Curso nuevo_curso) 
        {
            Cursos_Actuales.Add(nuevo_curso);
        }
    }

    public class Curso 
    {
        public int Codigo_Curso;
        public string Nombre_Curso;
        public Facultad_Institucion Facultad;

        internal Curso(int codigo_Curso, string nombre_Curso, Facultad_Institucion facultad)
        {
            Codigo_Curso = codigo_Curso;
            Nombre_Curso = nombre_Curso;
            Facultad = facultad;
        }
        internal Curso() 
        {
            Codigo_Curso = 0;
            Nombre_Curso = "Vacío";
            Facultad = new Facultad_Institucion();
        }
    }



  //public public Public Protected



}
