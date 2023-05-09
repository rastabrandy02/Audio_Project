using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    [SerializeField]
    AudioClip clip;

    private AudioSource source;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Jump()
    {
        source.PlayOneShot(clip);
    }
}
