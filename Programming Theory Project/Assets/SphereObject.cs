using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObject : Object
{
    public override void Jump() // POLYMORPHISM
    {
        rb.AddForce(Vector3.up * 1500);
    }
    public override void ChangeSize()
    {
        transform.localScale = new Vector3(Random.Range(3, 10),5 , 5);
    }
}
