using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUp : MonoBehaviour
{
    //public string playerName;

    //player player;

    //public string PlayerNem;

    // GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

        //Player = GameObject.Find(PlayerNem);

        //player = class.player.Find(playerName);

        //player = class.Find(playerName);

        //player = playerName;

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

            player.Instance.hp = player.Instance.hp + 2;

            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {

        float dx = (Time.deltaTime * GameManager.Instance.speed * -1) * GameManager.Instance.time;

        transform.Translate(dx, 0, 0);
    }
}
