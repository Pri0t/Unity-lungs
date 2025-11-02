using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotationController : MonoBehaviour
{
    
    public GameObject PlanetObject;
    public Vector3 RotationSpeed;
    // Update is called once per frame
    private void Update()
    {
        PlanetObject.transform.Rotate(RotationSpeed * Time.deltaTime);
    }
}
