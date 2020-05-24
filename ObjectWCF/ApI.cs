using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1;

namespace ObjectWCF
{
    public class ApI : Interface1
    {
        void Interface1.Add(string name, string path, string size, string creation, string accesed, string suffix, string resolution)
        {
            Class1.Add(name,path,  size,  creation, accesed, suffix, resolution);
        }
        void Interface1.Remove(string path)
        {
            Class1.Remove(path);
        }
        void Interface1.Update(string column, string value, string path)
        {
            Class1.Update(column, value, path);
        }
        IEnumerable<string> Interface1.GetColumnNames()
        {
            return Class1.GetColumnNames();
        }
        List<string> Interface1.GetPaths()
        {
            return Class1.GetPaths();
        }
        List<string> Interface1.GetAll()
        {
            return Class1.GetAll();
        }
        List<string> Interface1.Get(string name)
        {
            return Class1.Get(name);
        }
   
    }


    }

