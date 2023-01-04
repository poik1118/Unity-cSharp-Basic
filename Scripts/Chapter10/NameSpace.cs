using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Name;
using Name.Space;
// 네임스페이스 : 라이브러리를 가져와 활용에 용이함

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
