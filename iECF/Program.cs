using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace iECF
{
    class Program
    {
        private Comp_ElectronicosEntities1 db1 = new Comp_ElectronicosEntities1();
        static void Main(string[] args)
        {
            FormInicial form = new FormInicial();
            form.ShowDialog();
            /*int opcion = 0;

            opcion = Int32.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    break;
                case 2:
                    //new Thread(new ThreadStart(IniciaFormulario)).Start();
                    Console.ReadKey();




                    break;
                case 3:
                     

                    break;


                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }*/
           

        }


       
        }

   
    


}
