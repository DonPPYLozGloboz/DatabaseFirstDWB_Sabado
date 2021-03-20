using DatabaseFirstDWB_Sabado.Backend;
using System;
using System.Linq;

namespace DatabaseFirstDWB_Sabado
{
    class Program
    {
        public static CategoriesSC categoriesService = new CategoriesSC();

        public static void Tarea2()
        {
            var output = categoriesService.GetAllCategories().ToList();
        }
        static void Main(string[] args)
        {
            Tarea2();
            Console.WriteLine("Hello World!");
        }
    }
}
