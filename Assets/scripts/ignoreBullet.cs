using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoreBullet : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;
    public GameObject obj4;

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj3.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj4.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj1.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj2.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj3.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(bulletPrefab.GetComponent<Collider2D>(), obj4.GetComponent<Collider2D>());
    }
}
