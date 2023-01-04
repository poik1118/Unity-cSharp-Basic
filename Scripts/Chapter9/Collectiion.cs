using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 컬렉션
public class Collectiion : MonoBehaviour
{
    // 기본 배열형태
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // ArrayList
    ArrayList arrayList = new ArrayList();      // 하나의 클래스

    // List
    List<int> list = new List<int>();           // List<자료형> 변수명

    // HashTable
    Hashtable hashTable = new Hashtable();

    // Dictionary
    Dictionary<string, int> dictionary = new Dictionary<string, int>();     // Dictionary<Key, Value> 변수명

    // Queue, 선입 선출 (FIFO)
    Queue<int> queue = new Queue<int>();

    // Stack, 후입 선출 (LIFO)
    Stack<int> stack = new Stack<int>();

    void Start()
    {
        // ArrayList
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("가나다라");
        arrayList.Add(4.5);

        print(arrayList.Count);

        arrayList.Remove("가나다라");        // 특정 값을 제거
        arrayList.RemoveAt(3);               // 3번째의 값을 제거
        arrayList.RemoveRange(1, 1);         // 1번째의 값을 제거

        arrayList[0] = 10;                // 값 변경

        arrayList.Insert(1, 1.5);            // 1번째 인덱스 사이에 값을 추가

        //arrayList.Clear();                 // 초기화

        print(arrayList.Contains("가나다라"));      // 특정 값이 존재하면 True를 반환

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }


        // List
        list.Add(1);
        print(list[0]);
        //list.Add(1.5);      // List 자료형을 int로 지정해서 float는 사용 불가
        //list.Add("2");      // List 자료형을 int로 지정해서 string은 사용 불가


        // Hash Table
        hashTable.Add("일만", 10000);     // (Key, Value)
        hashTable.Add("백만", 1000000);

        print(hashTable[0]);
        print(hashTable["일만"]);

        hashTable.Add(50, "일억");
        print(hashTable[50]);


        // Dictionary
        dictionary.Add("가", 100);       // (StringKey, IntValue)

        //Queue
        queue.Enqueue(5);
        queue.Enqueue(10);

        if(queue.Count != 0)
            print(queue.Dequeue());     // 5  출력
        if (queue.Count != 0)
            print(queue.Dequeue());     // 10 출력
        if (queue.Count != 0)
            print(queue.Dequeue());     // queue안에 값이 존재하지 않아 출력하지 않음

        // Stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        if(stack.Count != 0)
            print(stack.Pop());         // 3  출력
        if (stack.Count != 0)
            print(stack.Pop());         // 2  출력
        if (stack.Count != 0)
            print(stack.Pop());         // 1  출력
        if (stack.Count != 0)
            print(stack.Pop());         // stack안에 값이 존재하지 않아 출력하지 않음
    }
}