using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Pause_settings : MonoBehaviour
{
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(Osu);
    }

    // Update is called once per frame
    public void Osu()
    {
        SceneManager.LoadScene("Pose menu");
    }
}

