using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EpUp : MonoBehaviour
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
        Debug.Log("âΩÇ©Ç…êGÇÍÇΩ");

        if (collision.gameObject.layer == 8)
        {
            Debug.Log("ÉvÉåÉCÉÑÅ[Ç…êGÇÍÇΩ");

            player.Instance.ep = player.Instance.ep + 2;

            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {

        float dx = (Time.deltaTime * GameManager.Instance.speed * -1) * GameManager.Instance.time;

        transform.Translate(dx, 0, 0);
    }

}
