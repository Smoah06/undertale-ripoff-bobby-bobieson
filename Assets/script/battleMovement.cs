using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleMovement : MonoBehaviour
{
    float speed = 3.5f;

    void Update()
    {

        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime * speed));

    }
}
