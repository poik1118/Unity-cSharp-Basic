using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �ݺ���
public class Loop : MonoBehaviour
{
    int num = 10;
    int i = 0;

    string text = "�����ٶ󸶹ٻ�";

    void Start()
    {
        // for �ݺ���
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

            if (i % 2 == 0)     // i�� ¦���϶�
                continue;       // �ش� ���� ������ ���� �ٷ� �Ѿ

            print(i);

            if (i > 10)
                break;          // ���ǹ� Ż��
        }


        // while �ݺ���
        while (true)            // ���� �ݺ���
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


        foreach(char a in text)     // string text�� char a�� �ɰ���
        {
            print(a);
        }
    }
}
