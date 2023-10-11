using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basketController : MonoBehaviour
{
    public Text sText;
    public Text lifeText;
    public AudioSource trueColor;
    public AudioSource falseColor;
    
    public GameObject redBasket, yellowasket, greenBasket, blueBasket,garbageBasket;
    public GameObject leftStick, rightStick;
    public GameObject gameOverPanel;
    public GameObject winnerPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (gameObject.tag.Equals("redBasket") && col.gameObject.tag.Equals("red"))
        {
            trueColor.Play();
            Destroy(col.gameObject);
            BallCreator.score++;
            
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }
        else if (gameObject.tag.Equals("blueBasket") && col.gameObject.tag.Equals("blue"))
        {
            trueColor.Play();
            Destroy(col.gameObject);
            BallCreator.score++;
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }
        else if (gameObject.tag.Equals("yellowBasket") && col.gameObject.tag.Equals("yellow"))
        {
            trueColor.Play();
            Destroy(col.gameObject);
            BallCreator.score++;
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }
        else if (gameObject.tag.Equals("greenBasket") && col.gameObject.tag.Equals("green"))
        {
            trueColor.Play();
            Destroy(col.gameObject);
            BallCreator.score++;
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }
        else if (gameObject.tag.Equals("blueBasket") && col.gameObject.tag.Equals("bluePlus"))
        {
            trueColor.Play();
            BallCreator.life++;
            lifeText.text = "Life:" + BallCreator.life.ToString();
            Destroy(col.gameObject);
            BallCreator.score++;
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }
        else if (col.gameObject.tag.Equals("bomb"))
        {
            if (!gameObject.tag.Equals("garbage"))
            {
                falseColor.Play();
                
                BallCreator.life--;
                BallCreator.life--;
                lifeText.text = "Life:" + BallCreator.life.ToString();
                dead();
            }
            else
            {
                trueColor.Play();
            }
            
            Destroy(col.gameObject);
            
            
        }
        else
        {
            falseColor.Play();
            BallCreator.life--;
            lifeText.text = "Life:" + BallCreator.life.ToString();
            Destroy(col.gameObject);
            BallCreator.score--;
            sText.text = "Score: " + BallCreator.score.ToString();
            dead();
        }

        
        

    }

    

    void dead()
    {
        if (BallCreator.score<0)
        {
            blueBasket.SetActive(false);
            redBasket.SetActive(false);
            greenBasket.SetActive(false);
            yellowasket.SetActive(false);
            gameOverPanel.SetActive(true);
            
            leftStick.SetActive(false);
            garbageBasket.SetActive(false);
            rightStick.SetActive(false);
        }
        else if (BallCreator.life<0)
        {
            blueBasket.SetActive(false);
            redBasket.SetActive(false);
            greenBasket.SetActive(false);
            yellowasket.SetActive(false);
            gameOverPanel.SetActive(true);
            
            leftStick.SetActive(false);
            rightStick.SetActive(false);
            garbageBasket.SetActive(false);
        }
        else if (BallCreator.score>=10)
        {
            winnerPanel.SetActive(true);
            blueBasket.SetActive(false);
            redBasket.SetActive(false);
            greenBasket.SetActive(false);
            yellowasket.SetActive(false);
            leftStick.SetActive(false);
            rightStick.SetActive(false);
            garbageBasket.SetActive(false);
        }
        
    }
}
