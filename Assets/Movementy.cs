using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Movementy : MonoBehaviour {

    public float speed = 10f;
    public float sensitivity = 2f;
    CharacterController player;

    public GameObject Eyes;

    float moveFB;
    float moveLR;

    float rotX;
    float rotY;

    float vertVelocity;

    float jumpDist = 5f;

	// Use this for initialization
	void Start () {

        player = GetComponent<CharacterController>();
	
	}
	
	// Update is called once per frame
	void Update () {

        moveFB = Input.GetAxis("Vertical") * speed;
        moveLR = Input.GetAxis("Horizontal") * speed;

        rotX = Input.GetAxis("Mouse X") * sensitivity;
        rotY = Input.GetAxis("Mouse Y") * sensitivity;

        //rotY = Mathf.Clamp(rotY, -60f, 60f);

        Vector3 movement = new Vector3(moveLR, vertVelocity, moveFB);
        transform.Rotate(0, rotX, 0);
        //Eyes.transform.localRotation = Quaternion.Euler(rotY, 0, 0);
        Eyes.transform.Rotate(-rotY, 0, 0);

        movement = transform.rotation * movement;
        player.Move(movement * Time.deltaTime);


        if (player.isGrounded == true){
            if (Input.GetButtonDown("Jump")){
                vertVelocity += jumpDist;
            }
        }
	}

    void FixedUpdate()
    {
        if (player.isGrounded == false)
        {
            vertVelocity += Physics.gravity.y * Time.deltaTime;
        }
        else
        {
            vertVelocity = 0f;
        }
    }
}
