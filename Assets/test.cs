using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public class Boss
    {
        private int hp = 100;          // �̗�
        private int power = 25; // �U����
        private int mp = 53;   //MP

        // �U���p�̊֐�
        public void Attack()
        {
            Debug.Log(this.power + "�̃_���[�W��^����");
        }

        // �h��p�̊֐�
        public void Defence(int damage)
        {
            Debug.Log(damage + "�̃_���[�W���󂯂�");
            // �c��hp�����炷
            this.hp -= damage;
        }
        //���@�U���p�̊֐�
        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp =  mp - 5;
                Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B");
            }
           else
            {
                Debug.Log("MP������Ȃ����߁C���@���g���Ȃ��B");
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
