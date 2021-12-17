using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class accelerometer : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
      if (Input.acceleration.x > 1 || Input.acceleration.y > 1 || Input.acceleration.z > 1) {
        GetComponent<Renderer>().material.color = new Color( 0f, 0f, 0f, 0f );
      }
      else {
        GetComponent<Renderer>().material.color = new Color( 1f, 1f, 1f, 1f );
      }
    }
}