using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//������

public class Operator : MonoBehaviour
{
    int a = 10;
    int b = 3;
    int c = 0;

    bool d = false;
    void Start()
    {
        // �⺻ ������ : +, -, *, /, %, = ... 
        // ���� ������(����, ����) : ++, -- ...
        print(a + b);
        print(a - b);
        print(a * b);
        print(a / b);
        print(a % b);

        a = a + b;      // ���� ������
        print(a);
        a = 10;
        a += b;         // ���� ���� ������
        print(a);
        a = 10;

        a = a * b;
        print(a);
        a = 10;
        a *= b;
        print(a);

        c = c + 1;
        print(c);
        c += 1;
        print(c);
        print(c++);
        print(++c);
        print(c);

        d = (a == b);   // ���� ������
        print(d);
        d = (a != b);
        print(d);
        d = (a > b);
        print(d);
        d = (a <= b);
        print(d);
        d = (a != b) && (a == b);   // false and true ==> false
        print(d);
        d = (a > b) || (a < b);     //  ture or false ==> true
        print(d);
        d = ((a != b) || (a == b) && a > b);
        print(d);
        d = !(a > b);       // NOT true ==> false
    }
}
