using UnityEngine;
using UnityEngine.UI;

public class Ball5Script : MonoBehaviour{

    public Text TextBox;
    private int locks,Level;

    void Start()
    {
        Level = PlayerPrefs.GetInt("Level", 0);
        if (Level >= 3)
        {
            locks = 1;
            TextBox.gameObject.SetActive(false);
        }
    }

    public void Ball5Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 5);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}