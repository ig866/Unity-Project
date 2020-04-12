using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move1 : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector2(-2, 0f);
    }

    void Update()
    {
        transform.Translate(new Vector2(1, 1) * Time.deltaTime);
    }
}
