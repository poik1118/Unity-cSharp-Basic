using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specifier : MonoBehaviour
{
    int a = 1;          // ��� ����, ���� ����

    void Ab()
    {
        // �Լ� ȣ���� �������� ������ �Լ� ������ �������� �ʴ� ������
        int a = 6;      // ���� ����
        print(a);

        int b = 10;     // ���� ����
        print(b);
    }
    //print(b);         // Ab�Լ� �� �ٸ� ��ġ ������ ��� �Ұ�

    void Abc()
    {
        int b = 5;      // Ab�� b�� �ٸ� ���� ����
        print(b);
    }

    void Abcd(float _parameter)
    {
        // float _parameter�� �Ű�����
    }
    void Start()
    {
        print(a);
        Ab();
        Abc();
        Abcd(1);
    }
}
