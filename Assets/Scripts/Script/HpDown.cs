using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpDown : MonoBehaviour
{
    public string looksNeme;

    GameObject looksObject;

    public SpriteRenderer looks;

    SpriteRenderer my;

    // Start is called before the first frame update
    void Start()
    {
        looksObject = GameObject.Find(looksNeme);

        looks = looksObject.GetComponent<SpriteRenderer>();

        my = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("âΩÇ©Ç…êGÇÍÇΩ");

        if (collision.gameObject.layer == 8)
        {
            looks.color = new Color(1,0.5f,0.5f,1);

            Debug.Log("ÉvÉåÉCÉÑÅ[Ç…êGÇÍÇΩ");

            player.Instance.hp = player.Instance.hp - 2;

            Invoke("kesu", 0.3f);

            my.color = new Color(0, 0, 0, 0);
        }
    }
    private void FixedUpdate()
    {

        float dx = (Time.deltaTime * GameManager.Instance.speed * -1) * GameManager.Instance.time;

        transform.Translate(dx, 0, 0);
    }
    void kesu()
    {
        looks.color = new Color(1, 1, 1, 1);

        Destroy(gameObject);
    }
}
