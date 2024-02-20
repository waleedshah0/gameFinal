using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green_Platform : MonoBehaviour
{
    public GameObject wall;
    private Renderer rr;

    private void Start()
    {
        rr = wall.GetComponent<Renderer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Green"))
        {
            rr.material.color = Color.green;    // wall color change
            Destroy(other.gameObject);
        }
 
    }
}
