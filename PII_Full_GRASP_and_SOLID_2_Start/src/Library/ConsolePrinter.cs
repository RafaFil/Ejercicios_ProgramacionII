using System;
using System.Collections;

/* Justificacion: 
La responsabilidad de esta clase es la de imprimir la receta (en este caso en pantalla), se aplica el
principio SRP (la unica razon para cambiar esta clase es si se desea modificar la forma de impresion
de la receta). Los unicos cambios que se dan con respecto al codigo anterior es que el metodo de clase
PrintRecipe va a recibir como parametro recipe de la clase Recipe. Y ademas el FinalProduct asi como
el Steps van a tener que ser referenciados a Recipe, estos por ser instancias de la clase mencionada
anteriormente.
*/

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:"); 
            foreach (Step step in recipe.Steps)     
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " + 
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}