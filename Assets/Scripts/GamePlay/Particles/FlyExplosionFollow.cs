using UnityEngine;

public class FlyExplosionFollow : MonoBehaviour {

    public Transform BallPosition;

	void Update () {

        transform.position =BallPosition.position;
	}

}