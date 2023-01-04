using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Name;
using Name.Space;
// ���ӽ����̽� : ���̺귯���� ������ Ȱ�뿡 ������

namespace Name
{
    namespace Space
    {

        public class Youtube
        {
            int like;

            public void setLike(int value)
            {
                like = value;
            }

            public bool isLike()
            {
                return like != 0;
            }
        }
    }

    public class Youtube
    {
        public int subscribe;
    }
}

public class NameSpace : MonoBehaviour
{
    Name.Youtube subTest;

    Name.Space.Youtube likeTest;

    private void Start()
    {
        subTest = new Name.Youtube();

        subTest.subscribe = 5;
        print("subscribeValue = " + subTest.subscribe);


        likeTest = new Name.Space.Youtube();

        likeTest.setLike(5);
        print("isLike = "+likeTest.isLike());
    }

}
