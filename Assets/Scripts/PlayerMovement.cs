using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(horizontalMovement, 0, verticalMovement);
    }
}
