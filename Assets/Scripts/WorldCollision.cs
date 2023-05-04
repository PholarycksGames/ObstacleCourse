using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
