using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float movementSpeed = 3f;
    float jumpSpeed = 800f;
    bool isGrounded = true;
    Rigidbody2D rb;
    public float rotationZ;
    public string playerId;

    public Transform spawnPoint;
    private Vector3 spawn;

    void Start()
    {
        spawn = transform.position;
        SetPlayerId(playerId);
        Debug.Log(playerId);
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetPlayerId(string id)
    {
        playerId = id;
    }

    public string GetPlayerId()
    {
        return playerId;
    }


    void Update()
    {
        if (isGrounded)
        {
            rb.gravityScale = 2.1f;
        }

        if (playerId == "Player1")
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position += Vector3.left * movementSpeed * Time.deltaTime;
                transform.Rotate(0, 0, rotationZ);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += Vector3.right * movementSpeed * Time.deltaTime;
                transform.Rotate(0, 0, -rotationZ);
            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (isGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    isGrounded = false;
                }
            }
        }

        if (playerId == "Player2")
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left * movementSpeed * Time.deltaTime;
                transform.Rotate(0, 0, rotationZ);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right * movementSpeed * Time.deltaTime;
                transform.Rotate(0, 0, -rotationZ);
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (isGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    isGrounded = false;
                }
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (!isGrounded)
            {
                rb.gravityScale += 2;
            }
            
        }
        
        if(transform.position.y <= -40){;
            transform.position = spawn;
            Health.health--;
        }
    
    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
    }

}
