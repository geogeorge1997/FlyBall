using UnityEngine;

public class BGExplosionFollow : MonoBehaviour {

    public Transform BallPosition;

    void Update()
    {
        transform.position = new Vector3(0,BallPosition.position.y+5,BallPosition.position.z+12);
    }

}