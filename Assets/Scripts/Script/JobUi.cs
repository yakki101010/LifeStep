using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JobUi : MonoBehaviour
{
    private TMP_Text text;

   

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Job:" + GameManager.Instance.job;
    }
}
