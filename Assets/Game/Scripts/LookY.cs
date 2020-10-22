using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookY : MonoBehaviour
{
    [SerializeField] private float sensivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y");
        Vector3 newRotation = this.transform.localEulerAngles;
        newRotation.x = newRotation.x - (mouseY * sensivity);
        this.transform.localEulerAngles = newRotation;
    }
}
