using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 구조체

// struct : class와 달리 상속이 불가능함     stuct = 값타입, class = 주소타입
public struct Youtube
{
    public int a;
    public int b;
    public int c;
    public int d;

    public Youtube(int _a, int _b, int _c, int _d)      // 생성자
    {
        a = _a; b = _b; c = _c; d = _d;                 // 변수 매칭
    }

    public void GetA(int value)
    {
        a = value;
    }
}

// enum (열거)
public enum Item        // 사용자가 넣고 싶은 값만 넣을 수 있다.
{
    Weapon,
    Shield,
    Potion,
}

public class Structure : MonoBehaviour
{
    Youtube keidy;
    Youtube test = new Youtube(1, 2, 3, 4);     // 선언과 생성이 동시에 이루어짐


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