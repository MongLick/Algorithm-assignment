using System.Collections.Generic;
using System.Linq;

namespace _99.test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 24.01.11 1~4번 문제

            UseKeyList useKeyList = new UseKeyList();
            useKeyList.UseKeySave();
            useKeyList.Remove();
            useKeyList.Display();


            // 24.01.11 5번 문제
            useKeyList.AddRemove();


            // 24.01.12 1~3번 문제
            LinkedList linkedList = new LinkedList();
            LinkedList.Linked();
        }
    } 
}
