using DTOGenerator.Sample;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DTOGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // sample use of generated dto classes
            var basic = new BasicDTO(100, "a");

            var x = new XmlSerializer(typeof(BasicDTO));
            using (var strStream = new StringWriter())
            {
                x.Serialize(strStream, basic);

                Console.WriteLine("=============== XML Serialized Basic DTO ===============");
                Console.WriteLine();
                Console.WriteLine(strStream.ToString());
                Console.WriteLine();
                
                var basicDeserialized = (BasicDTO)x.Deserialize(new StringReader(strStream.ToString()));
                Console.WriteLine("================ Deserialized Basic DTO ================");
                Console.WriteLine();
                Console.WriteLine("Age: {0}", basicDeserialized.Age);
                Console.WriteLine("Name: {0}", basicDeserialized.Name);
            }
            Console.ReadLine();
        }
    }
}
