using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObject : MonoBehaviour
{
    public AudioSource pickupSound;
    public float rotationSpeed = 0.1f;
    public GameObject pickupModel;
    public ParticleSystem collectParticles;

    private bool isFound = false;

    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }

    public void OnPickupFound()
    {
        if (isFound == false)
        {
            isFound = true;
            pickupModel.SetActive(false);
            pickupSound.Play();
            collectParticles.Play();
        }
    }

}