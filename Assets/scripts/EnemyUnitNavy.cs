using UnityEngine;
using System.Drawing;

public class EnemyUnitNavy : MonoBehaviour
{
    private move2 _move2Script;
    public GameObject EvilObject, EarthObject;
    private float _g2, _g1;
    private float _e2, _e1;
    public RectTransform EvilObjectTexture, EarthObjectTexture;
    private SpriteRenderer _spriteEvilTexture, _spriteEarthTexture;
    private Point _evilRectSize, _earthRectSize;
    

    public void Start()
    {
        _spriteEvilTexture = EvilObject.GetComponent<SpriteRenderer>();
        _spriteEarthTexture = EarthObject.GetComponent<SpriteRenderer>();
        _evilRectSize = new Point((int)EvilObjectTexture.rect.height, (int)EvilObjectTexture.rect.width);
        _earthRectSize = new Point((int)EarthObjectTexture.rect.height, (int)EarthObjectTexture.rect.width);
        _move2Script = GameObject.Find("EvilObject").GetComponent<move2>();
    }
    //public void Update()
    public void Update()

    {

        _g1 = EvilObject.transform.position.x;
        _g2 = EvilObject.transform.position.y;

        _e1 = EarthObject.transform.position.x;
        _e2 = EarthObject.transform.position.y;

        RectangleF evilSpriteRect = new RectangleF(_g1,
            _g2, _evilRectSize.X, _evilRectSize.Y);
        RectangleF earthSpriteRect = new RectangleF(_e1,
            _e2, _earthRectSize.X, _earthRectSize.Y);

            if (earthSpriteRect.IntersectsWith(evilSpriteRect))

            {
                _spriteEvilTexture.color = UnityEngine.Color.red;
                
                //_move2Script.DirY = -2;
                _spriteEarthTexture.color = UnityEngine.Color.green;
                Debug.Log("true");
                _move2Script.сollisionInd = 1;
            // _spriteEvilTexture.GetComponent<SpriteRenderer>().color = new UnityEngine.Color(255, 255, 0, 100);
        }
            else
            {
                //_move2Script.DirY = -2;
                //_move2Script.СollisionInd = false;
              // _spriteEvilTexture.color = UnityEngine.Color.blue;
               // Debug.Log("false");
            }
           // _move2Script.сollisionInd = -1;
            //_spriteEvilTexture.color = UnityEngine.Color.blue;
    }
}