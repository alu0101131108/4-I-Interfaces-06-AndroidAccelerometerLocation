using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class location : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      GameObject.Find("gps").GetComponent<TextMesh>().text = "Initializing...";
      Input.location.Start();
      Input.compass.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
      // Compass points to north.
      transform.rotation = Quaternion.Euler(0, -Input.compass.trueHeading, 0);

      // Output location data in text object.
      if (Input.location.status == LocationServiceStatus.Running)
      {
        GameObject.Find("gps").GetComponent<TextMesh>().text = 
            "Latitude: " + Input.location.lastData.latitude + "\n" +
            "Longitude: " + Input.location.lastData.longitude + "\n" +
            "Altitude: " + Input.location.lastData.altitude + "\n";
      }
    }
}