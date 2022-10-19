using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public MeshCollider platform;
    CharacterController controller;
    
    void Awake() {      
     controller = GetComponent<CharacterController>(); 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        if (movement.magnitude >= 0.1f) 
        {     
        controller.Move(movement * 1 * Time.deltaTime); 
        }
    }

    void FixedUpdate() {
        if (Input.GetKeyDown(KeyCode.Space)) {
           GetComponent<Rigidbody>().AddForce(Vector3.up*5, ForceMode.VelocityChange);
           //platform.enabled = true;
        }

        if (Input.GetKey(KeyCode.S)) {
                platform.enabled = false;
            } else {
                platform.enabled = true;
            }
    }
}
