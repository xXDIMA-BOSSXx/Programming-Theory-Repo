using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderObject : Object
{
    public override void Jump()
    {
        rb.AddForce(Vector3.up * 1000);
    }
    public override void ChangeSize()
    {
        transform.localScale = new Vector3(5, Random.Range(3, 10), 5);
    }
}
