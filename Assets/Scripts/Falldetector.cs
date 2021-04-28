using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falldetector : MonoBehaviour
{
    public GameObject Player;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
    }
}
