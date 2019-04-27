using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float movementSpeed = 3f;
    float jumpSpeed = 1000f;
    public static bool eGrounded = true;
    public static bool hGrounded = true;
    bool eJumping = false;
    bool hJumping = false;
    Rigidbody2D rb;
    public float rotationZ;
    public string playerId;

    public Transform spawnPoint;
    private Vector3 spawn;
    public int spawn2Margin;
    public Vector3 spawn2;
    public int spawn3Margin;
    public Vector3 spawn3;
    public int eVelocity;
    public int hVelocity;

    public AudioClip eJump;    // Add your Audi Clip Here;


    void Start()
    {
        spawn = transform.position;
        SetPlayerId(playerId);
        Debug.Log(playerId);
        rb = GetComponent<Rigidbody2D>();

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = eJump;
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
        if(eVelocity == 0)
        {
            eJumping = false;
            eGrounded = true;
        }

        if (hVelocity == 0)
        {
            hJumping = false;
            hGrounded = true;
        }

        if (eGrounded)
        {
            rb.gravityScale = 2.1f;
        }
        if (hGrounded)
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

            if (Input.GetKeyDown(KeyCode.UpArrow) && eVelocity == 0)
            {
                if (eGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    eGrounded = false;
                    eJumping = true;
                    Debug.Log("Vector3.up: "+Vector3.up+"");
                }
            }

            if (eJumping == true)
            {
                eVelocity++;
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

            if (Input.GetKeyDown(KeyCode.W) && hVelocity == 0)
            {
                if (hGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    hGrounded = false;
                    hVelocity++;
                    GetComponent<AudioSource>().Play();
                }
            }

            if (hJumping == true)
            {
                hVelocity++;
            }
        }


        
        if(transform.position.y <= -40){
            if(transform.position.x < spawn2Margin){
                transform.position = spawn;
            }
            else if(transform.position.x < spawn3Margin && transform.position.x > spawn2Margin){
                transform.position = spawn2;
            }
            else{
                transform.position = spawn3;
            }
            Health.health--;
        }

        if(Health.health == 0){
            SceneManager.LoadScene("DeathScene");
        }
    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        eVelocity = 0;
        hVelocity = 0;
    }


}
