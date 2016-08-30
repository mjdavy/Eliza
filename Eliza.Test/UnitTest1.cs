using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Eliza.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ElizaMain eliza = new ElizaMain();

            foreach (var s in new string[] { "Hello", "Well, and you?", "I'm implementing some weird project.", "Yes, can you give me technical advice?", "Thank you.", "Bye." })
            {
                Console.WriteLine("> {0}", s);
                Console.WriteLine("< {0}", eliza.ProcessInput(s));
            }
        }
    }
}
