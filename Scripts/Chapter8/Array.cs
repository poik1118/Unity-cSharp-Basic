using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 배열
public class Array : MonoBehaviour
{
    // 1차원 배열
    public int[] array = { 10, 50, 100, 150, 200, 250 };
    int[] array1 = new int[10];    // 배열의 크기만 선언
    int[] array2;

    // 2차원 배열
    int[,] ary2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };

    // 3차원 배열
    int[,,] ary3 = { { { 0, 1, 2, 3, 4, }, { 5, 6, 7, 8, 9 } }, { { 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 100 } } };
    void Start()
    {
        print(array[0]);
        print(array[1]);
        //print(array[6]);        // 배열이 0 ~ 5까지 있기 때문에 Error발생
        //array[6] = 100;         // 처음 선언한 배열의 범위를 넘으면 이상의 배열은 선언 불가

        for(int i = 0; i <= 5; i++)
        {
            print(array[i]);
        }

        for (int i = 0; i <= array.Length-1; i++)
        {
            print(array[i]);
        }

        array1[0] = 0;
        array1[1] = 1;

        array2 = new int[6];
        array2 = new int[array.Length];


        print(ary2[0, 0]);
        print(ary2[1, 1]);

        print(ary3[0, 0, 0]);
        print(ary3[0, 1, 2]);
        print(ary3[1, 1, 1]);
        print(ary3[1, 1, 4]);
    }
}