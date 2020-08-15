﻿
using UnityEngine;

public class ActivateSound : MonoBehaviour
{
    public GameObject player;
    public float accuracy;
    public AudioClip clip;

    private void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void FixedUpdate()
    {
        if (Mathf.Abs(gameObject.transform.position.z - player.transform.position.z) < accuracy)
        {
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
        }
    }
}