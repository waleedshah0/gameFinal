using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blue_Platform : MonoBehaviour
{

    public GameObject wall;
    private Renderer rr;


    // Start is called before the first frame update
    void Start()
    {
        rr = wall.GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Blue"))
        {
            rr.material.color = Color.blue;    // wall color change
            Destroy(other.gameObject);
        }

    }
}
