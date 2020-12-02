using UnityEngine;
using UnityEngine.UI;

public class Ball3Script : MonoBehaviour{

    public Text TextBox;
    private int locks,Level;

    void Start()
    {
        Level = PlayerPrefs.GetInt("Level", 0);
        if (Level >= 1)
        {
            locks = 1;
            TextBox.gameObject.SetActive(false);
        }
    }

    public void Ball3Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 3);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}