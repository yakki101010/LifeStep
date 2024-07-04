using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class looks : MonoBehaviour
{
    public Sprite tyuugakusei;

    public Sprite nirto;

    public Sprite yakyuu;

    public Sprite isya;

    public Sprite oibore;






    public GameObject tagetto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(tagetto.transform.position.x, tagetto.transform.position.y, 1);

        if(GameManager.Instance.job == "中学生")
        {
            this.GetComponent<SpriteRenderer>().sprite = tyuugakusei;
        }
        if (GameManager.Instance.job == "ニート")
        {
            this.GetComponent<SpriteRenderer>().sprite = nirto;
        }
        if (GameManager.Instance.job == "野球選手")
        {
            this.GetComponent<SpriteRenderer>().sprite = yakyuu;
        }
        if (GameManager.Instance.job == "医者")
        {
            this.GetComponent<SpriteRenderer>().sprite = isya;
        }
        if (GameManager.Instance.job == "老いぼれ")
        {
            this.GetComponent<SpriteRenderer>().sprite = oibore;
        }
    }
}
