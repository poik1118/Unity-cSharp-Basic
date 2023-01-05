using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 인터페이스

abstract public class A : MonoBehaviour{        // 추상 클래스
    abstract public void Abc();
}

interface ITest{            // 뼈대 제공, 다중 상속, 
    void aBc();
    int Salary{get; set; }  // 변수 생성 불가(함수, 프로퍼티. 인덱서, 이벤트만 선언 가능)
}
interface ITest2 : ITest{
    // ITest를 ITest2에 상속을 시킬 수 있다.(인터페이스끼리 상속)
}

public class Interface : A, ITest2          // 클래스 상속은 1가지만 가능(인터페이스 이용)
{
    public int Salary       // Interface ITest's Salary
    { 
        get => throw new System.NotImplementedException(); 
        set => throw new System.NotImplementedException(); 
    }

    public override void Abc()
    {
        print("Abc");
    }
    public void aBc()
    {
        print("aBc");
    }
    void Start()
    {
        
    }
}
