using System;
using System.Collections;

namespace prak4_02_upr02
{
  class Program
  {
    static void Main(string[] args)
    {
      Stack stack = new Stack();
      stack.Push("1");
      stack.Push("2");
      stack.Push("TRUB");
      stack.Push("4");
      while (stack.Count > 0)
      {
        object obj = stack.Pop();
        Console.WriteLine("'From Stack: {0}", obj);
      }

    }
  }
}