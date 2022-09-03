using System;
using System.Collections;
using Full_GRASP_And_SOLID.Library;


namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter
    {
        public static void Printer(Recipe receta)
        {
            Console.WriteLine($"Receta de {receta.FinalProduct.Description}:");
            foreach (Step step in receta.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        } 
    }
}

/* Se crea esta clase para poder imprimir la receta independientemente de la misma.
Haciendolo de esta manera si en algún otro momento se quiere imprimir de otra forma,
no es necesario cambiar la clase Recipe sino que simplemente se hace una nueva clase
con la nueva impresion de la receta. */