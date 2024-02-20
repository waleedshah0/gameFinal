using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red_Platform : MonoBehaviour
{

    public GameObject wall;
    private Renderer rr;

    private AudioSource aud;

    // Start is called before the first frame update
    void Start()
    {
        rr = wall.GetComponent<Renderer>();
        aud = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Red"))
        {
            rr.material.color = Color.red;    // wall color change
            //aud.PlayOneShot();
            aud.Play();
            Destroy(other.gameObject);
        }

    }
}
