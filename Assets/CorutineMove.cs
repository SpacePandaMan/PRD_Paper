using UnityEngine;
using System.Collections;

public class CorutineMove : MonoBehaviour {

    private Vector3 newPos;
    public GameObject Item;

	void Awake () {
        newPos = transform.position;
	}

	void Update () {
        PositionChange();
    }

    void PositionChange()
    {
        Vector3 positionA = new Vector3(-95, -20, -3);
        Vector3 positionB = new Vector3(-128, -15, 247);

        if (Input.GetKeyDown(KeyCode.Q))
            newPos = positionA;
        if (Input.GetKeyDown(KeyCode.E))
            newPos = positionB;

        transform.position = newPos;
         
    }

}
