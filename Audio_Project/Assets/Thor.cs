using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Thor : MonoBehaviour
{

    private CharacterController charactercontroller;

    public float Speed = 5f; 
    // Start is called before the first frame update
    void Start()
    {
        charactercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        charactercontroller.Move(move * Time.deltaTime * Speed);
    }
}
