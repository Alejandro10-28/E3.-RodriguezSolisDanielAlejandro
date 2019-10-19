using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListE3
{
    public class Principal:Tarea
    {
        //Se declaran instancia global ya que se utilizaran en los diferentes metodos.
        Profesor Us;
        Alumno UsA;
        Usuario Mu = new Usuario();
        //Se crea el menu Bienvenida para que el usuario
        public void Bienvenida()
        {
            Console.WriteLine("=====Bienvenido A ToDoLIST=========");
            Console.WriteLine("Programa con el proposito de que profesores puedan agendar tareas para sus alumnos.");
            Inicio();
            Console.ReadKey();

        }
        //Se crea el Menu que sera el cual se llamara en dado caso el usuario sea un profesor ya que este podra utilizar
        //otras opciones que el alumno no podra usar.
        public void Menu(Profesor Us)
        {
            Console.WriteLine("Bienvenido profesor/a:" + Us.Nombrep);

            Console.WriteLine(">>Elija una opción\n1-.Crear tarea\n2-.Lista de tareas\n3-.Buscar tarea\n4-.Lista de status\n5-Cambiar status\n6-.Regresar al inicio");
            switch (Console.ReadLine())
            {
                case "1":
                    CrearTareas();
                    break;
                case "2":
                    ListaDeTareas();
                    break;
                case "3":
                    Tareas();
                    break;

                case "4":
                    Estado();
                    break;
                case "5":
                    CambiarEstado();
                    break;
                case "6":
                    Inicio();
                    break;
                default:
                    Console.WriteLine("NO SE ENCONTRO LA OPCION\n INTENTE DENUEVO");
                    Console.ReadKey();
                    Console.Clear();
                    break;




            }
            Console.Clear();
            //Se manda como parametro us para que siga utilizando el mismo usuario con el que inicio sesion.
            Menu(Us);

          
        }
        //El metodo Inicio es el que se presentara primero para que el usuario pueda elegir como iniciar su 
        //sesion ya sea profesor o alumno.
        private void Inicio()
        {
            Console.WriteLine("=====Inicio de sesión======");
            Console.WriteLine(">>Escoja su inicio:\n1-.Profesor\n2-.Alumno");
            switch (Console.ReadLine())
            {
                case "1":
                    ObtenerDatosProfesor();

                    break;
                case "2":
                    ObtenerDatosAlumno();
                    break;
                default: 
                    Console.WriteLine("OPCION NO VALIDA");
                    break;


            }
            Inicio();
        }
        //El metodo MenuA es el correspondiente al que el alumno tendra acceso donde solo se le permitira observar
        //las tareas agregas por el profesor.
        public void MenuA(Alumno A)
        {
            Console.WriteLine("Bienvenido alumno/a:"+A.NombreA);
            Console.WriteLine("Escoja una opción:\n1-.Lista de tareas\n2-.Buscar tareas\n3-.Lista de estados\n4-.Regresar al inicio");
            switch (Console.ReadLine())
            {
                case "1":
                    ListaDeTareas();
                    break;
                case "2":
                    Tareas();
                    break;
                case "3":
                    Estado();
                    break;
                case "4":
                    Inicio();
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDA");
                    break;
            }
            Console.Clear();
            //Se manda como parametro us para que siga utilizando el mismo usuario con el que inicio sesion.

            MenuA(A);
        }
        //El metodo obtenerDatosProfesor sirve para identificar el NoControl ingresado por el usuario
        //que sea correspondiente alos ya predeterminado en la lista profesores.
        private void ObtenerDatosProfesor()
        {
            //R solo es para guardar el NoControl ingresado en el metodo Datos
            int R = Datos();
            //Se crea una variable de tipo var para guardar Mu.Profesor debido a que
            // es la instancia de la clase usuario en esta clase recordemos que existen 
            //2 metodos de tipo lista una para profesores que es la que nos interesa en esta ocasion.
            var lisP = Mu.profesores();
            Us = new Profesor();
            //Se crea el forech para pasar los objetos existentes en lisp 
            foreach (var Profesor in lisP)
            {
                //Se hace el if para que caso el NoControl ingresado por el usuario
                //Corresponda a alguno de los ya predeterminados de la lista profesor
                //se iniciara la sesion con los datos correspondientes al profesor.
                if (R == Profesor.NoControl)
                {
                    Us = Profesor;
                }
            }
            //Se llama al menu que el profesor manejara y se manda como parametro Us el cual 
            //ya contiene los datos guardados del objeto con el que coincidio el NoControl ingresado por el 
            //Usuario.
            Menu(Us);
        }
        //El metodo obtenerDatosAlumno sirve para identificar el NoControl ingresado por el usuario
        //que sea correspondiente alos ya predeterminado en la lista Alumnos.
        private void ObtenerDatosAlumno()
        {
            //R solo es para guardar el NoControl ingresado en el metodo Datos

            int R = Datos();
            //Se crea una variable de tipo var para guardar Mu.Profesor debido a que
            // es la instancia de la clase usuario en esta clase recordemos que existen 
            //2 metodos de tipo lista una para profesores que es la que nos interesa en esta ocasion.
            var lisA = Mu.Alumnos();

            UsA = new Alumno();
            //Se crea el forech para pasar los objetos existentes en lisA

            foreach (var Alumno in lisA)
            {
                //Se hace el if para que caso el NoControl ingresado por el usuario
                //Corresponda a alguno de los ya predeterminados de la lista Alumno
                //se iniciara la sesion con los datos correspondientes al Alumno.
                if (R == Alumno.NoControlA)
                {
                    UsA = Alumno;
                }
            }
            //Se llama al menu que el alumno manejara y se manda como parametro UsA el cual 
            //ya contiene los datos guardados del objeto con el que coincidio el NoControl ingresado por el 
            //Usuario.
            MenuA(UsA);
        }
        //Datos se usa para pedirle al usuario el No.Control para iniciar la sesion respectiva a si es alumno o profesor
        private int Datos()
        {

            Console.WriteLine("Ingrese su No.Control:");
            string NC = Console.ReadLine();
            //Se retorna convertida de tipo int debido a que el No.control esta declarada de tipo int
            return Convert.ToInt32(NC);
        }
    
    }
}

