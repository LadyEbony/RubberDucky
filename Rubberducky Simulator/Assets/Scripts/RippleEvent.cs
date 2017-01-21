using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleEvent : MonoBehaviour {

    public float radius;
    public float power;

    private int internalCounter;
    public int internalMax;

    private void Start()
    {
        internalMax = 30;
        //gameObject.GetComponent<SphereCollider>().radius = gameObject.transform.localScale.x / 2;
        //radius = gameObject.GetComponent<SphereCollider>().radius;
        //power = 200.0f;

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius);

        }
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
