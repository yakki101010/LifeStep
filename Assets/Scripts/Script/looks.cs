using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class looks : MonoBehaviour
{
    public string Lolita;//���w��

    public string tyuugakusei;//���w��

    public string nirto;//�j�[�g

    public string yakyuu;//�싅�I��

    public string doctor;//���

    public string oibore;//����������

    public GameObject inai;//

    public bool MyGender;//����

    public string jobAnime = "";
    


    public GameObject tagetto;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Gender = GorB.Instance.gorb;

        if (GameManager.Instance.Gender == MyGender)//�j������
        {
            inai.SetActive(false);
        }

        jobAnime = Lolita;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tagetto.transform.position.x, tagetto.transform.position.y, 1);

        if(GameManager.Instance.job == "���w��")
        {
            jobAnime = tyuugakusei;
        }
        if (GameManager.Instance.job == "�j�[�g")
        {
            jobAnime = nirto;
        }
        if (GameManager.Instance.job == "�싅�I��")
        {
            jobAnime = yakyuu;
        }
        if (GameManager.Instance.job == "���")
        {
            jobAnime = doctor;
        }
        if (GameManager.Instance.job == "�V���ڂ�")
        {
            jobAnime = oibore;
        }
    }
    private void FixedUpdate()
    {
        this.GetComponent<Animator>().Play(jobAnime);
    }
}
