using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector2(0,-20); 
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 9;
        RB.velocity = RB.velocity.normalized * speed;
    }
}
