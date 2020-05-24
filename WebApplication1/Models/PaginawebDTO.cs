using ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    [DataContract(IsReference = true)]
    public class PaginawebDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]

        [DataMember]
        public string justID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Size { get; set; }
        [DataMember]
        public string cDate { get; set; }
        [DataMember]
        public string mDate { get; set; }
        [DataMember]
        public string Extension { get; set; }
        [DataMember]
        public string Resolution { get; set; }
        [DataMember]
        public string Pozaname { get; set; }
        [DataMember]
        public string Contor { get; set; }
        [DataMember]
        public List<string> Prop { get; set; }


    }
}