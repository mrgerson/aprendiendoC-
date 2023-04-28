namespace Animales
{

    public class Animal
    {
        public string Nombre { get; set; } = "";
        public string Color { get; set; } = "";

        public List<Animal> Animaless { get; set; } = new List<Animal>();


        /* public Animal (String nombre, String color){

            Nombre = nombre;
            Color = color;
           
        }
        */
        public override string ToString()
        {
            return $"Nombre: \"{Nombre}\", Color: {Color}";
        }
    }

}