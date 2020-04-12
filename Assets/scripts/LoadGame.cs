using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadGame : MonoBehaviour { 

 public GameObject Box;
 public GameObject BoxTerrian;

    static int collB = 41, rowB = 14 ;
    static int collTop = 45, rowTop = 2;
    static int collBot = 45, rowBot = 2;
    static int collRight = 2, rowRight = 14;
    static int collLeft= 2, rowLeft = 14;




    void CrateGamePole() 
    {
        float Dx = 1f, Dy = 1f;

        Vector2 MyStanceB = new Vector2(-20, -5);//21/7
        Vector2 MyStanceTop = new Vector2(-22, 9);//21/7
        Vector2 MyStanceBot = new Vector2(-22, -7);//21/7
        Vector2 MyStanceRight = new Vector2(21, -5);//21/7
        Vector2 MyStanceLeft = new Vector2(-22, -5);//21/7



        for (int YY = 0; YY < rowB; YY++)
        {
            for (int XX = 0; XX < collB; XX++)
            {
                Instantiate(Box, MyStanceB, Quaternion.identity);
                MyStanceB.x += Dx;
            }

            MyStanceB.x = -20f;
            MyStanceB.y += Dy;
        }

        for (int YY = 0; YY < rowTop; YY++)
        {
            for (int XX = 0; XX < collTop; XX++)
            {
                Instantiate(BoxTerrian, MyStanceTop, Quaternion.identity);
                MyStanceTop.x += Dx;
            }
            MyStanceTop.x = -22f;
            MyStanceTop.y += Dy;
        }

        for (int YY = 0; YY < rowBot; YY++)
        {
            for (int XX = 0; XX < collBot; XX++)
            {
                Instantiate(BoxTerrian, MyStanceBot, Quaternion.identity);
                MyStanceBot.x += Dx;
            }
            MyStanceBot.x = -22f;
            MyStanceBot.y += Dy;

        }
        for (int YY = 0; YY < rowRight; YY++)
        {
            for (int XX = 0; XX < collRight; XX++)
            {
                Instantiate(BoxTerrian, MyStanceRight, Quaternion.identity);
                MyStanceRight.x += Dx;
            }
            MyStanceRight.x = 21f;
            MyStanceRight.y += Dy;

        }
        for (int YY = 0; YY < rowLeft; YY++)
        {
            for (int XX = 0; XX < collLeft; XX++)
            {
                Instantiate(BoxTerrian, MyStanceLeft, Quaternion.identity);
                MyStanceLeft.x += Dx;
            }
            MyStanceLeft.x = -22f;
            MyStanceLeft.y += Dy;

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
