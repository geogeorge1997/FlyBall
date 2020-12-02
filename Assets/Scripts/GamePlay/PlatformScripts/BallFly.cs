using UnityEngine;

public class BallFly : MonoBehaviour {

    public int Vibration,Sound;
    
    void Start()
    {
        Vibration = PlayerPrefs.GetInt("Vibration", 1);
        Sound = PlayerPrefs.GetInt("Sound", 1);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Vibration == 1)
        {
            Handheld.Vibrate();
        }
        if (Sound == 1)
        {
            FindObjectOfType<FlySound>().FlySoundCall();
        }
        FindObjectOfType<BallMove>().FuntionFly();
        PlayerPrefs.SetInt("DestroyObstacle", 1);
        FindObjectOfType<EmptyObjectScript>().FreeLifeGain();
    }
}