using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Human : MonoBehaviour
{
    protected string humanName;         // public : 타 클래스에서 모두 사용 가능
    protected int humanAge;             // protected : 상속 받은 자식 클래스만 사용 가능

    protected virtual void Info()       // virtual : 다시 정의하기 위한 가상 함수
    {
        print("저는 HumanScript입니다.");
    }

    abstract protected void Name();     // abstact : 추상 함수(클래스도 추상 함수로 만들어줘야함)

    private void Start()
    {
        
    }
}
