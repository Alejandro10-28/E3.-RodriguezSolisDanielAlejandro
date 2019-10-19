using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListE3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia principal para llamar a la bienvenida para que el usuario pueda 
            //interactuar con el menu de inicio
            Principal M = new Principal();
            M.Bienvenida();
        }
    }
}
