using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutIn : MonoBehaviour
{
    float t = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.time == 0)
        {
            //Invoke("kesu", 1.5f);



            if (t >= 1.5f)
            {
                Debug.Log("‚ ‚ ‚ ‚ ");

                GameManager.Instance.time = 1;

                player.Instance.age = player.Instance.age + 1;

                gameObject.SetActive(false);

                

                Time.timeScale = 1;

                t = 0;
            }

            t = t + Time.unscaledDeltaTime;
            Debug.Log(t);
        }

        
    }
    //public void kesu()
    //{
    //    if (GameManager.Instance.time == 0)
    //    {
    //        Debug.Log("‚ ‚ ‚ ‚ ");

    //        GameManager.Instance.time = 1;

    //        player.Instance.age = player.Instance.age + 1;

    //        gameObject.SetActive(false);

    //        //GameManager.Instance.isStop = false;

    //        Time.timeScale = 1;

    //        t = 0;
    //    }
    //}
}
