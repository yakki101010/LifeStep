using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI1 : MonoBehaviour
{
    //public player player;

    private TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.Instance.age.ToString() + "çÀ" + "\nHP:" + player.Instance.hp.ToString("00") + " EP:" + player.Instance.ep.ToString("00") + " SP:" + player.Instance.sp.ToString("00");
    }
}
