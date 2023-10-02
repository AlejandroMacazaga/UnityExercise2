using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag.Equals("Player"))
        {
            Destroy(this);
        }
    }
}
