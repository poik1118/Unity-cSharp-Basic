using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 프로퍼티(속성) : 보안성이 높다.

public class Salary : MonoBehaviour
{
    private int salary;
    private int bonus = 10;

    public int SalaryP { get { return salary + bonus; } 
                 private set { if(value < 0) salary = 10; else salary = value; } }
    //public int SalaryP { get { return salary + bonus; } } // set을 제거해 수정 불가능 상태로 만듬

    public int Bonus { get; set; }  // 변수 역할을 하는 단순한 형태의 Property

    void Start()
    {
        SalaryP = 10;   // value에 10이 들어가고 salary는 10이 된다.(읽기/쓰기)
        //salary = 10;  // set을 제거한 경우 salary의 값을 변경해준다.
        print(SalaryP);

        Bonus = 10;
        print(Bonus);
    }
}
