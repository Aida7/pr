using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLesson
{
    public class Program
    {
        static void Main(string[] args)
        {
            Accaunt accaunt = new Accaunt();
            accaunt.Add(100);
            //Print(" " + 200);
            accaunt.RegisterHender(new AccountOperationHander(new ConsoleSender().Print));

            //accaunt.RegisterHender(delegate (string text)
            //{
            //    Console.WriteLine("new message");
            //}
            accaunt.RegisterHender(text => Console.WriteLine("new message"+text));
            accaunt.RegisterHender(delegate (string text) { Console.WriteLine("new message" + text); });
            //{
            accaunt.Add(200);
            List<Accaunt> accounts = new List<Accaunt>();
            accounts.ForEach(accaunt2 => accaunt2.Sum = 0);


        } 
    }
}
 