using UnityEngine;

public class BallTouch : MonoBehaviour {

    public GameObject Ball;
    public float xPos;

    void Update()
    {
        //Touch Part

        Touch touch = Input.GetTouch(0);
        xPos = touch.deltaPosition.x;
        xPos = xPos * 2.98f / Screen.width;
        Ball.transform.Translate(xPos, 0, 0);        
    }
}