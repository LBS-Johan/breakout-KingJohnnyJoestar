using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP1 : MonoBehaviour
{
    Rigidbody2D Penis;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        Penis = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mike = new Vector2();
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            mike.x = speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            mike.x = -speed;
        }

        Penis.velocity = mike;
    }
}
