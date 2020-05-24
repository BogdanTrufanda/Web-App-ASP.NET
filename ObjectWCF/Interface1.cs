using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Project1;

namespace ObjectWCF
{
    [ServiceContract]
    interface Interface1
    {
        [OperationContract]
        void Add(string a, string b, string c, string d, string e, string f, string g);
        [OperationContract]
        void Remove(string path);
        [OperationContract]
        void Update(string a, string b, string c);
        [OperationContract]
        IEnumerable<string> GetColumnNames();
        [OperationContract]
        List<string> GetPaths();
        [OperationContract]
        List<string> GetAll();
        [OperationContract]
        List<string> Get(string a);

    }
}
