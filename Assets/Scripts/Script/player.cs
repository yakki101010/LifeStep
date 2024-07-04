using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public static player Instance { get; private set; }


    int playerSituation = 0;//0�͒��n��.1�̓W�����v1���.2�̓W�����v�Q���

    Rigidbody2D rbody;

    //�v���C���[�̃X�e�[�^�X

    public float hp = 20;//�w���X�|�C���g(���N�x)

    public int ep = 0;//�G�N�T�T�C�Y�|�C���g(�^���l)

    public int sp = 0;//�X�^�f�B�|�C���g(�w�K�l)

    //public float speed = 1;

    public float jumpPower = 4;

    public int age = 1;//�N��

    bool jumpN = false;

    //�����f�[�^?

    bool jumpFlag = false;

    private void Awake()
    {
        // �V���O���g���p�^�[���̎���
        if (Instance == null)
        {
            // �����̃Q�[���}�l�[�W���[�C���X�^���X���Ȃ��ꍇ�A
            // ���݂̃C���X�^���X��ݒ肵�A�V�[���J�ڎ��ɔj������Ȃ��悤�ɂ��܂�
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            // �����̃Q�[���}�l�[�W���[�C���X�^���X������ꍇ�A
            // �d��������邽�߂Ɍ��݂̃C���X�^���X��j�����܂�
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;

        //ageUp();
    }


// Update is called once per frame

public float t = 0;
    void Update()
    {
        

            t = t + Time.deltaTime * GameManager.Instance.time;

            if (t >= 1.5f)
            {
                age = age + 1;
                t = 0;

                Debug.Log(age);


            if (age >= 30)//30��1������
            {
                
                    hp = hp - 1;
                
            }
            //if (age >= 60)//60��2������
            //{
                
            //        hp = hp - 1;
                
            //}
            //if (age >= 70)//70��4������
            //{
                
            //        hp = hp - 2;
                
            //}
            //if (age >= 80)//80��8������
            //{
                
            //        hp = hp - 4;
                
            //}
            //if (age >= 90)//90��16������
            //{
                
            //        hp = hp - 8;
                
            //}
            if (age >= 100)//100��2������
            {
                
                    hp = hp - 1;
                
            }
        }




        if (Input.GetKeyDown("space") && playerSituation == 0 || Input.GetMouseButtonDown(0) && playerSituation == 0 )
        {
            jumpFlag = true;
            Debug.Log("�W�����v");

        }
        else if (Input.GetKeyDown("space") && playerSituation == 1 || Input.GetMouseButtonDown(0) && playerSituation == 1 )
        {
            jumpFlag = true;
            Debug.Log("�W�����v");

            playerSituation = 2;
        }
        if (Input.GetKeyUp("space") || Input.GetMouseButtonUp(0))
        {
            jumpN = false;
        }

        if (hp < 1)
        {
            Destroy(gameObject);
        }

        if(hp > 20)
        {
            hp = 20;
        }
        if(ep > 20)
        {
            ep = 20;
        }
        if (sp > 20)
        {
            sp = 20;
        }
        if (ep < 0)
        {
            ep = 0;
        }
        if (sp < 0)
        {
            sp = 0;
        }

        if(hp < 5)//�W�����v�͂̐ݒ�
        {
            jumpPower = 4;
        }
        else if(hp< 10)
        {
            jumpPower = 5.5f;
        }
        else if(hp < 15)
        {
            jumpPower = 4.5f;
        }
        else if (hp < 20)
        {
            jumpPower = 5;
        }
        else if (hp == 20)
        {
            jumpPower = 6;
        }
        

    }
    private void FixedUpdate()
    {
        //rbody.velocity = new Vector2(speed, rbody.velocity.y);

        if (jumpFlag)
        {
            jumpFlag = false;

            rbody.velocity = new Vector2(rbody.velocity.x, 0);

            rbody.AddForce(new Vector2(0,jumpPower), ForceMode2D.Impulse);
        }
        if(jumpN == false)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, rbody.velocity.y * 0.8f);

            jumpN = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 6 )
        {
            playerSituation = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6)
        {
            playerSituation = 1;
        }
            
    }
    //void ageUp()
    //{
    //    float t = 0;

    //    while (age >= 100)
    //    {

    //        t = t + Time.deltaTime;

    //        if (t >= 1)
    //        {
    //            age = age + 1;
    //            t = 0;

    //            Debug.Log(age);
    //        }
            
    //    }
    //}



}
