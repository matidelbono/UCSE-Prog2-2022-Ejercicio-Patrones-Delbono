using System;
using logica;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Persistencia
{
    public class PrincipalPersistencia
    {
       
        
            List<Persona> personas = new List<Persona>();
            public bool GuardarListadePersonas()
            {
                using (StreamWriter writer = new StreamWriter(@"\C: ListadoPacientes", false))
                {
                string JsonList = JsonConvert.SerializeObject(personas);
                    writer.Write(JsonList);
                    return true;
                }

            }
            public List<Persona> LeerDesdeUnArchivo()
            {
                using (StreamReader Lector = new StreamReader(@"\C:Users/Usuario/Documentos/ListadoPacientes"))
                {
                    string json = Lector.ReadToEnd();
                    List<Persona> PacientesDesdeArchivo = JsonConvert.DeserializeObject<List<Persona>>(json);
                    return PacientesDesdeArchivo;
                }
            }
            public sealed class Singleton
            {

                private static Singleton instance = null;
                private Singleton()
                {

                }
                public static Singleton Instance
                {
                    get
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();

                        }
                        return instance;
                    }

                }
            }

        }
    }



