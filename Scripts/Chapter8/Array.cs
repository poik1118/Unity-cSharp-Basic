using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �迭
public class Array : MonoBehaviour
{
    // 1���� �迭
    public int[] array = { 10, 50, 100, 150, 200, 250 };
    int[] array1 = new int[10];    // �迭�� ũ�⸸ ����
    int[] array2;

    // 2���� �迭
    int[,] ary2 = { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 } };

    // 3���� �迭
    int[,,] ary3 = { { { 0, 1, 2, 3, 4, }, { 5, 6, 7, 8, 9 } }, { { 10, 20, 30, 40, 50 }, { 60, 70, 80, 90, 100 } } };
    void Start()
    {
        print(array[0]);
        print(array[1]);
        //print(array[6]);        // �迭�� 0 ~ 5���� �ֱ� ������ Error�߻�
        //array[6] = 100;         // ó�� ������ �迭�� ������ ������ �̻��� �迭�� ���� �Ұ�

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