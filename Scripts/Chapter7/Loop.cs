using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 반복문
public class Loop : MonoBehaviour
{
    int num = 10;
    int i = 0;

    string text = "가나다라마바사";

    void Start()
    {
        // for 반복문
        for(int i = 0; i <= 10; i++)
        {
            print(i);
        }

        for (int i = 0; i <= 10; i += 2)
        {
            num = i;
            print(num);
        }

        for (; i < 10;)
        {
            print(i);
            i += 3;
        }
        
        for(; ; )
        {
            if (i >= 10)
                break;
            print(i);
            i += 2;
        }

        for(; ; )
        {
            i++;

            if (i % 2 == 0)     // i가 짝수일때
                continue;       // 해당 줄을 끝내고 다음 줄로 넘어감

            print(i);

            if (i > 10)
                break;          // 조건문 탈출
        }


        // while 반복문
        while (true)            // 무한 반복문
        {
            i++;
            if (num > 10)
                break;
            print(i);
        }

        do
        {
            i++;
            print(i);
        } while (i < 10);


        foreach(char a in text)     // string text를 char a로 쪼갠다
        {
            print(a);
        }
    }
}
