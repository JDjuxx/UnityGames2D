using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingKeys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Interact");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Interacting");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Stop interacting");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player jumped!");
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Player jumped!");
        }


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal < 0f || horizontal > 0f)
        {
            Debug.Log("Horizontal value: " + horizontal);
        }
        if (vertical < 0f || vertical > 0f)
        {
            Debug.Log("Vertical value: " + vertical);
        }
    }
}
