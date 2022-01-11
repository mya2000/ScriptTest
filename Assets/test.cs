using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public class Boss
    {
        private int hp = 100;          // 体力
        private int power = 25; // 攻撃力
        private int mp = 53;   //MP

        // 攻撃用の関数
        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        // 防御用の関数
        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            // 残りhpを減らす
            this.hp -= damage;
        }
        //魔法攻撃用の関数
        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp =  mp - 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
            }
           else
            {
                Debug.Log("MPが足りないため，魔法が使えない。");
            }
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 2, 3, 5, 7, 11 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        Boss mage = new Boss();

        for (int i = 0; i <= 10; i++)
        {
            mage.Magic();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
