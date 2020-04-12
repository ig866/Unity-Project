using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testmove : MonoBehaviour

{
public GameObject Box;
static int collB = 8, rowB = 8;


void CrateGamePole() 
{
    float Dx = 1f, Dy = 1f;
    Vector2 MyStanceB = new Vector2(-41, -7);


        for (int YY = 0; YY<rowB;YY++) 
    {
        for (int XX = 0; XX<collB; XX++)
        {
            Instantiate(Box, MyStanceB, Quaternion.identity);

            MyStanceB.x += Dx;
        }
        MyStanceB.x = -41f;
        MyStanceB.y += Dy;
    }

}
          
 


// Start is called before the first frame update
void Start()
{
CrateGamePole();
}

// Update is called once per frame
void Update()
{

}
}