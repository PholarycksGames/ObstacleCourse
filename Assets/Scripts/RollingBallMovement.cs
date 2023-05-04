using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBallMovement : MonoBehaviour
{
    [SerializeField] private float rollSpeed;
    private Vector3 rollDirection = Vector3.forward;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(rollDirection * rollSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Wall")
        {
            rollDirection *= -1;
        }
    }
}
