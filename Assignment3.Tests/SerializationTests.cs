using Assignment3;
using Assignment3.Utility;
using System.Reflection.Metadata;

namespace Assignment3.Tests
{
    [TestFixture]
    public class SerializationTests
    {
        private ILinkedListADT users;
        private string basePath;
        private string pathTxt;


        [SetUp]
        public void Setup()
        {
            //Uncomment the following line
            //ILinkedListADT users = new SLL();

            users = new SLL();

            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));

            basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            pathTxt = basePath + "\\Binary.txt";
        }

        [TearDown]
        public void TearDown()
        {
            users.Clear();
        }

        /// <summary>
        /// Tests the object was serialized.
        /// </summary>
        [Test]
        public void TestSerialization()
        {

            SerializationHelper.SerializeUsers(users, pathTxt);
            Assert.IsTrue(File.Exists(pathTxt));
        }

        /// <summary>
        /// Tests the object was deserialized.
        /// </summary>
        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers(users, pathTxt);
            ILinkedListADT deserializedUsers = SerializationHelper.DeserializeUsers(pathTxt);

            Assert.IsTrue(users.Count() == deserializedUsers.Count());

            for (int i = 0; i < users.Count(); i++)
            {
                User expected = users.GetValue(i);
                User actual = deserializedUsers.GetValue(i);

                Assert.AreEqual(expected.Id, actual.Id);
                Assert.AreEqual(expected.Name, actual.Name);
                Assert.AreEqual(expected.Email, actual.Email);
                Assert.AreEqual(expected.Password, actual.Password);
            }
        }
    }
}