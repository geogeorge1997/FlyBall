using UnityEngine;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour
{

    public int r, g, b;
    public GameObject ScoreText, ScoreTextGame, BestScoreText,FlyBallText;

    public Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        Invoke("BackGroundColorFuntion", 0);
    }

    public void BackGroundColorFuntion()
    {
        r = PlayerPrefs.GetInt("BackGroundRed", 235);
        g = PlayerPrefs.GetInt("BackGroundGreen", 235);
        b = PlayerPrefs.GetInt("BackGroundBlue", 235);
        cam.backgroundColor = new Color(r / 255.0f, g / 255.0f, b / 255.0f);
        if (r > 217 && g > 217 && b > 217)
        {
            ScoreText.GetComponent<Text>().color = Color.black;
            ScoreTextGame.GetComponent<Text>().color = Color.black;
            BestScoreText.GetComponent<Text>().color = Color.black;
            FlyBallText.GetComponent<Text>().color = Color.black;
        }
    }
}