using System;

public class LinkedList
{
    public static void Linked()
    {
        LinkedList<int> linkedList = new LinkedList<int>();

        int userkey = 0;

        Console.WriteLine("몇 번 반복할지 입력해주세요");
        int repeat = int.Parse(Console.ReadLine());

        for (int i = 0; i < repeat; i++)
        {
            do
            {
                try
                {
                    Console.WriteLine("\n숫자를 입력해주세요");
                    userkey = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("숫자 형식이 아닙니다. 숫자를 입력해주세요");
                }
            } while (userkey == 0);

            if (userkey > 0)
            {
                linkedList.AddLast(userkey);
            }
            else
            {
                linkedList.AddFirst(userkey);
            }

            foreach (int item in linkedList)
            {
                Console.Write(item);
            }
        }
    }

    public class Permutation
    {
        static void Josephus()
        {


            Console.WriteLine("사람의 수를 정해주세요");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("제거 될 사람이 몇번 째 마다인지 정해주세요");
            int k = int.Parse(Console.ReadLine());

            LinkedList<int> linkedList = new LinkedList<int>();

            for (int i = 1; i <= n; i++)
            {
                linkedList.AddFirst(i);
            }

            foreach (int item in linkedList)
            {
                Console.Write(item);
            }

            for (int i = 0; i < k; i++)
            {
                linkedList.RemoveFirst();
            }

            for (int i = 1; i < k; i++)
            {
                linkedList.AddLast(i);
            }
        }
    }
}
