using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public GameObject player;
    public float rotationSpeed = 70.0f;

    private float distance;

    // Use this for initialization
    void Start () {
        distance = (player.transform.position - transform.position).magnitude;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            transform.RotateAround(player.transform.position, Vector3.up, -rotationSpeed * Time.deltaTime);
        }
        else if  (Input.GetKey(KeyCode.E))
        {
            transform.RotateAround(player.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
        }
        transform.position = player.transform.position - transform.forward * distance;
    }

}
