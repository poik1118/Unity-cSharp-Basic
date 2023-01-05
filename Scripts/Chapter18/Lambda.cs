using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 람다식 : (int n) => return n;    매개변수 n을 받고, 그 n을 반환하는 식
public class Lambda : MonoBehaviour
{
    int a = 5;
    int b = 5;

    int sum;

    void Add(){         // sum을 계산하고 sum을 0으로 만듬
        sum = a+b;
        //Back();         // Add만 호출 하고 싶을때 Back이 종속되어 있는 문제 발생
    }
    void Print(){       // sum을 출력하기 위한 함수 생성, 호출
        print(sum);     // 이는 코드를 오히려 복잡하게 만든다. 
    }
    void Back(){
        sum = 0;
    }

    delegate void MyDelegate();
    MyDelegate myDelegate;


    delegate void MyDelegateTest<T>(T x, T y);
    MyDelegateTest<int> myDelegateTest;

    void Start()
    {
        myDelegate = Add;

        //myDelegate += Print;    // 단순히 sum을 출력하기 위한 함수 생성, 호출
        //myDelegate += delegate(){ print(sum); };    // 무명 메소드를 통해 함수를 만들지 않고 델리게이트 안에 삽입 후 호출
        myDelegate += () => print(sum); // 람다식형태로 sum호출(무명 메소드를 단순화 시킨 형태)

        myDelegate += Back;

        myDelegate();


        myDelegateTest += (int x, int y) => print(x+y);
        myDelegateTest(3, 5);
    }
}
