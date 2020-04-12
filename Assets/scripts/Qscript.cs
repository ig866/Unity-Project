using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qscript : MonoBehaviour
{
    
   private void OnMouseDown()
    {
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
