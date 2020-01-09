using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision) 
    {
        Debug.Log("collision name = " + collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        Destroy(gameObject, 5f); 
    }
}
