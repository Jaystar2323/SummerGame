using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5f);
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(particles, this.transform.position, Quaternion.identity);

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(this.gameObject);
    }
}
