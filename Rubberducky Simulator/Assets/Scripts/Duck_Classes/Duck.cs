﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (Random.Range(1, 10) > 8)
        {
            GetComponents<AudioSource>()[0].Play();
        }
        GetComponents<AudioSource>()[Random.Range(1, 3)].Play();
    }

    public IEnumerator Death()
    {
        GetComponent<Rigidbody2D>().Sleep();
        anim.SetTrigger("Dead");

        yield return new WaitForSeconds(0.28f);

        this.gameObject.SetActive(false);
        GameObject.FindGameObjectWithTag("UI").GetComponent<GameplayUI>().UpdateDeathMessege();
       
    }
}
