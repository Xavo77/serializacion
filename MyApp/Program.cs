using Newtonsoft.Json;
using System;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto
            var persona = new Persona { ID=2000,Nombre="Marcos", Edad=26, ApellidoPaterno="Lucas", ApellidoMaterno="Martinez", Pais="Mexico"};

            // serializar el objeto a json
            Console.WriteLine("Objeto serializado:");
            var jsonObjetoSerializado = JsonConvert.SerializeObject(persona);
            Console.WriteLine(jsonObjetoSerializado);
            Console.ReadLine();

            //deserializar jsonObjetoSerializado
            Console.WriteLine("Json deserializado");
            var jsonObjetoDeserealizado = JsonConvert.DeserializeObject<Persona>(jsonObjetoSerializado);
            Console.WriteLine($"ID:{jsonObjetoDeserealizado.ID}");
            Console.WriteLine($"Nombre:{jsonObjetoDeserealizado.Nombre}");
            Console.WriteLine($"Edad:{jsonObjetoDeserealizado.Edad}");
            Console.WriteLine($"Apellido Paterno:{jsonObjetoDeserealizado.ApellidoPaterno}");
            Console.WriteLine($"Apellido Materno:{jsonObjetoDeserealizado.ApellidoMaterno}");
            Console.WriteLine($"Pais:{jsonObjetoDeserealizado.Pais}");
            Console.ReadLine();
        }

        // modelo clase
        class Persona {
            public int ID { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public string ApellidoPaterno { get; set; }
            public string ApellidoMaterno { get; set; }
            public string Pais { get; set; }
        }
    }
}