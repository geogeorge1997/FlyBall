using UnityEngine;
using UnityEngine.UI;

public class Ball2Script : MonoBehaviour{

    public Text TextBox;
    private int locks,HighestSpeed;

    void Start()
    {
        HighestSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        if (HighestSpeed >= 70)
        {
            locks = 1;
            TextBox.gameObject.SetActive(false);
        }
    }

    public void Ball2Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 2);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}