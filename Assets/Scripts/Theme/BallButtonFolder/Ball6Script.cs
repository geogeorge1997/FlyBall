using UnityEngine;
using UnityEngine.UI;

public class Ball6Script : MonoBehaviour{

    public Text TextBox;
    private int locks,HighestSpeed;

    void Start()
    {
        HighestSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        if (HighestSpeed >= 120)
        {
            locks = 1;
            TextBox.gameObject.SetActive(false);
        }
    }

    public void Ball6Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 6);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}