using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnitEarth : MonoBehaviour
{
    //public GameObject enemyPlayerEarthQuad;

    void Start()
    {
        transform.position = new Vector2(-1.46f, -0.14f);
    }

    void Update()
    {
        transform.Translate(new Vector2(1, 1) * Time.deltaTime);
    }
}
