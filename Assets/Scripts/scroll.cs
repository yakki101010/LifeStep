using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class scroll : MonoBehaviour
{
    private const float k_maxLength = 1f;
    private const string k_propName = "_MainTex";

    public Sprite tyuugakusei;
    public Sprite nirto;
    public Sprite yakyuu;
    public Sprite doctor;
    public Sprite oibore;

    public Image Luck;

   [SerializeField]
    private Vector2 m_offsetSpeed;

    private Material m_material;

    private void Start()
    {
        if (GetComponent<Image>() is Image i)
        {
            m_material = i.material;
        }
    }

    private void Update()
    {
        if (m_material)
        {
            var x = Mathf.Repeat(Time.time * m_offsetSpeed.x, k_maxLength);
            var y = Mathf.Repeat(Time.time * m_offsetSpeed.y, k_maxLength);
            var offset = new Vector2(x, y);
            m_material.SetTextureOffset(k_propName, offset);
        }
        m_offsetSpeed.x = GameManager.Instance.speed / 90;

        if (GameManager.Instance.job == "中学生")
        {
            Luck.sprite = tyuugakusei;
        }
        if (GameManager.Instance.job == "ニート")
        {
            Luck.sprite = nirto;
        }
        if (GameManager.Instance.job == "野球選手")
        {
            Luck.sprite = yakyuu;
        }
        if (GameManager.Instance.job == "医者")
        {
            Luck.sprite = doctor;
        }
        if (GameManager.Instance.job == "老いぼれ")
        {
            Luck.sprite = oibore;
        }
    }

    private void OnDestroy()
    {
        if (m_material)
        {
            m_material.SetTextureOffset(k_propName, Vector2.zero);
        }
    }
}
