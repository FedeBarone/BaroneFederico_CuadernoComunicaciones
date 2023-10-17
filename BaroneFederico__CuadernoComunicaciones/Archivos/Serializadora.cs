using Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace Entidades.Archivos
{
    public class Serializadora
    {
        public static void EscribirXML(string ruta, List<Usuario> listaAux)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Usuario>));
                    ser.Serialize(sw, listaAux);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se lanzo la excepcion: {ex.Message}");
            }
            
        }

        public static List<Usuario> LeerXML(string ruta)
        {
            List<Usuario> listaAux = null;
            try
            {
                if (File.Exists(ruta))
                {
                    using (StreamReader sr = new StreamReader(ruta))
                    {
                        XmlSerializer des = new XmlSerializer(typeof(List<Usuario>));
                        listaAux = (List<Usuario>)des.Deserialize(sr);
                    }
                }
                else
                {
                    Console.WriteLine($"El archivo no existe en la ruta: {ruta}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se lanzó la excepción: {ex.Message}");
            }
            return listaAux;

        }

        #region Metodos
        public static void EscribirJson(string ruta, List<Familia> listaAux)
        {
            try 
            {
                string json = JsonConvert.SerializeObject(listaAux, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(ruta, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se lanzó la excepción: {ex.Message}");
            }
        }

        public static List<Familia> LeerJson(string ruta)
        {
            List<Familia> listaAux = null;
            try
            {
                if (File.Exists(ruta))
                {
                    string json = File.ReadAllText(ruta);
                    listaAux = JsonConvert.DeserializeObject<List<Familia>>(json);
                }
                else
                {
                    Console.WriteLine($"El archivo no existe en la ruta: {ruta}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se lanzó la excepción: {ex.Message}");
            }
            return listaAux;
        }
        #endregion
    }
}
