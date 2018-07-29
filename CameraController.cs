using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform Player;
    public float smoothSped = .125f;
    public Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 desiredPosition = Player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSped); //increase value of smoothsped and multiply with time*deltaTime to get further smoothsped if necessary
        transform.position = smoothedPosition;

        transform.LookAt(Player);
    }


}






