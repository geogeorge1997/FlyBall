using UnityEngine;

public class OutExplosionFollow : MonoBehaviour{

    public Transform BallPosition;

    void Update()
    {
        transform.position = BallPosition.position;
    }

}