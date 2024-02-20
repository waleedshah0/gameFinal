using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    AudioSource audiosource;
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audiosource.PlayOneShot(ac);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray , out RaycastHit hitinfo))
            {
                Debug.Log("Hitinfo name " + hitinfo.transform.name);
                if(hitinfo.transform.tag == "Enemy")
                {
                    hitinfo.transform.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    //Destroy(hitinfo.transform.gameObject);
                }
            }
            Debug.DrawRay(ray.origin, ray.direction *hitinfo.distance, Color.blue, 50f);
        };
    }
}
