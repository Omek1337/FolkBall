using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerSlide : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject player;
    Vector2 whereToSpawn;
    public Rigidbody2D rb;
    public float spawnRate;
    public float bulletForce = 10f;
    private float randY;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-5f, 5f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            rb.MovePosition(whereToSpawn);
            Shooting();

        }
       
    }

    void Shooting() 
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D rb1 = bullet.GetComponent<Rigidbody2D>();
        if (rb.position.x - player.transform.position.x < 0)
        {
            rb1.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
        }
        else 
        {
            rb1.AddForce(-transform.right * bulletForce, ForceMode2D.Impulse);
        }
        
    }
}
