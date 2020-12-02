using UnityEngine;
using UnityEngine.UI;

public class Ball7Script : MonoBehaviour {

    public Text TextBox;
    private int locks,Level;

    void Start()
    {
        Level = PlayerPrefs.GetInt("Level", 0);
        if (Level >= 5)
        {
            locks= 1;
            TextBox.gameObject.SetActive(false);
        }       
    }

    public void Ball7Click()
    {
        if (locks == 1)
        {
            PlayerPrefs.SetInt("Ball", 7);
        }
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }

}