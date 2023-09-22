using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameOnCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
        {
            Debug.Log("Sacabo");
            Application.Quit();
        }
    }
}
