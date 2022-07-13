using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private float speed = -12;
    private float deadLine = -10;
    AudioSource blockSE;
    public AudioClip block;
    private int seigen = 1;//âπÇÃèdï°êßå¿
    // Start is called before the first frame update
    void Start()
    {
        this.blockSE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(this.speed * Time.deltaTime, 0, 0);
        if (transform .position. x <deadLine )
        {
            Destroy(gameObject);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "ground" || collision.gameObject.tag == "block") && seigen == 1)
        {
            blockSE.PlayOneShot(block);
            seigen = 2;//âπÇ™àÍâÒÇµÇ©ñ¬ÇÁÇ»Ç¢ÇÊÇ§Ç…ÇµÇƒÇ¢ÇÈ
        }
    }

}
