using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    }
    private void FixedUpdate()
    {
        transform.position = Select.transform.position + new Vector3(-0.1f, -0.3f, -59);
    }
}
