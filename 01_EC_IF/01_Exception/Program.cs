using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                int num = int.Parse(null);
            }catch (FormatException e)
            {
                Console.WriteLine("Não foi localizado número na frase!");
            }
            catch(Exception e)
            {
                Console.WriteLine("Tratado pelo classe pai - exception");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.ReadKey();
        }   
    }
}
