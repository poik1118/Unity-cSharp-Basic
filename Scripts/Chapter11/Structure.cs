using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ����ü

// struct : class�� �޸� ����� �Ұ�����     stuct = ��Ÿ��, class = �ּ�Ÿ��
public struct Youtube
{
    public int a;
    public int b;
    public int c;
    public int d;

    public Youtube(int _a, int _b, int _c, int _d)      // ������
    {
        a = _a; b = _b; c = _c; d = _d;                 // ���� ��Ī
    }

    public void GetA(int value)
    {
        a = value;
    }
}

// enum (����)
public enum Item        // ����ڰ� �ְ� ���� ���� ���� �� �ִ�.
{
    Weapon,
    Shield,
    Potion,
}

public class Structure : MonoBehaviour
{
    Youtube keidy;
    Youtube test = new Youtube(1, 2, 3, 4);     // ����� ������ ���ÿ� �̷����


    Item item;

    void Start()
    {
        keidy.a = 5;
        keidy.GetA(5);

        print(keidy.a);

        print(test.a);
        print(test.b);


        item = Item.Weapon;
        print(item);

        item = Item.Shield;
        print(item);
    }
}