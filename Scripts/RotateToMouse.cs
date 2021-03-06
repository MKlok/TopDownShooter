﻿using UnityEngine;
using System.Collections;

public class RotateToMouse : MonoBehaviour {
    private Vector3 mouse_pos;
    private Vector3 object_pos;
    private float angle;

	// Update is called once per frame
	void Update () {
        mouse_pos = Input.mousePosition;
        mouse_pos.z = 5.23f; //The distance between the camera and object
        object_pos = Camera.main.WorldToScreenPoint(transform.position);
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
