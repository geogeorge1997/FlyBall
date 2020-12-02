using UnityEngine;

public class Ball1Script : MonoBehaviour{

    public void Ball1Click()
    {
        PlayerPrefs.SetInt("Ball", 1);
        FindObjectOfType<BallMaterial>().BallMaterialFuntion();
    }
}