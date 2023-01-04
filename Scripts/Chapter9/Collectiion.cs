using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// �÷���
public class Collectiion : MonoBehaviour
{
    // �⺻ �迭����
    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    // ArrayList
    ArrayList arrayList = new ArrayList();      // �ϳ��� Ŭ����

    // List
    List<int> list = new List<int>();           // List<�ڷ���> ������

    // HashTable
    Hashtable hashTable = new Hashtable();

    // Dictionary
    Dictionary<string, int> dictionary = new Dictionary<string, int>();     // Dictionary<Key, Value> ������

    // Queue, ���� ���� (FIFO)
    Queue<int> queue = new Queue<int>();

    // Stack, ���� ���� (LIFO)
    Stack<int> stack = new Stack<int>();

    void Start()
    {
        // ArrayList
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(3);
        arrayList.Add("�����ٶ�");
        arrayList.Add(4.5);

        print(arrayList.Count);

        arrayList.Remove("�����ٶ�");        // Ư�� ���� ����
        arrayList.RemoveAt(3);               // 3��°�� ���� ����
        arrayList.RemoveRange(1, 1);         // 1��°�� ���� ����

        arrayList[0] = 10;                // �� ����

        arrayList.Insert(1, 1.5);            // 1��° �ε��� ���̿� ���� �߰�

        //arrayList.Clear();                 // �ʱ�ȭ

        print(arrayList.Contains("�����ٶ�"));      // Ư�� ���� �����ϸ� True�� ��ȯ

        for (int i = 0; i < arrayList.Count; i++)
        {
            print(arrayList[i]);
        }


        // List
        list.Add(1);
        print(list[0]);
        //list.Add(1.5);      // List �ڷ����� int�� �����ؼ� float�� ��� �Ұ�
        //list.Add("2");      // List �ڷ����� int�� �����ؼ� string�� ��� �Ұ�


        // Hash Table
        hashTable.Add("�ϸ�", 10000);     // (Key, Value)
        hashTable.Add("�鸸", 1000000);

        print(hashTable[0]);
        print(hashTable["�ϸ�"]);

        hashTable.Add(50, "�Ͼ�");
        print(hashTable[50]);


        // Dictionary
        dictionary.Add("��", 100);       // (StringKey, IntValue)

        //Queue
        queue.Enqueue(5);
        queue.Enqueue(10);

        if(queue.Count != 0)
            print(queue.Dequeue());     // 5  ���
        if (queue.Count != 0)
            print(queue.Dequeue());     // 10 ���
        if (queue.Count != 0)
            print(queue.Dequeue());     // queue�ȿ� ���� �������� �ʾ� ������� ����

        // Stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        if(stack.Count != 0)
            print(stack.Pop());         // 3  ���
        if (stack.Count != 0)
            print(stack.Pop());         // 2  ���
        if (stack.Count != 0)
            print(stack.Pop());         // 1  ���
        if (stack.Count != 0)
            print(stack.Pop());         // stack�ȿ� ���� �������� �ʾ� ������� ����
    }
}