using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���ǹ�
public class ConditionalStatements : MonoBehaviour
{
    public int input = 5;
    public int num = 10;

    bool result;
    void Start()
    {
        result = input > num;

        print(result);

        // if ���ǹ�
        if(result)
        {
            print("input�� ���� num���� Ů�ϴ�.");
        }
        if(!result)
        {
            print("input�� ���� num���� �۽��ϴ�.");
        }


        if(input == num)
        {
            print("input�� ���� num�� �����ϴ�.");
        }
        else if (input > num)
        {
            print("input�� ���� num���� Ů�ϴ�.");
        }
        else if (input < num)
        {
            print("input�� ���� num���� �۽��ϴ�.");
        }
        else
        {
            print("ERROR.");
        }


        // switch ���ǹ� 
        switch (input)
        {
            case 4:
                print("input�� ���� 4�Դϴ�.");
                break;
            case 5:
                print("input�� ���� 5�Դϴ�.");
                break;
            case 6:
                print("input�� ���� 6�Դϴ�.");
                break;
            default:
                print("Default Error.");
                break;
        }


        // ���� ������
        int temp = input == num ? 1 : 0;     // (�� ������) ? TrueValue : FalseValue
        print(temp);
    }
}
