using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 조건문
public class ConditionalStatements : MonoBehaviour
{
    public int input = 5;
    public int num = 10;

    bool result;
    void Start()
    {
        result = input > num;

        print(result);

        // if 조건문
        if(result)
        {
            print("input의 값이 num보다 큽니다.");
        }
        if(!result)
        {
            print("input의 값이 num보다 작습니다.");
        }


        if(input == num)
        {
            print("input의 값이 num과 같습니다.");
        }
        else if (input > num)
        {
            print("input의 값이 num보다 큽니다.");
        }
        else if (input < num)
        {
            print("input의 값이 num보다 작습니다.");
        }
        else
        {
            print("ERROR.");
        }


        // switch 조건문 
        switch (input)
        {
            case 4:
                print("input의 값은 4입니다.");
                break;
            case 5:
                print("input의 값은 5입니다.");
                break;
            case 6:
                print("input의 값은 6입니다.");
                break;
            default:
                print("Default Error.");
                break;
        }


        // 삼항 연산자
        int temp = input == num ? 1 : 0;     // (비교 연산자) ? TrueValue : FalseValue
        print(temp);
    }
}
