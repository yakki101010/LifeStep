using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public static player Instance { get; private set; }


    int playerSituation = 0;//0は着地中.1はジャンプ1回目.2はジャンプ２回目

    Rigidbody2D rbody;

    //プレイヤーのステータス

    public float hp = 20;//ヘルスポイント(健康度)

    public int ep = 0;//エクササイズポイント(運動値)

    public int sp = 0;//スタディポイント(学習値)

    //public float speed = 1;

    public float jumpPower = 4;

    public int age = 1;//年齢

    bool jumpN = false;

    //内部データ?

    bool jumpFlag = false;

    private void Awake()
    {
        // シングルトンパターンの実装
        if (Instance == null)
        {
            // 既存のゲームマネージャーインスタンスがない場合、
            // 現在のインスタンスを設定し、シーン遷移時に破棄されないようにします
            Instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既存のゲームマネージャーインスタンスがある場合、
            // 重複を避けるために現在のインスタンスを破棄します
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


            if (age >= 30)//30才1ずつ減る
            {
                
                    hp = hp - 1;
                
            }
            //if (age >= 60)//60才2ずつ減る
            //{
                
            //        hp = hp - 1;
                
            //}
            //if (age >= 70)//70才4ずつ減る
            //{
                
            //        hp = hp - 2;
                
            //}
            //if (age >= 80)//80才8ずつ減る
            //{
                
            //        hp = hp - 4;
                
            //}
            //if (age >= 90)//90才16ずつ減る
            //{
                
            //        hp = hp - 8;
                
            //}
            if (age >= 100)//100才2ずつ減る
            {
                
                    hp = hp - 1;
                
            }
        }




        if (Input.GetKeyDown("space") && playerSituation == 0 || Input.GetMouseButtonDown(0) && playerSituation == 0 )
        {
            jumpFlag = true;
            Debug.Log("ジャンプ");

        }
        else if (Input.GetKeyDown("space") && playerSituation == 1 || Input.GetMouseButtonDown(0) && playerSituation == 1 )
        {
            jumpFlag = true;
            Debug.Log("ジャンプ");

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

        if(hp < 5)//ジャンプ力の設定
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
