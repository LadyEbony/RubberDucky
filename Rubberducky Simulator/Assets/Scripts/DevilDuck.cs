﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevilDuck : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Duck")
        {
            StartCoroutine(other.gameObject.GetComponent<Duck>().Death());
            if (other.gameObject.GetComponent<DevilDuck>() != null)
                StartCoroutine(GetComponent<Duck>().Death());
            this.GetComponent<AudioSource>().Play();
        }
    }
}
