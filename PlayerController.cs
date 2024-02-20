using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController cc;
    float speed = 5f;
    float velocity, mouseSensitivity = 6f, gravity = 9.8f, jumpHeight=0.5f, lookY;
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") *speed* Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") *speed* Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity* Time.deltaTime;

        velocity -= gravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && cc.isGrounded)
        {
            velocity = Mathf.Sqrt(jumpHeight * 2 * gravity);
        }
        Vector3 move = new Vector3(horizontal, velocity, vertical);
        cc.Move(transform.TransformDirection( move));
        transform.Rotate(Vector3.up * mouseX);
        lookY -= mouseY;
        lookY = Mathf.Clamp(lookY, -90, 90);
        Camera.main.transform.localRotation = Quaternion.Euler(lookY,0,0);
    }
}
