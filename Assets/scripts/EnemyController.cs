using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public Rigidbody rb;
    public GameObject player;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("player");
    }

  
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; 
        rb.AddForce(lookDirection * speed);

    }
}
