using System;
using System.Collections.Generic;

namespace EFCoreRepositoryDatalog
{
    //  Information sources 
    //  Mosh Hamedani      https://www.youtube.com/watch?v=rtXpYpZdOzM
    //  Meziantou's BLOG   https://www.meziantou.net/2017/08/14/entity-framework-core-history-audit-table  




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App launched");
            Console.WriteLine("=================================================================================");
            RepositoryUnitofWork UofW = new RepositoryUnitofWork(new ApplicationDbContext());

            T_Person P = new T_Person() { Title = "Mr", FirstName = "John", LastName = "Smith" };
            T_Address A = new T_Address() { Line001 = "Line1", Line002 = "Line2", Line003 = "Line3", Line004 = "Line4", Line005 = "Line5", Code = "AAAA" };
            T_Address B = new T_Address() { Line001 = "Line1", Line002 = "Line2", Line003 = "Line3", Line004 = "Line4", Line005 = "Line5", Code = "BBBB" };
            List<T_Address> Addresses = new List<T_Address>();
            Addresses.Add(A);
            Addresses.Add(B);

            P.Addresses = Addresses;
            UofW.People.Add(P);
            UofW.Complete();

            var log = UofW.DBLog.ListAll();

            foreach(var I in log)
            {
                Console.WriteLine(" At :" + I.LogDateTime.ToString("HH:mm  dd/MM/yyyy")+  "Table :" + I.TableName + " key :" + I.TablePKName + " " + I.TablePKValue + " Event :" + I.Event + " Detail :" + I.Detail);
            }

            Console.WriteLine("Press return to close App. ");
            Console.WriteLine("=================================================================================");
            Console.ReadLine();
        }
    }
}
