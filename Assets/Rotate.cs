﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	void Update () {

        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);

    }
}
