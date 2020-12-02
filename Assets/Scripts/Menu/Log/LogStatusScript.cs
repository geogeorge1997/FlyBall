using UnityEngine;
using UnityEngine.UI;

public class LogStatusScript : MonoBehaviour {

    public Text LogStatus;
    public int HigSpeed, AvgSpeed, Level,Games;

	// Use this for initialization
	void Start () {
        Games = PlayerPrefs.GetInt("Games", 0);
        Level = PlayerPrefs.GetInt("Level", 0);
        HigSpeed = PlayerPrefs.GetInt("HighestSpeed", 0);
        AvgSpeed = PlayerPrefs.GetInt("AverageSpeed", 0);

        LogStatus.text = "Played     :  "+Games+"\nLevel       :  " +Level+"\nHighest   :  "+HigSpeed+" Km/Hr\nAverage  :  "+AvgSpeed+" Km/Hr";		
	}

}