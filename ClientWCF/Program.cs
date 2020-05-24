using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

///<summary>
///Nume si prenume: Trufanda Bogdan-Gheorghe
///Laborator: Marti: 12-14
///Tema laborator: Proiect 1
///Data predare proiect: 15.03.2020
///Declaratie: Declar pe propria raspundere ca acest proiect nu a fost copiat din alte surse
///Bibliografie, surse de inspiratie: MSDN, Google.com, Stackoverflow.com, guru99.com
/// Links: https://www.guru99.com/c-sharp-access-database.html, https://social.msdn.microsoft.com/Forums/en-US/660a1f75-b287-4565-bfdd-75105e0a5527/c-wait-for-x-seconds?forum=netfxbcl
/// Links: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.picturebox?view=netframework-4.8, https://www.w3schools.com/sql/sql_alter.asp
///</summary>





namespace ClientWCF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
