using System;

namespace EJERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una casa de video juegos otorga un descuento dependiendo del importe de la compra 
            //realizada según los siguientes valores:
            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el 
            //importe final con el descuento que corresponda.

            //Paso 0: Crear variables
            float IMPORTE;

            //Paso 1: Pedir Importes
            Console.WriteLine("Ingrese el importe total: ");
            IMPORTE = float.Parse(Console.ReadLine());

            //Paso 2: Condiciones
            if (IMPORTE < 1000)
                Console.WriteLine("No hay descuento, su importe es: " + IMPORTE);
            
            if (IMPORTE >= 1000)
                if (IMPORTE < 5000){
                    IMPORTE = IMPORTE - (IMPORTE*0.10f);
                    Console.WriteLine("Su importe final es: " + IMPORTE);
                }

            if (IMPORTE >= 5000){
                IMPORTE = IMPORTE - (IMPORTE*0.18f);
                Console.WriteLine("Su importe final es: " + IMPORTE);                    
                }                
        }
    }
}
