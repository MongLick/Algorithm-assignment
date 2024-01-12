using System;

public class UseKeyList
{
    List<int> list;

    /// <summary>
    /// 유저키 받고, list에 데이터 저장
    /// </summary>
    public void UseKeySave()
    {
        int userkey = UseKeySave2();
        this.list = new List<int>();

        for (int i = 0; i <= userkey; i++)
        {
            list.Add(i);
        }
    }

    /// <summary>
    /// list 0번째 데이터 빼기
    /// </summary>
    public void Remove()
    {
        list.RemoveAt(0);
    }

    /// <summary>
    /// list 모든 요소 출력하기
    /// </summary>
    public void Display()
    {
        foreach (int item in list)
        {
            Console.WriteLine($"{item}번 데이터");
        }
    }

    /// <summary>
    /// 새로운 유저키 받기
    /// </summary>
    public int UseKeySave2()
    {
        Console.WriteLine("리스트의 크기를 입력해주세요");
        int userkey = int.Parse(Console.ReadLine());
        return userkey;
    }

    /// <summary>
    /// 없던 경우는 추가, 있던 경우는 삭제
    /// </summary>
    public void AddRemove()
    {
        int userkey = UseKeySave2();

        if (list.Contains(userkey))
        {
            list.Remove(userkey);
        }
        else
        {
            list.Add(userkey);
        }

        Display();
    }
}
