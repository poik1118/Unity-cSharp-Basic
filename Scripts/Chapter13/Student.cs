using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Human        // Student Ŭ������ Human Ŭ������ ���
{
    string schoolName;

    void Start()
    {
        schoolName = "OO���б�";
        humanName = "��ö��";
        humanAge = 21;

        Info();
    }
    protected override void Info()  // override : �� ����
    {
        base.Info();        // base : �θ� Ŭ����(Human.cs�� Human)
        print("���� "+schoolName+"�л� "+humanName+", "+humanAge+"�� �Դϴ�.");
    }

    protected override void Name()  // Name�� �� ������ ����� ��븦 ����
    {
        print(humanName);
    }
}
