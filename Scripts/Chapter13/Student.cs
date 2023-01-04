using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Human        // Student 클래스에 Human 클래스를 상속
{
    string schoolName;

    void Start()
    {
        schoolName = "OO대학교";
        humanName = "김철수";
        humanAge = 21;

        Info();
    }
    protected override void Info()  // override : 재 정의
    {
        base.Info();        // base : 부모 클래스(Human.cs의 Human)
        print("저는 "+schoolName+"학생 "+humanName+", "+humanAge+"살 입니다.");
    }

    protected override void Name()  // Name을 재 정의해 사용의 토대를 구축
    {
        print(humanName);
    }
}
