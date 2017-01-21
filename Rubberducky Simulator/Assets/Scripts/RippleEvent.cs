using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleEvent : MonoBehaviour {

    public float radius;
    public float power;
    [SerializeField] private int internalMax;
    private int internalCounter;

    private void Start()
    {
        internalMax = 30;
        //gameObject.transform.localScale = new Vector3(radius / 50.0f, radius / 50.0f, radius / 50.0f);
        gameObject.transform.localScale = new Vector3(radius, radius, radius);
        gameObject.GetComponent<CircleCollider2D>().radius = 0.25f; //Sets Radius of Collider


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb = collision.GetComponent<Rigidbody2D>(); //Duck

        Vector3 newForce = Vector3.Normalize(collision.gameObject.transform.position - this.transform.position);
        Debug.Log("Normalized Vector: " + newForce);
        float distance = Vector2.Distance(collision.gameObject.transform.position, this.transform.position);
        power = (radius / distance) ;
        Debug.Log("Force: " + power);
        Debug.Log("Distance from impact = " + distance);
        rb.AddForce(newForce * power);

        //Debug.Break();
    }

    private void Update()
    {
        internalCounter++;
        if (internalCounter >= internalMax)
        {
            Destroy(gameObject);
        }
    }

}
