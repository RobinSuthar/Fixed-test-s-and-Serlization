using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment3
{
    public static class SerializationHelper
    {
        /// <summary>
        /// Serializes (encodes) users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileName"></param>
        /// 
      

        public static void SerializeUsers(ILinkedListADT users, string fileName)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();    
            using(FileStream fs = new FileStream(fileName , FileMode.OpenOrCreate))
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
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                ILinkedListADT users = (ILinkedListADT)binaryFormatter.Deserialize(fs);

                return users;
               
            }

        }

     
    }
}
