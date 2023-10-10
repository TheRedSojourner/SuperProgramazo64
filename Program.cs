namespace SuperProgramazo64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona jorge = new Persona();
            Persona martin = new Persona();

            List<Persona> personas = new List<Persona>();
            //Esta es una linea de comentarios tralalala lala la la
            //la
            personas.Add(jorge);
            personas.Add(martin);
            martin.nombre = "Martin";

            personas.Remove(jorge);
            
            RemovePersonaFromListByName(personas, "Gutz");

        }

        static void RemovePersonaFromListByName(List<Persona> personas, string nombre) 
        {
            
            for (int i = 0; i < personas.Count; i++)
            {
                if (personas[i].nombre == nombre) { personas.RemoveAt(i); }   
            }
            
        }

        static void CrearPersona() 
        {
            Persona persona = new Persona();
            persona.nombre = "Gutz";

        }

        static void CambiarEstadete(Persona persona) 
        {
            persona.esAburrido = true;
        }
        static void Sumar(out int x) 
        {
            x = 1;
        }
        static void SumarATodoElArray(ref int[] numeros) 
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]++;

            }
            numeros = new int[5]; 
        }

        static void CambiarEstado(Persona persona) 
        {
            persona.esAburrido = !persona.esAburrido;
        }

    }
}