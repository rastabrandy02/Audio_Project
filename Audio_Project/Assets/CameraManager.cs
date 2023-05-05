using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    
    public Camera[] cameras;
    private int currentCameraIndex;

    // Use this for initialization
    void Start()
    {
        currentCameraIndex = 0;

        //Turn all cameras off, except the first default one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
            cameras[i].GetComponent<AudioListener>().enabled = false;
        }

        //If any cameras were added to the controller, enable the first one
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
            cameras[0].GetComponent<AudioListener>().enabled = true;
            Debug.Log("Camera with name: " + cameras[0].GetComponent<Camera>().name + ", is now enabled");

        }
    }

    // Update is called once per frame
    void Update()
    {
        //If the c button is pressed, switch to the next camera
        //Set the camera at the current index to inactive, and set the next one in the array to active
        //When we reach the end of the camera array, move back to the beginning or the array.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentCameraIndex++;
            Debug.Log("Space button has been pressed. Switching to the next camera");
            if (currentCameraIndex < cameras.Length)
            {
                cameras[currentCameraIndex - 1].GetComponent<AudioListener>().enabled = false;
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);

                cameras[currentCameraIndex].GetComponent<AudioListener>().enabled = true;
                cameras[currentCameraIndex].gameObject.SetActive(true);
                
                Debug.Log("Camera with name: " + cameras[currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");
            }
            else
            {
                cameras[currentCameraIndex - 1].GetComponent<AudioListener>().enabled = false;
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                
                currentCameraIndex = 0;
                cameras[currentCameraIndex].GetComponent<AudioListener>().enabled = true;
                cameras[currentCameraIndex].gameObject.SetActive(true);
               
                Debug.Log("Camera with name: " + cameras[currentCameraIndex].GetComponent<Camera>().name + ", is now enabled");
            }
        }
    }
}
