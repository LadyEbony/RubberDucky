using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleEvent : MonoBehaviour {

    public float radius;
    public float maxknockback;
    [SerializeField] private float SecondsUntilDestroyed = 2;
    private int internalCounter;

    private void Start()
    {
        //gameObject.transform.localScale = new Vector3(radius / 50.0f, radius / 50.0f, radius / 50.0f);
        gameObject.transform.localScale = new Vector3(radius, radius, radius);
        //gameObject.GetComponent<CircleCollider2D>().radius = radius; //Sets Radius of Collider
        StartCoroutine("WaitTillDestroyed");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Duck")
        {
            float distance = Vector2.Distance(collision.gameObject.transform.position, this.transform.position);
            if (distance > radius)
                return;

            Rigidbody2D rb = collision.GetComponent<Rigidbody2D>(); //Duck
            float power = 0f;
            Vector3 newForce = Vector3.Normalize(collision.gameObject.transform.position - this.transform.position);
            power = (1f - (distance / radius)) * maxknockback;

            //Debug.Log("Force: " + power);
            //Debug.Log("Distance from impact = " + distance);
            rb.AddForce(newForce * power);
        }
        //Debug.Break();
    }


    IEnumerator WaitTillDestroyed()
    {
        yield return new WaitForSeconds(SecondsUntilDestroyed);
        Destroy(gameObject);
    }
}
