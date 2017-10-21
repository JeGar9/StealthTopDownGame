using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeePlayer : MonoBehaviour
{

    private FollowingCharacter followingScript;
    private Light light;

    // Use this for initialization
    void Start()
    {
        followingScript = GetComponentInParent<FollowingCharacter>();
        light = GetComponentInChildren<Light>();
        light.color = Color.white;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            followingScript.seenPlayer = true;
            light.color = Color.red;
        }
    }
}
