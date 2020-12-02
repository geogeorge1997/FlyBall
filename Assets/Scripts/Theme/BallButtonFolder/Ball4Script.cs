using UnityEngine;
using UnityEngine.UI;

public class Ball4Script : MonoBehaviour{

    public Text TextBox;
    private int locks,HighestSpeed;

    void Start()
    {
        HighestSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        if (HighestSpeed >= 90)
        {
            locks = 1;
            TextBox.gameObject.SetActive(false);
        }
    }

    public void Ball4Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 4);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}