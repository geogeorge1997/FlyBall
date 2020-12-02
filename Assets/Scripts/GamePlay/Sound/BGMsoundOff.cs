using UnityEngine;

public class BGMsoundOff : MonoBehaviour {

    public int Music;

	void Start ()
    {
        Music = PlayerPrefs.GetInt("Music", 0);
        if (Music != 1)
        {
            gameObject.SetActive(false);
        }
	}

}