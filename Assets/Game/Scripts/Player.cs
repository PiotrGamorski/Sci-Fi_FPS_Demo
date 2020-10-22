using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 3.5f;
    [SerializeField] private float gravity = 9.81f;

    private CharacterController characterController = null;

    // Start is called before the first frame update
    void Start()
    {
        characterController = this?.GetComponent<CharacterController>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 centerPoint = new Vector3(Screen.width / 2, Screen.height / 2, 0);
            //Vector3 centerPoint = Input.mousePosition;
            Ray rayOrigin = Camera.main.ScreenPointToRay(centerPoint);

            if (Physics.Raycast(rayOrigin, Mathf.Infinity))
            {
                Debug.Log("RayCast hits something");
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        CalculateMovement();
    }

    private void CalculateMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(horizontalInput, 0, verticalInput);
        Vector3 velocity = direction * speed;
        velocity.y = velocity.y - gravity;

        velocity = transform.transform.TransformDirection(velocity);
        characterController.Move(velocity * Time.deltaTime);
    }
}
