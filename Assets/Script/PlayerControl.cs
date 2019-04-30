using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public GameObject playerSprite;

    private string rotationDirection = "Stop";

    // Use this for initialization
    void Start() {

    }

    void FixedUpdate()
    {
        Debug.Log(rotationDirection);
        if (rotationDirection == "Left")
        {
            playerSprite.gameObject.transform.Rotate(Vector3.forward * GameManager.Instance.turretRotateSpeed);

        }
        else if (rotationDirection == "Right")
        {
            playerSprite.gameObject.transform.Rotate(Vector3.back * GameManager.Instance.turretRotateSpeed);
        }
        else if (rotationDirection == "Stop")
        {

        }
    }

    public void TurnLeft()
    {
        rotationDirection = "Left";
    }

    public void TurnRight()
    {
        rotationDirection = "Right";
    }

    public void ControlReleased()
    {
        rotationDirection = "Stop";
    }

}
