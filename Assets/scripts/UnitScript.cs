using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{
    
    void Start()
    {
        transform.position = new Vector2(8.5f,3);
    }

    void Update()
    {
        transform.Translate(new Vector2(-1,0)*Time.deltaTime);
    }
}
