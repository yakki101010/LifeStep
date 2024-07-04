using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public GameObject player;

    Rigidbody2D rbody;

    bool i = true;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();

       
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null)
        {
            

            if(i)
            {
                i = false;

                rbody.velocity = new Vector2(rbody.velocity.x, 0);

                rbody.AddForce(new Vector2(0, 5), ForceMode2D.Impulse);
            }
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.1f, 0);
        }
        
    }
}
