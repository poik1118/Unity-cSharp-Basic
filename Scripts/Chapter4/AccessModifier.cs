using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 접근 지정자
public class Test
{
    // 변수
    private int a;
    public int b;

    public static int c;    // 공공(public)의 공유자원(static), 정적 변수


    // 함수
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

    Test a1 = new Test();   // 선언만 했기에 NULL 오류가 발생
    Test a2 = new Test();   // 할당을 하면 오류가 발생하지 않음
    Test a3 = new Test();

    void AB()
    {
        aaa.b = 5;                          // 보호수준이 public 이므로 Access 가능
        //aaa.a = 5;                        // 보호수준이 private이므로 Access 불가

        aaa.A1();                           // 보호수준이 public 이므로 Access 가능
        //aaa.A2();                         // 보호수준이 private이므로 Access 불가
    }

    void Abc()
    {
        a2.b = 5;
        a1.b = 1;
        a3.b = 10;

        print(a1.b);
        print(a2.b);
        print(a3.b);

        Test.c = 100;       // 공유 자원인 c를 클래스 형태로 접근,
        print(Test.c);      // 클래스 자체로 접근이 가능하기 때문에 수정에 용이
    }
    
    void Start()
    {
        Abc();
    }
}
