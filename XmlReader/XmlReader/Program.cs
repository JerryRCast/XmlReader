using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definimos un string para concatenar los valores que encontremos
            string result = "";
            // Obtenemos ruta del archivo
            string path = Path.GetFullPath(@"..\..\..\EjemploRelacionados.xml");
            // Cargamos el archivo con XMLDocument
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            // Cargamos una lista con elementos del nodo deseado
            XmlNodeList nodeList = doc.GetElementsByTagName("CfdiRelacionado");
            // Validamos que la lista contenga algún elemento
            if (nodeList.Count > 0)
            {
                // Para cada elemento de la lista obtenemos obtendremos sus atributos
                foreach (XmlNode item in nodeList)
                {
                    // Obtenemos el atributo UUID y mostramos su valor
                    Console.WriteLine(item.Attributes.GetNamedItem("UUID").InnerText);
                    // Concatenamos valores de los atributos hallados y luego lo mostramos
                    result = result + item.Attributes.GetNamedItem("UUID").InnerText;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
