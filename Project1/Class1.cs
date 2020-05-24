using Project1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/// <summary>
///   Clasa Class1.cs contine metodele din API. Aceste functii sunt apelate prin intermediul GUI-ului ce presteaza operatii pe baza de date.
/// </summary>


namespace Project1
{
    public class Class1
    {
        public static void Add(string name, string path, string size, string creation, string accesed, string suffix, string resolution)
        {
            /// <summary>
            ///    Adauga o poza  noua in baza de date (cu toate proprietatile ei)
            /// </summary>
            /// <param name="name"> Numele pozei. </param>
            /// <param name="path"> Path-ul pozei. </param>
            /// <param name="size"> Dimensiunea pozei. </param>
            /// <param name="creation"> Data de creare. </param>
            /// <param name="accesed"> Ultima data cand a fost accesata poza. </param>
            /// <param name="suffix"> Extensia pozei.</param>
            /// <param name="resolution"> Resolutia pozei.</param>

            using (Model1Container context = new Model1Container())
            {
                Phodeos poza = new Phodeos()
                {
                    Name = name,
                    Path = path,
                    Size = size,
                    cDate = creation,
                    mDate = accesed,
                    Extension = suffix,
                    Resolution = resolution
                };
                context.Phodeos.Add(poza);
                context.SaveChanges();
            }
        }

        public static void Remove(string path)
        {
            /// <summary>
            /// Sterge o poza din baza de date
            /// </summary>
            /// <param name="path"> Path-ul pozei. </param>

            using (Model1Container context = new Model1Container())
            {
                context.Phodeos.RemoveRange(context.Phodeos.Where(x => x.Path == path));
                context.SaveChanges();
            }
        }

        public static void Update(string column, string value, string path)
        {
            /// <summary>
            ///    Modifica textul de la o anumita proprietate a unei poze din baza de date.
            /// </summary>
            /// <param name="column"> Ce coloana modificam. </param>
            /// <param name="value"> Cu ce valoare modificam. </param>
            /// <param name="path"> Path-ul pozei. </param>

            using (Model1Container context = new Model1Container())
            {

                var result = context.Phodeos.SingleOrDefault(b => b.Path == path);

                if (result != null)
                {
                    if (column.Equals("Name"))
                    {
                        result.Name = value;
                    }
                    if (column.Equals("Path"))
                    {
                        result.Path = value;
                    }
                    if (column.Equals("Size"))
                    {
                        result.Size = value;
                    }
                    if (column.Equals("cDate"))
                    {
                        result.cDate = value;
                    }
                    if (column.Equals("mDate"))
                    {
                        result.mDate = value;
                    }
                    if (column.Equals("Extension"))
                    {
                        result.Extension = value;
                    }
                    if (column.Equals("Resolution"))
                    {
                        result.Extension = value;
                    }
                    context.SaveChanges();
                }

            }
        }

        public static IEnumerable<string> GetColumnNames()
        {
            /// <summary>
            ///   Extrage numele tuturor coloanelor din tabel.
            /// </summary>
            using (Model1Container context = new Model1Container())
            {
                var columns = typeof(Phodeos).GetProperties()
                            .Select(property => property.Name)
                            .ToArray();

                return columns;
            }
        }
        public static List<string> GetAll()
        {

            /// <summary>
            ///    Extragem tot continutul tabelei.
            /// </summary>
            using (Model1Container context = new Model1Container())
            {
                var all = context.Phodeos.ToList();
                List<string> list = new List<string>();
                foreach (var x in all)
                {
                    list.Add(x.justID.ToString());
                    list.Add(x.Name);
                    list.Add(x.Path);
                    list.Add(x.Size);
                    list.Add(x.mDate);
                    list.Add(x.cDate);
                    list.Add(x.Resolution);
                    list.Add(x.Extension);
                }

                return list;
            }
        }

        public static List<string> GetPaths()
        {

            /// <summary>
            ///    Extragem toate path-urile din continutul tabelei.
            /// </summary>


            using (Model1Container context = new Model1Container())
            {
                var all = context.Phodeos.ToList();
                List<string> list = new List<string>();
                foreach (var x in all)
                {
                    list.Add(x.Path);
                }

                return list;
            }

        }

        public static List<string> Get(string name)
        {

            /// <summary>
            ///    Extragem toate informatiile din  coloana data din continutul tabelei.
            /// </summary>
            /// <param name="name"> Numele coloanei pe care dorim sa o extragem. </param>
            using (Model1Container context = new Model1Container())
            {
                var all = context.Phodeos.ToList();
                List<string> list = new List<string>();
                foreach (var x in all)
                {
                    if (name.Equals("Name"))
                    {
                        list.Add(x.Name);
                    }
                    if (name.Equals("Path"))
                    {
                        list.Add(x.Path);
                    }
                    if (name.Equals("Size"))
                    {
                        list.Add(x.Size);
                    }
                    if (name.Equals("cDate"))
                    {
                        list.Add(x.cDate);
                    }
                    if (name.Equals("mDate"))
                    {
                        list.Add(x.mDate);
                    }
                    if (name.Equals("Extension"))
                    {
                        list.Add(x.Extension);
                    }
                    if (name.Equals("Resolution"))
                    {
                        list.Add(x.Resolution);
                    }
                }
                return list;
            }
        }

    }



}
