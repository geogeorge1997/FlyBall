using UnityEngine;

public class FlySound : MonoBehaviour {

    public AudioClip FlyClip;
    public AudioSource FlySource;

	void Start ()
    {
        FlySource.clip = FlyClip;    
	}

    public void FlySoundCall()
    {
        FlySource.Play();
    }
}