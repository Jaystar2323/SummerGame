using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject basicEnemy;
    [SerializeField] private float spawnRate = 0.5f;
    private GameManager gm;
    private float time;
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= spawnRate)
        {
            time = 0;
            //Vector3 targetDirection = gm.player.transform.position - transform.position;
           // Quaternion rot = Quaternion.LookRotation(Vector3.forward, targetDirection).normalized;
            Instantiate(basicEnemy, transform.position, Quaternion.identity);
        }
    }
}
