using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D playerRb;
    private Vector2 position;

    private float horizontal;
    private float vertical;
    
    private void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        position = playerRb.transform.position;
        position += new Vector2(horizontal * Time.deltaTime * speed, vertical * Time.deltaTime * speed);
        playerRb.transform.position = position;
    }

    private void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
}
