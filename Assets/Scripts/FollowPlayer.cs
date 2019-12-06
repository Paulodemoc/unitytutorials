using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    private Vector3 offset = new Vector3(0, 1, -5);

    // Update is called once per frame
    private void Update()
    {
        transform.position = Player.position + offset;
    }
}