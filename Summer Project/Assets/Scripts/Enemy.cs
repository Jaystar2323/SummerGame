using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 4f;
    private GameObject gmObject;
    private Rigidbody2D rb;
    private GameManager gm;

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Update()
    {

        
    }
    void FixedUpdate()
    {
        Vector3 targetDirection = gm.player.transform.position - transform.position;
        Quaternion rot = Quaternion.LookRotation(Vector3.forward, targetDirection);

        transform.rotation = Quaternion.Lerp(transform.rotation, rot, Time.deltaTime * 10);


        Vector2 move = new Vector2(transform.up.x, transform.up.y) * Time.deltaTime * speed;
        rb.MovePosition(new Vector2(transform.position.x, transform.position.y) + move);
    }
}
