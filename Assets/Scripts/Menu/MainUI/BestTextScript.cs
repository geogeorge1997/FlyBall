using UnityEngine;
using UnityEngine.UI;

public class BestTextScript : MonoBehaviour {

    public Text BestText;
    public int HighSpeed;

	void Start () {
        HighSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        BestText.text = "Best\n" + HighSpeed + " Km/Hr";
	}
	
}