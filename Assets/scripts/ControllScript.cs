using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class ControllScript : MonoBehaviour, IBeginDragHandler, IDragHandler

    
{
    public void Start()
    {
        //quad.transform.position = new Vector2(-8.75f, -3.25f);
        spriteQuad = quad.GetComponent<SpriteRenderer>();
    }

    public GameObject quad;
    SpriteRenderer spriteQuad;
    public float dirX, dirY;
   
    

    public void OnBeginDrag(PointerEventData eventData)
    
         
    {
        

        if ((Mathf.Abs(eventData.delta.x)) > (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.x > 0)
            {
                // quad.transform.position = new Vector2(quad.transform.position.x + 0.50f, quad.transform.position.y);
                // return quad.transform.position;
                spriteQuad.color = Color.blue;
                dirX = + 0.5f;
                dirY = 0;
            }

            else
            {
               // quad.transform.position = new Vector2(quad.transform.position.x - 0.50f, transform.position.y);
                spriteQuad.color = Color.red;
                //  return quad.transform.position;
                dirX = - 0.5f;
                dirY = 0;
            }


        }
        else if ((Mathf.Abs(eventData.delta.x)) < (Mathf.Abs(eventData.delta.y)))
        {
            if (eventData.delta.y > 0)
            {
                //quad.transform.position = new Vector2(transform.position.x, quad.transform.position.y + 0.5f);
                spriteQuad.color = Color.yellow;
                //return quad.transform.position;
                dirY = + 0.5f;
                dirX = 0;
            }
            else
            {
                //quad.transform.position = new Vector2(transform.position.x, quad.transform.position.y - 0.5f);
                spriteQuad.color = Color.green;
                //  return quad.transform.position;
                dirY = - 0.5f;
                dirX = 0;
            }
            

        }
    }



    public void Update()

    {
        //  dirX = 0;
        //  dirY = 0;
        // transform.Translate(new Vector2(1, 0) * Time.deltaTime);
        // quad.transform.position = (new Vector2(quad.transform.position.x+dirX, quad.transform.position.y+dirY)*Time.deltaTime);
        //quad.transform.position = new Vector2(quad.transform.position.x + dirX, quad.transform.position.y + dirY) ;
        quad.transform.position =  Vector2.Lerp(quad.transform.position ,new Vector2 (quad.transform.position.x + dirX, quad.transform.position.y + dirY), Time.deltaTime);

    }

    public void OnDrag(PointerEventData eventData)
    {
    }

   
}
