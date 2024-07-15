using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GBcursor : MonoBehaviour
{
    [SerializeField] private GameObject Boy;
    [SerializeField] private GameObject Girl;
    [SerializeField] private GameObject Select;
    // Start is called before the first frame update
    void Start()
    {
        Select = Girl;
    }

    // Update is called once per frame
    void Update()
    {
       if (GorB.Instance.gorb)
        {
            Select = Boy;
        }
       else
        {
            Select = Girl;
        }
       if(Input.GetKeyDown("right"))
        {
            GorB.Instance.gorb = true;
        }
       if(Input.GetKeyDown("left"))
        {
            GorB.Instance.gorb = false;
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
    private void FixedUpdate()
    {
        transform.position = Select.transform.position + new Vector3(-0.1f, -0.3f, -59);
    }
}
