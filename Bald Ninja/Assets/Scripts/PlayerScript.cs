using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    float horizontal;
    public float speed = 3.0f;

    // Rigidbody2D rb2d;

    private void Start()
    {
        // rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
      
        horizontal = Input.GetAxis("Horizontal");
        Vector2 position = transform.position;
        position.x += horizontal * speed * Time.deltaTime;

        transform.position = position;
        
    }

}
