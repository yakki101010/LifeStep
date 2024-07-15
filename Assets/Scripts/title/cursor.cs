using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cursor : MonoBehaviour
{
    public Vector2[] cursorPosition;

    [SerializeField] private int cursorPositionNum;

    float x;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up") && cursorPositionNum < 3)
        {
            cursorPositionNum++;
        }
        else if(Input.GetKeyDown("up"))
        {
            cursorPositionNum = 0;
        }
        if(Input.GetKeyDown("down") && cursorPositionNum > 0)
        {
            cursorPositionNum--;
        }
        else if(Input.GetKeyDown("down"))
        {
            cursorPositionNum = 3;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            switch(cursorPositionNum)
            {
                case 0://ê›íË

                    break;

                case 1://óVÇ—ï˚

                    break;

                case 2://ÉvÉåÉC

                    SceneManager.LoadScene("GenderSelect");

                    break;

                case 3://

                    break;
            }
        }
    }
    private void FixedUpdate()
    {
        transform.position = cursorPosition[cursorPositionNum] + new Vector2(x,0);

        x = Mathf.Sin(Time.time * 3f) * 0.2f;
    }
}
