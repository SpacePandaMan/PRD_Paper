using UnityEngine;
using System.Collections;

public class Rotato : MonoBehaviour {	
	
	void Update () {

        transform.Rotate(new Vector3(0,90) * Time.deltaTime);

	}
}
