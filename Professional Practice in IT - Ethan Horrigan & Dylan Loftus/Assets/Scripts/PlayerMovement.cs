using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject player;
    public float movementSpeed = 3f;
    float jumpSpeed = 800f;
    public static bool isGrounded = true;
    Rigidbody2D rb;
    public float rotationZ;
    public string playerId;

    public Transform spawnPoint;
    private Vector3 spawn;
    private Vector3 spawn2 = new Vector3(74.19f,-9.23f);
    private Vector3 spawn3 = new Vector3(130f,-9.23f);

    private AudioSource jumps;
    public AudioClip eJump; //set this in ispector with audiofile
    public AudioClip hJump; //set this in ispector with audiofile       
    public AudioClip collect; //set this in ispector with audiofile       
    public AudioClip death; //set this in ispector with audiofile     

    bool deathBool = false;
    bool jumpBool = false;


    void Start()
    {
        spawn = transform.position;
        SetPlayerId(playerId);
        Debug.Log(playerId);
        rb = GetComponent<Rigidbody2D>();

        jumps = GetComponent<AudioSource>();

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

            if (Input.GetKeyDown(KeyCode.UpArrow) && jumpBool == false)
            {
                jumpBool = true;
                if (isGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    isGrounded = false;

                    jumps.clip = eJump ;
                    jumps.Play();
                    
                }
                jumpBool = false;
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

            if (Input.GetKeyDown(KeyCode.W) && jumpBool == false)
            {
                jumpBool = true;
                if (isGrounded)
                {
                    rb.AddForce(Vector3.up * jumpSpeed);
                    isGrounded = false;
                    jumps.clip = hJump;
                    jumps.Play();

                }
                jumpBool = false;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (!isGrounded)
            {
                rb.gravityScale += 2;
            }
            
        }
        if (deathBool == false && transform.position.y <= -30)
        {
            deathBool = true;
            jumps.clip = death;
            jumps.Play();
        }
        if (transform.position.y <= -40){
            if(transform.position.x < 70){
                transform.position = spawn;
            }
            else if(transform.position.x < 120 && transform.position.x > 70){
                transform.position = spawn2;
            }
            else{
                transform.position = spawn3;
            }
            Health.health--;
            deathBool = false;
        }
        

    }
    

    void OnCollisionEnter2D(Collision2D col)
    {
        isGrounded = true;
        jumps.clip = collect;
    }

}
