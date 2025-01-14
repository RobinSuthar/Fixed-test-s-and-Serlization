﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment3;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    internal class LinkedListTest
    {
        private SLL _linkedList;

        [SetUp]

        public void Setup()
        {
            _linkedList = new SLL();
        }

        [Test]
        public void linkedList_isEmpty()
        {
            Assert.IsTrue(_linkedList.IsEmpty());
        }

        [Test]
        public void item_isPretended()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass"));
            Assert.IsFalse(_linkedList.IsEmpty());
        }

        [Test]
        public void item_isAppended() 
        {
            _linkedList.AddLast(new User(2, "User 2 ", "user2@gmail.com", "userpass2"));
            Assert.IsFalse(_linkedList.IsEmpty());
        }

        [Test]
        public void item_isInsertedAtIndex()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass1"));
            _linkedList.AddFirst(new User(2, "User 2", "user2@gmail.com", "userpass2"));
            _linkedList.AddFirst(new User(3, "User 3", "user3@gmail.com", "userpass3"));
            _linkedList.AddFirst(new User(4, "User 4", "user4@gmail.com", "userpass4"));
            _linkedList.Add(new User(12, "User New", "new@gmail.com", "userpassnew"), 2);
            Assert.AreEqual("User New", ((User)_linkedList.GetValue(2)).Name);
        }

        [Test]
        public void item_isReplaced()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass1"));
            _linkedList.AddFirst(new User(2, "User 2", "user2@gmail.com", "userpass2"));
            _linkedList.AddFirst(new User(3, "User 3", "user3@gmail.com", "userpass3"));
            _linkedList.AddFirst(new User(4, "User 4", "user4@gmail.com", "userpass4"));
            _linkedList.Replace(new User(6, "User Replace", "Replaceuser@gmail.com", "Replacepass3"),2);

            Assert.AreEqual("User Replace", _linkedList.GetValue(2).Name);
        }

        [Test]
        public void ItemDeleted_ListBeginning()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass1"));
            _linkedList.RemoveFirst();
            Assert.IsTrue(_linkedList.IsEmpty());
        }

        [Test]
        public void ItemDeleted_ListEnd()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass1"));
            _linkedList.AddFirst(new User(2, "User 2", "user2@gmail.com", "userpass2"));
            _linkedList.AddFirst(new User(3, "User 3", "user3@gmail.com", "userpass3"));
            _linkedList.AddFirst(new User(4, "User 4", "user4@gmail.com", "userpass4"));
            _linkedList.RemoveLast();
            Assert.AreEqual(null,_linkedList.GetValue(3));
        }

        [Test]
        public void ItemDeleted_ListMiddle()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmail.com", "userpass1"));
            _linkedList.AddFirst(new User(2, "User 2", "user2@gmail.com", "userpass2"));
            _linkedList.AddFirst(new User(3, "User 3", "user3@gmail.com", "userpass3"));
            _linkedList.AddFirst(new User(3, "User 4", "user4@gmail.com", "userpass4"));
            _linkedList.Remove(2);
            int a = _linkedList.Count();
            Assert.AreEqual(a, 3);
        }

        [Test]
        public void ExistingItem_Found()
        {
            User user1 = new User(1, "User 1", "user1@gmail.com", "userpass1");
            _linkedList.AddFirst(user1);
            Assert.AreEqual(user1, _linkedList.GetValue(0));
        }

        [Test]
        public void ReverseList_working()
        {
            _linkedList.AddFirst(new User(1, "User 1", "user1@gmmail.com", "userpass1"));
            _linkedList.AddLast(new User(2, "User 2", "user2@gmmail.com", "userpass2"));
            _linkedList.AddLast(new User(3, "User 3", "user1@gmmail.com", "userpass3"));
            _linkedList.AddLast(new User(4, "User 4", "user2@gmmail.com", "userpass4"));
            _linkedList.Reverse();
            Assert.AreEqual("User 4", ((User)_linkedList.GetValue(0)).Name);
            Assert.AreEqual("User 3", ((User)_linkedList.GetValue(1)).Name);
            Assert.AreEqual("User 2", ((User)_linkedList.GetValue(2)).Name);
            Assert.AreEqual("User 1", ((User)_linkedList.GetValue(3)).Name);

        }
    }
}
