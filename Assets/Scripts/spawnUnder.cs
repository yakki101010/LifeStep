using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityException;

public class spawnUnder : MonoBehaviour
{
    public GameObject asiba;//‘«ê

    float yr;

    Vector3 y;

    public float R;

    public int itme = 0;

    //ƒAƒCƒeƒ€

    public GameObject itme0;

    public GameObject itme1;

    public GameObject itme2;

    public GameObject itme3;

    // Start is called before the first frame update
    void Start()
    {

        i = Random.Range(1f, 1.5f);
    }

    // Update is called once per frame

    float t = 0;
    float i;
    void Update()
    {
        t = t + Time.deltaTime * GameManager.Instance.time;



        if (t >= i)
        {
            yr = Random.Range(-1.5f, 1.5f);
            itme = Random.Range(0, 10);

            Instantiate(asiba, new Vector3(this.transform.position.x, this.transform.position.y + yr, this.transform.position.z), Quaternion.identity);


            if(player.Instance.age <= 13)
            {
                if (itme >= 0 && itme <= 2)
                {
                    Instantiate(itme2, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
                if (itme >= 3 && itme <= 5)
                {
                    Instantiate(itme3, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
            }
            else if(player.Instance.age <= 20)
            {
                if (itme == 0)
                {
                    Instantiate(itme0, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
                if (itme >= 1 && itme <= 3)
                {
                    Instantiate(itme1, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
                if (itme == 4)
                {
                    Instantiate(itme2, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
                if (itme == 5)
                {
                    Instantiate(itme3, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
            }
            else
            {
                if (itme >= 1 && itme <= 3)
                {
                    Instantiate(itme0, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
                if (itme >= 4 && itme <= 6)
                {
                    Instantiate(itme1, new Vector3(this.transform.position.x, this.transform.position.y + yr + 0.5f, this.transform.position.z), Quaternion.identity);
                }
            }









                t = 0;

            i = Random.Range(1f, 1.5f);
        }
    }

}
