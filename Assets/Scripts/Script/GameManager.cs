using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    


    public static GameManager Instance { get; private set; }


    public GameObject cutIn;


    public float speed = 4;

    public float hp;//ヘルスポイント(健康度)

    public int ep;//エクササイズポイント(運動値)

    public int sp;//スタディポイント(学習値)


    public string job;

    public int time =1;


    //public int[] item = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };


    public player player;

    //プレイヤーの見た目

    public GameObject syougakusei;

    public GameObject tyuugakusei;

    public GameObject yakyuusennsyu;

    public GameObject isya;

    public GameObject niret;


    private void Awake()
    {
        // シングルトンパターンの実装
        if (Instance == null)
        {
            // 既存のゲームマネージャーインスタンスがない場合、
            // 現在のインスタンスを設定し、シーン遷移時に破棄されないようにします
            Instance = this;
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
        Random.InitState(System.DateTime.Now.Millisecond);
    }

    // Update is called once per frame
    void Update()
    {
        

        hp = player.hp;

        ep = player.ep;

        sp = player.sp;

        if (player.age == 1)
        {
            job = "小学生";

            
        }
        if (player.age == 13)
        {
            job = "中学生";

            cutIn.SetActive(true);
            time = 0;

            
            Time.timeScale = 0;


            //player.Pause();


            //if(Input.GetKeyDown("space"))
            //{
            //    player.Resume();
            //}


        }
        if(player.age == 19)
        {
            if (ep >= 10 || sp >= 10)
            {
                if (ep > sp)
                {
                    
                    job = "野球選手";

                    cutIn.SetActive(true);
                    time = 0;

                    Time.timeScale = 0;

                }
                else
                {
                    
                    job = "医者";

                    cutIn.SetActive(true);
                    time = 0;

                    Time.timeScale = 0;

                }
            }
            else
            {
                
                job = "ニート";

                cutIn.SetActive(true);
                time = 0;


                Time.timeScale = 0;

            }
        }
        if (player.Instance.age == 30)
        {
            job = "老いぼれ";

            cutIn.SetActive(true);
            time = 0;

            Time.timeScale = 0;

        }
        
    }
    
}
