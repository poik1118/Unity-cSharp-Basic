using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������
public class Test
{
    // ����
    private int a;
    public int b;

    public static int c;    // ����(public)�� �����ڿ�(static), ���� ����


    // �Լ�
    public void A1()
    {

    }
    private void A2()
    {

    }
}

public class AccessModifier : MonoBehaviour
{
    Test aaa;

    Test a1 = new Test();   // ���� �߱⿡ NULL ������ �߻�
    Test a2 = new Test();   // �Ҵ��� �ϸ� ������ �߻����� ����
    Test a3 = new Test();

    void AB()
    {
        aaa.b = 5;                          // ��ȣ������ public �̹Ƿ� Access ����
        //aaa.a = 5;                        // ��ȣ������ private�̹Ƿ� Access �Ұ�

        aaa.A1();                           // ��ȣ������ public �̹Ƿ� Access ����
        //aaa.A2();                         // ��ȣ������ private�̹Ƿ� Access �Ұ�
    }

    void Abc()
    {
        a2.b = 5;
        a1.b = 1;
        a3.b = 10;

        print(a1.b);
        print(a2.b);
        print(a3.b);

        Test.c = 100;       // ���� �ڿ��� c�� Ŭ���� ���·� ����,
        print(Test.c);      // Ŭ���� ��ü�� ������ �����ϱ� ������ ������ ����
    }
    
    void Start()
    {
        Abc();
    }
}
