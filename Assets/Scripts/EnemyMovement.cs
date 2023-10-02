using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStart : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
    void Start()
    { 
        // Add random direction on enemy start
        GetComponent<Rigidbody2D>().AddRelativeForce(Random.onUnitSphere * speed);
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        GetComponent<AudioSource>().Play();
    }

}
