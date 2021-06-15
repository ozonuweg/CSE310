using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other is BoxCollider)
        {
            Debug.Log ("Collision Detected");
        }


        if (other is CapsuleCollider)
        {
            ScoringSystem.theScore += 50;
            Destroy(other);
            Debug.Log ("Coin Collected");
        }
    }
}
