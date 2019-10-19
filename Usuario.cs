using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListE3
{
    public class Usuario : Atributos
    {
        //Se usa un metodo de tipo list donde se agregaran los objetos correspondientes a la lista
        public List<Profesor> profesores()
        {
            //Se crean los objetos que estaran en la lista de prof1

            List<Profesor> prof1 = new List<Profesor>();
            prof1.Add(new Profesor { NoControl = 213, Nombrep = "Juan manuel hernandez" });
            prof1.Add(new Profesor { NoControl = 214, Nombrep = "Brenda judith" });
            prof1.Add(new Profesor { NoControl = 215, Nombrep = "Mariana huizar" });
            prof1.Add(new Profesor { NoControl = 216, Nombrep = "Maria eugenia" });
            //Se retorna prof1 ya que es la variable que contiene lo existente en la lista
            //Con la cual se compararan los datos ingresados
            return prof1;
        }
        //Se usa un metodo de tipo list donde se agregaran los objetos correspondientes a la lista

        public List<Alumno> Alumnos()
        {           
            //Se crean los objetos que estaran en la lista de alumn1

            List<Alumno> alumn1 = new List<Alumno>();
            alumn1.Add(new Alumno { NoControlA = 19210546, NombreA = "Daniel Alejandro Rodriguez Solis" });
            alumn1.Add(new Alumno { NoControlA = 19210547, NombreA = "Vicente Cazares" });
            alumn1.Add(new Alumno { NoControlA = 19210548, NombreA = "Roman Hernandez" });
            alumn1.Add(new Alumno { NoControlA = 19210549, NombreA = "Alexa Yoselin Olvera Licona" });
            //Se retorna alumn1 ya que es la variable que contiene lo existente en la lista
            //Con la cual se compararan los datos ingresados
            return alumn1;

        }
    
    }
}
