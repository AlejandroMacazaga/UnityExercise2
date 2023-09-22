using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementStart : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    // Start is called before the first frame update
    void Start()
    { 
        GetComponent<Rigidbody2D>().AddRelativeForce(Random.onUnitSphere * speed);
    }

}
