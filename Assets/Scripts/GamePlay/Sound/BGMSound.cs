using UnityEngine;

public class BGMSound : MonoBehaviour {

    private static BGMSound instance = null;

    public static BGMSound Instance
    {
        get{return instance;}
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);      
    }

}