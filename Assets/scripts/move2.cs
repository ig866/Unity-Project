
using UnityEngine;

public class move2 : MonoBehaviour
{
    public int сollisionInd;
    public float DirX, DirY ;

     void Update()
     {
         transform.Translate(new Vector2(1 + DirX, 1 + DirY) * Time.deltaTime);

        if (сollisionInd == 1 && (DirX == 0)&& (DirY == 0))
        {
            Debug.Log("Отскок (х1-у-1)");
            DirY = -2;
        }
        if (сollisionInd == 1 && (DirX == 0) && (DirY == -2))
        {
            Debug.Log("Отскок (х1-у-1)");
            DirX = -2;
        }

        сollisionInd = 0;

     }

}



