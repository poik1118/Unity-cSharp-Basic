 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 제네릭 - 형식 매개 변수 T

public class Test<T>{       // 어느 타입이 올지 모를때 사용
    public T var;
    public T[] array;
}

public class Generic : MonoBehaviour
{
    void Print(int value){
        print(value);
    }
    void Print(string value){
        print(value);
    }
    void Print(float value){
        print(value);
    }

    void Print<T>(T value) where T : struct{
        print(value);
    }

    Test<string> a; 
    Test<float> b; 

    void Start()
    {
        Print(1);       // Print(int value) 자동 호출
        Print("");      // Print(string value) 자동 호출
        Print(1.0f);    // Print(float value) 자동 호출

        Print<int>(1);
        //Print<string>("abc");     // struct(값) 형태만 허용 가능 상태
        Print<float>(1.5f);

        a.var = "abc";
        b.var = 4.5f;

        a.array = new string[1];
        b.array = new float[1];

        a.array[0] = "abc";
        b.array[0] = 4.5f;

    }
}
