using System;

namespace programacion_1._4
{
    class Program
    {
        public static string onOff;
        static void Main(string[] args)
        {
            var car = new vehiculo();
            Console.WriteLine(" Marca: " + vehiculo.Marca + " \nModelo: " + vehiculo.Modelo + " \nAño: " +
                    vehiculo.Año + " \nColor: " + vehiculo.Color + "\nEstado:" + vehiculo.estado);
            Console.WriteLine("Si desea cambiar el estado del vehiculo presione 1 y luego presione ENTER");
            onOff =  Console.ReadLine();
            if (onOff != "1" ) {
                return;
            }

            if (onOff == "1")
            {
                vehiculo.encender();
                Console.WriteLine(" Marca: " + vehiculo.Marca + " \nModelo: " + vehiculo.Modelo + " \nAño: " +
                    vehiculo.Año + " \nColor: " + vehiculo.Color + "\nEstado:" + vehiculo.estado);
                Console.WriteLine("Si desea cambiar el estado del vehiculo presione 1 y luego presione ENTER");
                onOff = Console.ReadLine();

            }
            else
            {
                vehiculo.apagar();
                Console.WriteLine(" Marca: "+ vehiculo.Marca + " \nModelo: "+ vehiculo.Modelo + " \nAño: "+ 
                    vehiculo.Año + " \nColor: "+ vehiculo.Color + "\nEstado:"+ vehiculo.estado);
                Console.WriteLine("Si desea cambiar el estado del vehiculo presione 1 y luego presione ENTER" );
                
            }

       

       }
    }

    class vehiculo
    {
        static public string Marca = "Honda";
        static public string Modelo = "Civic";
        static public int Año = 2015;
        static public string Color = "Rojo";
        static public string estado = "Apagado";
        static public void encender()
        {
            estado = "Encendido";
        }
        static public void apagar()
        {
            estado = "Apagado";
        }

    }
}
