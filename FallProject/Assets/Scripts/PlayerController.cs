using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public MeshCollider platform;
    CharacterController controller;
    
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");


        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        float direction = Mathf.Atan2(movement.x, movement.y) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, direction, 0f);
       
        if (movement.magnitude >= 0.1f) 
        {  
        controller.Move(movement * speed * Time.deltaTime); 
        }
    }
}
