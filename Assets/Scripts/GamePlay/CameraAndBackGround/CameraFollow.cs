using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform BallPosition;
    public Vector3 CameraBall;
    public float yCamera, zCamera;

	void Start () {
        //Initilize Values for Camera
        yCamera = 1.81f;
        zCamera = -7.03f;

        CameraBall = new Vector3(0, yCamera, zCamera);
	}
	
	void Update ()
    {
        transform.position = new Vector3(0, BallPosition.position.y + yCamera, BallPosition.position.z + zCamera);
	}
}