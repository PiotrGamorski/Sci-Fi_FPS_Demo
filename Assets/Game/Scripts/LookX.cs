using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookX : MonoBehaviour
{
    [SerializeField] private float sensivity = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        Vector3 newRotation = this.transform.localEulerAngles;
        newRotation.y = newRotation.y + (mouseX * sensivity);
        this.transform.localEulerAngles = newRotation;

        //this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, this.transform.eulerAngles.y + mouseX, this.transform.eulerAngles.z);
        //this.transform.rotation = Quaternion.Euler(this.transform.eulerAngles.x, this.transform.eulerAngles.y + mouseX, this.transform.eulerAngles.z);
    }
}
