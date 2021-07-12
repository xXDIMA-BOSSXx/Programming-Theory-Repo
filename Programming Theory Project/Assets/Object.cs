using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour //INHERITANCE
{
    public Color color { get; set; } // ENCAPSULATION
    public Material material;
    public Vector3 position { get; set; }
    public string objectsName { get; set; } 
    public Rigidbody rb;
    private void Start()
    {
        
        material = GetComponent<MeshRenderer>().material;
        color = material.color;
        position = transform.position;
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump(); //ABSTRACTION
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            ChangeSize(); 
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ChangeColor(); 
        }

    }
    public virtual void Jump() //POLYMORPHISM
    {
        rb.AddForce(Vector3.up * 1000);
    }
    public void ChangeColor()
    {
        float rand = Random.Range(0f, 1.0f);
        float rand2 = Random.Range(0f, 1f);
        float rand3 = Random.Range(0f, 1f);
        material.color = new Color(rand, rand2, rand3, 1);

    }

    public virtual void ChangeSize()
    {
        transform.localScale = new Vector3(Random.Range(3, 10), Random.Range(3, 10), Random.Range(3, 10));
    }
}

