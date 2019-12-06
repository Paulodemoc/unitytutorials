using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody Target;
    public float Speed = 4000f;

    //Preferred when interacting with physics and rigidbodies
    private void FixedUpdate()
    {
        Target.AddForce(0, 0, Speed * Time.deltaTime, ForceMode.Force);

        if (Input.GetKey(KeyCode.D))
        {
            Target.AddForce(50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            Target.AddForce(-50 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Target.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}