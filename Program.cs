using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probllema2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            opciones();
            Console.ReadKey();


        }
        static void opciones()
        {

            Console.WriteLine("========================");
            Console.WriteLine("Tienda de Don Lucas");
            Console.WriteLine("========================");
            Console.WriteLine("========================");
            Console.WriteLine("1: Registrar venta");
            Console.WriteLine("2: Registrar devolucion");
            Console.WriteLine("3: Cerrar Caja");
            Console.WriteLine("========================");
            Console.WriteLine("Ingrese una opción");
            int opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    registrarventa();
                    break;
                case 2:
                    Console.Clear();
                    registrardevolucion();
                    break;
                case 3:
                    Console.Clear();

                    break;

            }

        }
        static void registrarventa()
        {
            Console.WriteLine("========================");
            Console.WriteLine("Registrar venta de:");
            Console.WriteLine("========================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electronicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("========================");
            Console.WriteLine("Ingrese una opción");
            int ventasops = int.Parse(Console.ReadLine());

            switch (ventasops)
            {
                case 1:
                    ventalimpieza2("Limpieza");
                    
                    break;
                case 2:
                    ventalimpieza2("Abarrotes");
                    break;
                case 3:
                    ventalimpieza2("Golosinas");
                    break;
                case 4:
                    ventalimpieza2("Electronicos");
                    break;
                case 5:
                    Console.WriteLine("<- Regresar");
                    Console.Clear();
                    opciones();
                    break;

            }
            Console.Clear();
        }
        static void ventalimpieza2(string calculo2)
        {
            Console.Clear() ;
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:" + calculo2);
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades):"); float unidades = float.Parse(Console.ReadLine());
            Console.Write(" Ingrese precio: S/ "); float precio1 = float.Parse(Console.ReadLine());
            Console.WriteLine("================================");


            Console.WriteLine("Se han ingresado:" + unidades+ " unidades");
            float resultadoops = 0f;
            resultadoops = unidades * precio1;
            Console.WriteLine("Se han ingresado:" +  resultadoops +  " en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1:Registrar más productos de " + calculo2);
            Console.WriteLine("2:<- Regresar");
            int menusatras = int.Parse(Console.ReadLine());

            switch (menusatras)
            {
                case 1:
                    Console.Clear();
                    registrarventa();
                    break;
                case 2:
                   
                    Console.Clear();
                    opciones();
                    break;
            }

            Console.WriteLine("================================");
            Console.WriteLine("Ingrese una opcion");



        }
    
            static void registrardevolucion()
          { 
            Console.WriteLine("========================");
            Console.WriteLine("Registrar devolución de:");
            Console.WriteLine("========================");
            Console.WriteLine("1: Limpieza");
            Console.WriteLine("2: Abarrotes");
            Console.WriteLine("3: Golosinas");
            Console.WriteLine("4: Electronicos");
            Console.WriteLine("5: <- Regresar");
            Console.WriteLine("========================");
            Console.WriteLine("Ingrese una opción");
            int ventasops = int.Parse(Console.ReadLine());


            switch (ventasops)
            {
                case 1:
                    ventalimpieza("Limpieza");
                   
                    break;
                case 2:
                    ventalimpieza("Abarrotes");
                    break;
                case 3:
                    ventalimpieza("Golosinas");
                    break;
                case 4:
                    ventalimpieza("Electronicos");
                    break;
                case 5:
                    Console.WriteLine("<- Regresar");
                    Console.Clear();
                    opciones();
                    break;
            }
        }

       
        
            static void ventalimpieza(string calculo1)
        {
            Console.Clear ();
            Console.WriteLine("================================");
            Console.WriteLine("Registrar venta de:"+calculo1);
            Console.WriteLine("================================");
            Console.Write("Ingrese cantidad (unidades):");float unidades=float.Parse(Console.ReadLine());
            Console.Write(" Ingrese precio: S/ ");float precio1=float.Parse(Console.ReadLine());
            Console.WriteLine("================================");

            
            Console.WriteLine("Se han ingresado:"+unidades+ " unidades");
            float resultadoops = 0f;
            resultadoops = unidades * precio1;
            Console.WriteLine("Se han ingresado:"+resultadoops + " en caja");
            Console.WriteLine("================================");
            Console.WriteLine("1: Registrar más productos de " + calculo1);
            Console.WriteLine("2: <- Regresar");
            
            int menusatras =int.Parse(Console.ReadLine());
            switch (menusatras)
            {
                case 1:
                    Console.Clear();
                    registrarventa();
                    break;
                case 2:
                    
                    Console.Clear();
                    opciones();
                    break;
            }


        }




    }
}



