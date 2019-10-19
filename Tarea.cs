using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListE3
{
    public class Tarea 
    {
        //Se instancia la T1 de tipo global ya que se usara en varios de los metodos
        List<Atributos> T1 = new List<Atributos>();
        //se instancia principal d ya que se utilizara en algunos de los metodos
        //Se usa el metodo crear tareas para que el profesor pueda asignar tareas a sus alumnos
        public void CrearTareas()
        {
            //Se instancia atributos para que T contenga los atributos para crear las tareas
           Atributos T = new Atributos();
            //Se utiliza la funcion count para que registre el numero de tarea que es.
            T.NoTarea = T1.Count+1;
            Console.WriteLine("Nombre del usuario:");
            T.NombreU = Console.ReadLine();
            Console.WriteLine("Nombre de la tarea:");
            T.Tarea = Console.ReadLine();
            Console.WriteLine("Hora:");
            T.Hora = Console.ReadLine();
            Console.WriteLine("Fecha:");
            T.Fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Estado:");
            T.status = Console.ReadLine();
            //Una vez creada la tarea se agrega a la lista T1
            T1.Add(T);

            Console.Clear();


        }
        //El metodo listadetareas solo mostrara las tareas creadas por el profesor
        public void ListaDeTareas()
        {
            //Se crea el foreach para el pase de la lista atributos
            //y se crea una variable de tipo atributos en este caso P
            //La cual contendra los datos existentes en las tareas
            foreach (Atributos p in T1)
            {
                //Se imprimen el numero de tarea y el nombre de ella
                Console.WriteLine(p.NoTarea+"-."+p.Tarea);
            }
            Console.ReadKey();
            Console.Clear();
         

        }
        //El metodo Tareas imprimira los detalles de la tarea la cual se busque
        public void Tareas()
        {
            //Se instancia la clase atributos para utilizar los atributos existentes en dicha clase..
            Atributos Ad = new Atributos();
            //Se crea una variable de tipo DateTime la cual guardara lo ingresado en el metodo obtener datos
            DateTime datos = ObtenerDatos();
            //Se crea ListaT de tipo var para guardar la instancia de la lista <Atributos>
            var ListaT = T1;
            //Se usa foreach para pasar por la listaT
            foreach(var Tarea1 in ListaT)
            {
                //Si los datos ingresados son iguales a la Fecha de la tarea se ejecutara lo siguiente
                if (datos == Tarea1.Fecha)
                {
                    //Se imprimiran los detalles de la tarea
                    Console.WriteLine(Tarea1.NoTarea+"-."+"Nombre de la tarea:"+Tarea1.Tarea+"\n"+"Hora:\n"+Tarea1.Hora+"\n"+ "Estado:\n"+ Tarea1.status+"\n" +"Nombre del usuario:\n"+ Tarea1.NombreU);
                }
            }
            Console.ReadKey();
            Console.Clear();


        }
        //Este metodo es para mostrar el estado de las tareas ingresadas por el profesor.
        public void Estado ()
        {
            //se usa foreach para pasar por la lista T1
            foreach (Atributos p in T1)
            {
                //Se imprimiran todas las tareas y su estado actual
                Console.WriteLine(p.NoTarea+"-."+p.Tarea+"\n"+"Estado:\n"+p.status);
            }
            Console.ReadKey();
            Console.Clear();

        }
        //Metodo usado para cambiar el estado de las tareas ya ingresadas por el profesor
        public void CambiarEstado()
        {
            //Se usa datos para guardar la fecha ingresada por el usuario
            DateTime datos = ObtenerDatos();
            //Se guarda la lista de T1 en listT
            var ListT = T1;
                //Se usa foreach para pasar Tarea1 por LisT
                foreach (var Tarea1 in ListT)
                {
                    //Se crea un if donde si la fecha ingresada coincide con la fecha de alguna de las tareas
                    //Este permitira que se realice un cambio en el estado de dicha tarea.
                    if (datos == Tarea1.Fecha)
                    {
                        Console.WriteLine("Ingresa el nuevo estado:");
                        Tarea1.status = Console.ReadLine();
                        Console.WriteLine("El estado actual de la tarea es:\n"+Tarea1.status);
                    }
                   
                }
            Console.ReadKey();
            Console.Clear();

            

        }
        //Se usa un metodo de tipo datatime para pedir al usuario que ingrese las fechas de las tareas
        //que solicita en las opciones correspondientes.
        public DateTime ObtenerDatos()
        {

            Console.WriteLine("Ingresa fecha de la tarea");
            DateTime N = Convert.ToDateTime(Console.ReadLine());
            return (N);

        }
    }
}
