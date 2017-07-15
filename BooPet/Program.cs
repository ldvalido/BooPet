using System;
using System.Collections.Generic;
using System.IO;
using Antlr3.ST;

namespace BooPet
{
    class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "Template";

            List<Person> _list = new List<Person>();
            _list.Add(new Person("idCustomer","integer"));
            _list.Add(new Person("Name","Alphanumeric"));

            StringTemplateGroup grp = new StringTemplateGroup(Environment.CurrentDirectory);
            StringTemplate tmp = grp.GetInstanceOf(fileName);


            tmp.SetAttribute("ProcessorType", "validationFile.Processor.standardProcessor");
            tmp.SetAttribute("ProcessorPath", ".");

            tmp.SetAttribute("HandlerType", "ValidationInputFileDataFlowSSIS.pipellineBufferHandler");
            tmp.SetAttribute("HandlerPath", @"C:\Proyects\petSSISCustomTask\ValidationInputFileDataFlowSSIS\bin\Debug\ValidationInputFileDataFlowSSIS.dll");
            
            tmp.SetAttribute("MessageType", "ValidationInputFileDataFlowSSIS.KOMessageProvider");
            tmp.SetAttribute("MessagePath", @"C:\Proyects\petSSISCustomTask\ValidationInputFileDataFlowSSIS\bin\Debug\ValidationInputFileDataFlowSSIS.dll");

            tmp.SetAttribute("Fields", _list);
            
            Console.Write(tmp);
            StreamWriter sw = new StreamWriter("output.xml");
            sw.Write(tmp.ToString());
            sw.Close();
            Console.ReadKey();
        }
    }
}
