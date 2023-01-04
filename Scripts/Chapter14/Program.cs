using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Program : MonoBehaviour
{
    Salary mySalary = new Salary();

    void Start()
    {
        //mySalary.SalaryP = 50;    // private로 접근 제한을해 값 입력 불가
        print(mySalary.SalaryP);    // 값을 호출
        
    }
}
