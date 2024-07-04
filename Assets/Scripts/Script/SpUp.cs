using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            player.Instance.sp = player.Instance.sp + 2;

            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {

        float dx = (Time.deltaTime * GameManager.Instance.speed * -1) * GameManager.Instance.time;

        transform.Translate(dx, 0, 0);
    }
}
