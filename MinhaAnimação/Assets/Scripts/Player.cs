using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float Speed;

    private Rigidbody2D rigidBody; 
    
    private Animator animator;
    
    private SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator =  GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Lógica do personagem se movimentando
        if (Input.GetKey(KeyCode.LeftArrow))
        { 
            rigidBody.velocity = new Vector2(-Speed, rigidBody.velocity.y)
        } 

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody.velocity = new Vector2(Speed, rigidBody.velocity.y)
        }
        
    }
}
