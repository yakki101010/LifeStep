using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class looks : MonoBehaviour
{
    public Sprite tyuugakusei;

    public Sprite nirto;

    public Sprite yakyuu;

    public Sprite isya;

    public Sprite oibore;

    public GameObject inai;

    public bool MyGender;
    


    public GameObject tagetto;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.Gender = GorB.Instance.gorb;

        if (GameManager.Instance.Gender == MyGender)
        {
            inai.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tagetto.transform.position.x, tagetto.transform.position.y, 1);

        if(GameManager.Instance.job == "���w��")
        {
            this.GetComponent<SpriteRenderer>().sprite = tyuugakusei;
        }
        if (GameManager.Instance.job == "�j�[�g")
        {
            this.GetComponent<SpriteRenderer>().sprite = nirto;
        }
        if (GameManager.Instance.job == "�싅�I��")
        {
            this.GetComponent<SpriteRenderer>().sprite = yakyuu;
        }
        if (GameManager.Instance.job == "���")
        {
            this.GetComponent<SpriteRenderer>().sprite = isya;
        }
        if (GameManager.Instance.job == "�V���ڂ�")
        {
            this.GetComponent<SpriteRenderer>().sprite = oibore;
        }
    }
}
