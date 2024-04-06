using Assignment3.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            User users1 = new User(1,"Test1","Test@gmail.co,","as");
            User users2 = new User(1, "Test1", "Test@gmail.co,", "as");
            User users3 = new User(1, "Test1", "Test@gmail.co,", "as");
            User users4 = new User(1, "Test1", "Test@gmail.co,", "as");

            SLL Linkedlist = new SLL();

            Linkedlist.AddLast(users1);
            Linkedlist.AddLast(users2);
            Linkedlist.AddLast(users3);
            Linkedlist.AddLast(users4);

            string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName; 
            string pathTxt = basePath + "\\Bnewinary.txt";

            SerializationHelper.SerializeUsers(Linkedlist, pathTxt);
            SerializationHelper.DeserializeUsers(pathTxt);

            Console.WriteLine("Serlization completed.");

        
        }

    }
 }
