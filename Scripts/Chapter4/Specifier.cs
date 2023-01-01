using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Specifier : MonoBehaviour
{
    int a = 1;          // 멤버 변수, 전역 변수

    void Ab()
    {
        // 함수 호출이 존재하지 않으면 함수 내용은 존재하지 않는 상태임
        int a = 6;      // 지역 변수
        print(a);

        int b = 10;     // 지역 변수
        print(b);
    }
    //print(b);         // Ab함수 외 다른 위치 에서는 사용 불가

    void Abc()
    {
        int b = 5;      // Ab의 b와 다른 지역 변수
        print(b);
    }

    void Abcd(float _parameter)
    {
        // float _parameter는 매개변수
    }
    void Start()
    {
        print(a);
        Ab();
        Abc();
        Abcd(1);
    }
}
