using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYListas
{
    internal class ClienteDto
    {
        // Contendrá los atributos: campos o caracteristicas de este cliente
        string nombreCliente;

         string apellidosCliente;

        string dniCliente;

        DateOnly fechaNacimientoCliente;

        string emailCliente;

        int tlfCliente;

        DateOnly fechaAltaCliente;

        DateOnly fechaBajaCliente;

        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public DateOnly FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public DateOnly FechaAltaCliente { get => fechaAltaCliente; set => fechaAltaCliente = value; }
        public DateOnly FechaBajaCliente { get => fechaBajaCliente; set => fechaBajaCliente = value; }

        //métodos Get y Set
        // GET nos dará el valor del campo

        //Constructores, metodos que tiene una clase par ahacer el new, toda clase tendrá
        //un constructor por defecto, que será el consturctor vacío, que es el constructor por defecto
        public ClienteDto()
        {

        }

        public ClienteDto(string nombreCliente, string dniCliente)
        {
            this.nombreCliente = nombreCliente;
            this.dniCliente = dniCliente;
        }

        // this palabra clave que hace referencia a la clase donde está
        // dice: dentro d ela clase cliente, asigna a la clase campo el valor que le estoy pasando
        // te creas una copia 


        //método ToString será el que transforme el objeto en toda la información sin necesidad de tener
        //que convertir al momento.PERMITE CONVERTIR TODA LA INFORMACION QUE HAY DENTRO DE LOS CAMPOS 
        // QUE HAYA DENTRO UN 
        public  string toString()
        {
            string objetoString = this.nombreCliente + " "+ this.dniCliente;
            
            return objetoString;
        }
       
    }
}
