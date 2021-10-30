using System;

namespace claseExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número por consola: ");
            int numero;
            
            try
            {
                numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Número ingresado correctamente!");
            }
            
            catch (FormatException ex)
            {
                Console.WriteLine("No has ingresado un número");
                numero = 0;
            }catch(OverflowException ex)
            {
                Console.WriteLine("El número que has ingresado es demasiado grande!");
                numero = Int32.MaxValue;
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo generar la acción, por favor contacte al área correspondiente(CO-01)");
                Console.WriteLine(ex.Message);
                numero = 0;
            }
            finally
            {
                Console.WriteLine("La ejecución de bloque try-catch ha terminado!");
            }

            Console.WriteLine("El valor del número es: "+numero);
            
        }
    }
}
