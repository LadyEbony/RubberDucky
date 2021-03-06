﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleMover : MonoBehaviour
{
    [SerializeField]
    private float TravelTime = 2f;

    [SerializeField]
    private List<Transform> TravelPoints = new List<Transform>();

    [SerializeField]
    private bool FaceTowardsTarget = false;

    private int curr_pos = 0;

    // Use this for initialization
    void Start()
    {
        if (TravelPoints.Count > 1)
        {
            transform.position = TravelPoints[0].position;
            StartCoroutine("MoveWhale");
        }

    }

    IEnumerator MoveWhale()
    {
        while (true)
        {
            int next_pos;
            if (curr_pos + 1 >= TravelPoints.Count)
            {
                next_pos = 0;
            }
            else
            {
                next_pos = curr_pos + 1;
            }

            if (FaceTowardsTarget)
                FaceTowards(TravelPoints[curr_pos].position, TravelPoints[next_pos].position);

            //Debug.Log(curr_pos + " " + next_pos);
            float time = 0f;
            while (time < TravelTime)
            {
                //Debug.Log(time / TravelTime);
                //Debug.Log(TravelPoints[curr_pos].position + " " + TravelPoints[next_pos].position);
                transform.position = Vector3.Lerp(TravelPoints[curr_pos].position, TravelPoints[next_pos].position, time / TravelTime);
                //Debug.Log(transform.position);
                time += Time.deltaTime;
                yield return null;
            }
            curr_pos = next_pos;
        }
    }

    private void FaceTowards(Vector3 target, Vector3 original)
    {
        Vector3 vectorToTarget = target - original;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg + 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = q;
    }
}
