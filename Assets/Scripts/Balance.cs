using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balance : MonoBehaviour
{
    public float TargetRotation;
    public Rigidbody2D rb;
    public float Force;
    private void FixedUpdate() {
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation,TargetRotation,Force * Time.fixedDeltaTime));        
    }
}
