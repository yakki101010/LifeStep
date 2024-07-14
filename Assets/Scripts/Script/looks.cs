using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class looks : MonoBehaviour
{
    public string Lolita;//小学生

    public string tyuugakusei;//中学生

    public string nirto;//ニート

    public string yakyuu;//野球選手

    public string doctor;//医者

    public string oibore;//おじいさん

    public GameObject inai;//

    public bool MyGender;//性別

    public string jobAnime = "";
    


    public GameObject tagetto;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Gender = GorB.Instance.gorb;

        if (GameManager.Instance.Gender == MyGender)//男女判定
        {
            inai.SetActive(false);
        }

        jobAnime = Lolita;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tagetto.transform.position.x, tagetto.transform.position.y, 1);

        if(GameManager.Instance.job == "中学生")
        {
            jobAnime = tyuugakusei;
        }
        if (GameManager.Instance.job == "ニート")
        {
            jobAnime = nirto;
        }
        if (GameManager.Instance.job == "野球選手")
        {
            jobAnime = yakyuu;
        }
        if (GameManager.Instance.job == "医者")
        {
            jobAnime = doctor;
        }
        if (GameManager.Instance.job == "老いぼれ")
        {
            jobAnime = oibore;
        }
    }
    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(jobAnime);
    }
}
