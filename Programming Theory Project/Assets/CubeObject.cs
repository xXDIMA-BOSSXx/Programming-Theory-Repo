using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : Object
{
    public override void Jump()
    {
        rb.AddForce(Vector3.up * 2000);
    }
    public override void ChangeSize()
    {
        transform.localScale = new Vector3(5, 5, Random.Range(3, 10));
    }
}
