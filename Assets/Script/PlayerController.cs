using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = Vector2.left;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            
    }

}
