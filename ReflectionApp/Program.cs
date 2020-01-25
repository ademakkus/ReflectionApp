using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Person);
            var properties = type.GetProperties(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Public);
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name);
            }
            Console.WriteLine("---------------------------------");

            
            var fields=type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
            foreach (var field in  fields)
            {
                Console.WriteLine(field.Name);
            }
            Console.ReadKey();
        }
    }
   class Person
    {
        int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        string _ad;

        public string Ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        string _soyad;

        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public string KisiBilgileriniGetir()
        {

            return string.Format("{0}.{1}{2}",_id,_ad,_soyad);
        }
        public Person(int id,string ad,string soyad)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;
        }
        public Person()
        {

        }

    }
}
