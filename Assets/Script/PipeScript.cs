using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{

    void Update()
    {
        transform.position = new Vector2(transform.position.x - 1 * Time.deltaTime, transform.position.y);
    }
}
