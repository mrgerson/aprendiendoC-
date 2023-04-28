using System;
using System.Collections.Generic;
using static System.Console;
using Animales;
using System.Linq;

namespace Animales
{
    class Program
    {
        static void Main(string[] args)
        {

            var animales = new Animal();

            animales.Animaless = new List<Animal>(){
                new Animal() { Nombre = "Hormiga", Color = "Rojo"},
                new Animal() { Nombre = "Lobo", Color = "Gris" },
                new Animal() { Nombre = "Elefante", Color = "Gris" },
                new Animal() { Nombre = "Pantegra", Color = "Negro" },
                new Animal() { Nombre = "Gato", Color = "Negro" },
                new Animal() { Nombre = "Iguana", Color = "Verde" },
                new Animal() { Nombre = "Sapo", Color = "Verde" },
                new Animal() { Nombre = "Camaleon", Color = "Verde" },
                new Animal() { Nombre = "Gallina", Color = "Blanco" },
            };

            //trae una coleccion de todos los registros 
            ColeccionAnimal(animales.Animaless);


            // filtra todos los animales que sean de color verde que su nombre inicie con una vocal
            var resul = (from a in animales.Animaless where a.Color.Contains("Verde") && "AEIOUaeiou".Contains(a.Nombre[0]) select a).ToList();

            //mismo filtro pero utilizando sintaxis lamda
            var resul2 = animales.Animaless.Where(t => t.Color.Contains("Verde") && "AEIOUaeiou".Contains(t.Nombre[0])).ToList();

            // filtra todos los animales que sean de color verde que su nombre inicie con una vocal
            FiltroAnimal(resul2);


        }

        public static void FiltroAnimal(List<Animal> animal){

            Console.WriteLine("{0,-10} {1, 15}\n", "Animal", "Color");
             foreach (var item in animal)
             {

                Console.WriteLine("{0,-10} {1, 15}", item.Nombre, item.Color);

             }
            
        }

        public static void ColeccionAnimal(List<Animal> animal){

            Console.WriteLine("{0,-10} {1, 15}\n", "Animal", "Color");
             foreach (var item in animal)
             {

                Console.WriteLine("{0,-10} {1, 15}", item.Nombre, item.Color);

             }
            
        }


    }
}
