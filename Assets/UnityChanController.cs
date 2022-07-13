using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    private float dump = 0.8f;
    private float jumpVelocity = 20f;
    AudioSource SE;
    Animator animator;
    private float groundLevel = -3.0f;

    private float deadLine = -9;



    // Start is called before the first frame update
    void Start()
    {
        this.animator = GetComponent<Animator>();
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.SE = GetComponent<AudioSource>();
        

    }

    // Update is called once per frame
    void Update()
    {
        this.animator.SetFloat("Horizontal", 1);

        bool isGround = (transform.position.y > this.groundLevel) ? false : true;
        this.animator.SetBool("isGround", isGround);


        if (Input .GetMouseButtonDown(0)&&isGround )
        {
            this.rigid2D.velocity = new Vector2(0, jumpVelocity);
        }
        if (Input .GetMouseButton(0)==false )
        {
            if (this.rigid2D .velocity .y > 0)
            {
                this.rigid2D.velocity *= dump;
            }
        }


        if (this.transform .position .x < deadLine )
        {
            GameObject.Find("Canvas").GetComponent<UIController>().Gameover();
            Destroy(gameObject);
        }

        this.SE.volume = (isGround) ? 1 : 0;

    }


}
