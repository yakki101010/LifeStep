using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    


    public static GameManager Instance { get; private set; }


    public GameObject cutIn;


    public float speed = 4;

    public float hp;//�w���X�|�C���g(���N�x)

    public int ep;//�G�N�T�T�C�Y�|�C���g(�^���l)

    public int sp;//�X�^�f�B�|�C���g(�w�K�l)


    public string job;

    public int time =1;


    //public int[] item = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0 };


    public player player;

    //�v���C���[�̌�����

    public GameObject syougakusei;

    public GameObject tyuugakusei;

    public GameObject yakyuusennsyu;

    public GameObject isya;

    public GameObject niret;


    private void Awake()
    {
        // �V���O���g���p�^�[���̎���
        if (Instance == null)
        {
            // �����̃Q�[���}�l�[�W���[�C���X�^���X���Ȃ��ꍇ�A
            // ���݂̃C���X�^���X��ݒ肵�A�V�[���J�ڎ��ɔj������Ȃ��悤�ɂ��܂�
            Instance = this;
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
            job = "���w��";

            
        }
        if (player.age == 13)
        {
            job = "���w��";

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
                    
                    job = "�싅�I��";

                    cutIn.SetActive(true);
                    time = 0;

                    Time.timeScale = 0;

                }
                else
                {
                    
                    job = "���";

                    cutIn.SetActive(true);
                    time = 0;

                    Time.timeScale = 0;

                }
            }
            else
            {
                
                job = "�j�[�g";

                cutIn.SetActive(true);
                time = 0;


                Time.timeScale = 0;

            }
        }
        if (player.Instance.age == 30)
        {
            job = "�V���ڂ�";

            cutIn.SetActive(true);
            time = 0;

            Time.timeScale = 0;

        }
        
    }
    
}
