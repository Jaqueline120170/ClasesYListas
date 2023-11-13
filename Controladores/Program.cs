namespace ClasesYListas.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* para que esto funcione poner en public los atributos clientedto
            //LISTA TIPOS PRIMITIVOS
            List<int> listaEnteros = new List<int>();
            //Añadir
            listaEnteros.Add(22);
            int entero = 6;
            listaEnteros.Add(entero);
            //Acceder
            //Directamente, se hace indicando la posiciona  la que quieor acceder
            listaEnteros[0] = entero;//[6][6]
            listaEnteros[1] = 22;//[6][22]
            int posicionCero = listaEnteros[0]; //PosicionCero = 6
            int posicionUno = listaEnteros[1];// PosicionUno = 22
            //Acceso Indirecto (recorriendo la lista)
            for (int posicion = 0; posicion<listaEnteros.Count();posicion++)

            {
                Console.WriteLine(listaEnteros[posicion]);
            }
            // LISTA CON TIPOS OBJETO
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            // Crear un cliente
            ClienteDto cliente1 = new ClienteDto();
            cliente1.nombreCliente = "Regino";
            cliente1.apellidosCliente = "Fernández";
            string nombreCompleto = cliente1.nombreCliente + cliente1.apellidosCliente;

            ClienteDto cliente2 = new ClienteDto();
            cliente2.nombreCliente = "Pepe";
            cliente2.apellidosCliente = "García";

            //Añadir cliente a la lista
            listaClientes.Add(cliente1);
            listaClientes.Add(cliente2);
            //[cliente1][cliente2]
            //Acceder a un cliente especifico por su posición
            ClienteDto cliente2prima = listaClientes[1];
            // Accedido al cliente2 que estaba en la posicion 1 de la lista
            // y dentro de ese cliente hemos acceiddo a su campo nombre
            Console.WriteLine(listaClientes[1].nombreCliente);
            // modificación de un campo del cliente 2
            listaClientes[1].nombreCliente = "María";
            //Accedemos a la referencia de memoria de la lista
            Console.WriteLine(listaClientes);
            //Accedemos a la referencia de memoria del objeto cliente1
            Console.WriteLine(listaClientes[0]);
            //Recorrer toda la lista con for each, que está hecho exclusivamente para listas
            for (int posicion = 0; posicion<listaClientes.Count(); posicion++)
            {
                Console.WriteLine("Nombre:"+ listaClientes[posicion].nombreCliente);
            }

            //Eliminar, cuando se elimina la lista se recompone o se desplaza para cubrir
            // el espacio libre
            //listaClientes.RemoveAt(0);
            //Console.WriteLine(listaClientes.Count());

            // foreach
            //[cliente1][cliente2]
            cliente2prima.nombreCliente = "Alfonso";
            foreach (ClienteDto cliente in listaClientes)
            {
                cliente.nombreCliente = "Rocio";
            }

            Console.WriteLine(cliente2.nombreCliente);
            Console.WriteLine(cliente2prima.nombreCliente);
            Console.WriteLine(listaClientes[1].nombreCliente);

            //Modificar
            foreach(ClienteDto cliente in listaClientes)
            {
                if (cliente.nombreCliente == "Rocio")
                {
                    cliente.apellidosCliente = "Leal";
                }
                Console.WriteLine(cliente2.apellidosCliente);
            */

            // Atributo en privado,
            // que es el modificador que tienen por defecto los miembros d euna clase

            ClienteDto cliente = new ClienteDto();
            cliente.NombreCliente = "Marcos";
            string nombre = cliente.NombreCliente;

            //contructor por defecto o nvacio de nuestra clase list
            List<int> listaEnteros = new List<int>() { 1, 2, 3, 4 ,5 };

            /*
            listaEnteros.RemoveAt(1);
            // 1, 3, 4, 5
            //remueve la posicion
            listaEnteros.Remove(4);
            // busca en todas las posiciones cuales tienen ese valor y esas posiciones son 
            // las que se va a quitar de en medio. Borra solo el valor que coincida con el valor introducido
            // tendríamos 1, 3, 4, 5
            listaEnteros.RemoveRange(1,2);
            //indica en qué posicion queremos empezar a eliminar, la posicion que
            //yo le indique como cualquier parametro. Primero le paso en qué posicion empiezo a eliminar
            // lo segundo que le paso es el numero de posiciones que quiero eliminar a partir del prmer dato que le pase
            //como resultado tendriamos 1
            listaEnteros.Add(8);
            listaEnteros.Add(7);
            listaEnteros.Add(4);
            //1,8,7,4
            //listaEnteros.RemoveAll(x => x<5);
            // por poner un ejemplo si el 1 es menor que 5, lo borra; si el 8 es menor que 5, lo deja
            //porque no es menor
            // como resultado nos quedaremos solo con el valor 8 y 7
            //listaEnteros.Clear();
            // se carga todo lo que hay en la lista y por lo tanto esta queda vacía


            //ORDENAR ELEMENTOS BASICOS DE UNA LISTA ASCENDENTE Y DESCENDENTE
            listaEnteros.Reverse();
            //8, 7, 4, 1
            listaEnteros.Sort();
            //1, 4, 7, 8
            */

           
            ClienteDto cliente1 = new ClienteDto(" Jaqueline", "Z0874536N");
            cliente.toString();
            Console.WriteLine(cliente); // imprime referencia de memoria
            Console.WriteLine(cliente.toString()); // consigue pasar un objeto a tipo texto, SI LO CREAMOS NOSOTROS MISMOS
            Console.WriteLine(cliente.ToString());// 
            // instanciar un nuevo cliente al que se le informe el nombre y el dni directamente
            // se imprima por consola el nombre y el dni utilizando un metodo to string dentro de la clase



        }
        }
    }
