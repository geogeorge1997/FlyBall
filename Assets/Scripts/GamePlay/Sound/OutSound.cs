using UnityEngine;

public class OutSound : MonoBehaviour {

    public AudioClip OutClip;
    public AudioSource OutSource;

    void Start()
    {
        OutSource.clip = OutClip;
    }

    public void OutSoundCall()
    {
        OutSource.Play();
    }
}