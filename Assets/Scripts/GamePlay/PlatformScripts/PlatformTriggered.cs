using UnityEngine;

public class PlatformTriggered : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<PlatformMultiplier>().FunMultiply();       
    }

}