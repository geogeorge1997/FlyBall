using UnityEngine;
using System;

public class BallMove : MonoBehaviour {

    public float zTranslate,yTranslate,xTranslate,speedIncreaser;
    public float xForce;
    public Rigidbody Ball;
    public int flagMoveSides = 0,flagMiddle=0;
    public int pOutFlag;
    public Vector3 velocityBall;
    public GameObject /*explotionFly,*/CanvasHome,SpeedTextBox;
    public int speed;
    public float pMakePlatform,pAvg;
    public int GameChanceScore;

    void Start()
    {
        //Initilize values for Platform

        zTranslate = 10.0f;
        yTranslate = 5.5f;
        xTranslate = 1.18f;

        xForce = Screen.width / 5.07f;

        PlayerPrefs.SetInt("OutFlag", 0);

        GameChanceScore = PlayerPrefs.GetInt("GameChanceScore", 0);
        if (GameChanceScore > 0)
        {
            PlayerPrefs.SetInt("DestroyObstacle", 1);
            SpeedTextBox.SetActive(true);
            CanvasHome.SetActive(false);
            speedIncreaser = GameChanceScore / zTranslate;
            velocityBall = Ball.velocity;
            velocityBall.y = yTranslate * 1.67f;
            Ball.velocity = velocityBall;
            FindObjectOfType<PlatformMultiplier>().FunMultiply();
        }
    }

    void Update()
    {
        //KeyBoard Part

        //Set Left Side Position 

        //Begining

        if (Ball.position.x <= -(xTranslate))
            {
                velocityBall = Ball.velocity;
                velocityBall.x = 0;
                Ball.velocity = velocityBall;
                flagMiddle = 1;
                Ball.transform.position = new Vector3(-xTranslate, transform.position.y, transform.position.z);
                flagMoveSides = -1;
            }

            //Set Right Side Position

            if (Ball.position.x >= (xTranslate))
            {
                velocityBall = Ball.velocity;
                velocityBall.x = 0;
                Ball.velocity = velocityBall;
                flagMiddle = 1;
                Ball.transform.position = new Vector3(xTranslate, transform.position.y, transform.position.z);
                flagMoveSides = 1;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                if (flagMoveSides > -1)
                {
                    flagMoveSides =-1;
                    Ball.AddForce(-xForce, 0, 0);
                }

            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                if (flagMoveSides < 1)
                {
                    flagMoveSides =1;
                    Ball.AddForce(xForce, 0, 0);
                }

            }
        //End

        //Set Ball Speed 

        if (Ball.velocity.z > 0&& Ball.velocity.z<46)
        {
            speedIncreaser = speedIncreaser + .0073f;
        }
        else if (Ball.velocity.z > 0 && Ball.velocity.z < 91)
        {
            speedIncreaser = speedIncreaser + .0064f;
        }
        else if (Ball.velocity.z > 0 && Ball.velocity.z < 145)
        {
            speedIncreaser = speedIncreaser + .0055f;
        }
        else if (Ball.velocity.z > 0 && Ball.velocity.z < 167)
        {
            speedIncreaser = speedIncreaser + .0046f;
        }
        else if(Ball.velocity.z >=167)
        {
            speedIncreaser = speedIncreaser + .0037f;
        }

        speed = (int)Math.Ceiling(Ball.velocity.z); 
        FindObjectOfType<ScoreTextScript>().ScoreFuntion(speed);

        //Set Out and Not Out Speed

        pOutFlag = PlayerPrefs.GetInt("OutFlag", 0);
        if (pOutFlag == 1)
        {
            zTranslate = 0;
        }

        velocityBall = Ball.velocity;
        velocityBall.z = speedIncreaser * zTranslate;
        Ball.velocity = velocityBall;
        
        transform.Rotate(velocityBall.z/3, 0, 0);

        //Y Error Detection

        pMakePlatform = PlayerPrefs.GetFloat("makePlatform", 0);
        pAvg = PlayerPrefs.GetFloat("avg", 0);
        if (transform.position.z > pMakePlatform - pAvg)
        {
            FindObjectOfType<PlatformMultiplier>().FunMultiply();
        }
        /*
        if (Ball.position.y > 1)
        {
                explotionFly.SetActive(true);
        }
        */
        //Out Occurances 

        if (Ball.position.y < -3)
        {
            FindObjectOfType<ScoreTextScript>().OutOccured();
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        velocityBall = Ball.velocity;
        velocityBall.y = 0;
        Ball.velocity = velocityBall;
    }

    public void FuntionFly()
    {
        //explotionFly.SetActive(false);
        velocityBall = Ball.velocity;
        if(velocityBall.z>82)
        {
            velocityBall.y = yTranslate * 1.99f;
        }
        else if (velocityBall.z > 46)
        {
            velocityBall.y = yTranslate*1.67f;
        }
        else
        {
            velocityBall.y = yTranslate;
        }
        Ball.velocity = velocityBall;
    }

    public void PlayButton()
    {
        speedIncreaser = .1f;
    }
}