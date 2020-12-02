using UnityEngine;

public class BallMaterial : MonoBehaviour {

    public GameObject Ball;
    public Material Ball1, Ball2, Ball3, Ball4, Ball5, Ball6, Ball7;
    public int BallValue;

    void Start()
    {
        Invoke("BallMaterialFuntion",0);
    }
    public void BallMaterialFuntion ()
    {
        BallValue = PlayerPrefs.GetInt("Ball", 1);

        if (BallValue == 1)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball1;
        }
        else if (BallValue == 2)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball2;
        }
        else if (BallValue == 3)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball3;
        }
        else if (BallValue == 4)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball4;
        }
        else if (BallValue == 5)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball5;
        }
        else if (BallValue == 6)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball6;
        }
        else if (BallValue == 7)
        {
            Ball.GetComponent<MeshRenderer>().material = Ball7;
        }
    }
}