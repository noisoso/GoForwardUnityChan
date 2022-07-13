using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement ;


public class UIController : MonoBehaviour
{

    public GameObject gameOverText;
    private GameObject runLengthText;
    private float len = 0;
    private float speed = 5f;
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        this.runLengthText = GameObject.Find("RunLength");
        this.gameOverText = GameObject.Find("GameOver");
      
    }

    // Update is called once per frame
    void Update()
    {
        if (this.isGameOver ==false )
        {
            this.len += this.speed * Time.deltaTime;
            this.runLengthText.GetComponent<Text> ().text = "Distance: " + len.ToString("F2") + "m";
        }


        if (this.isGameOver == true )
        {
            if (Input .GetMouseButton(0))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    
    
    
    
    }





    public void Gameover()
    {
        this.gameOverText.GetComponent<Text>().text = "Game Over";
        this.isGameOver = true;
    }


}
