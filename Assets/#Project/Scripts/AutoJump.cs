using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoJump : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 verticalForce; 
    public Vector3 additionalForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void FixedUpdate() //Update pour la physics
    {
        // Si la velocity de rigidbody est égale à Vector3.zero

        if(rb.velocity == Vector3.zero)
        {
            //Lui donner une force vers le haut (rb.AddForce(force))
            //augmenter verticalForce de additionalForce pour la prochaine fois.
            rb.AddForce(verticalForce);
            verticalForce += additionalForce;

        }
    }
}
