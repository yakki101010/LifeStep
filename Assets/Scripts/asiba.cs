using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class asiba : MonoBehaviour
{
    

    //Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("kesu", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (player.Instance.hp < 5)//スピードの設定
        {
            GameManager.Instance.speed = 2.5f;
        }
        else if (player.Instance.hp < 10)
        {
            GameManager.Instance.speed = 3f;
        }
        else if (player.Instance.hp < 15)
        {
            GameManager.Instance.speed = 3.5f;
        }
        else if (player.Instance.hp < 20)
        {
            GameManager.Instance.speed = 4f;
        }
        else if (player.Instance.hp == 20)
        {
            GameManager.Instance.speed = 4.5f;
        }
    }
    private void FixedUpdate()
    {

        float dx = (Time.deltaTime * GameManager.Instance.speed * -1) * GameManager.Instance.time;

        transform.Translate(dx,0,0);
    }
    void kesu()
    {
        Destroy(gameObject);
    }
}
