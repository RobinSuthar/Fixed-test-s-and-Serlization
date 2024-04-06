using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    public static class SerializationHelper
    {

        /// <summary>
        /// Serializes (encodes) users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileName"></param>
        public static void SerializeUsers(ILinkedListADT users, string fileName)
        {
            string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string Binarytext = basePath + "/binarySerlization";

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, users);
            }
        }

        /// <summary>
        /// Deserializes (decodes) users
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns>List of users</returns>
        public static ILinkedListADT DeserializeUsers(string fileName)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(fileName, FileMode.Open)) 
            {
                SLL u1 = (SLL)binaryFormatter.Deserialize(fs);

                return u1;
            }

            return null;
        }
    }
}
