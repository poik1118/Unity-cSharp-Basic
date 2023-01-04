using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Human : MonoBehaviour
{
    protected string humanName;         // public : Ÿ Ŭ�������� ��� ��� ����
    protected int humanAge;             // protected : ��� ���� �ڽ� Ŭ������ ��� ����

    protected virtual void Info()       // virtual : �ٽ� �����ϱ� ���� ���� �Լ�
    {
        print("���� HumanScript�Դϴ�.");
    }

    abstract protected void Name();     // abstact : �߻� �Լ�(Ŭ������ �߻� �Լ��� ����������)

    private void Start()
    {
        
    }
}
