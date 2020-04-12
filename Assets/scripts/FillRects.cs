using UnityEngine;
using System.Drawing;

public class FillRects : MonoBehaviour
{
    //here  obj from scene
    public GameObject GoodObject, EvilObject;
    private float _g2, _g1;
    private float _e2, _e1;
    public RectTransform GoodObjectTexture, EvilObjectTexture;
    private SpriteRenderer _spriteGoodTexture, _spriteEvilTexture;
    private Point _goodRectSize, _evilRectSize;

    public void Start()
    {
        _spriteGoodTexture = GoodObject.GetComponent<SpriteRenderer>();
        _spriteEvilTexture = EvilObject.GetComponent<SpriteRenderer>();
        _goodRectSize = new Point((int)GoodObjectTexture.rect.height, (int)GoodObjectTexture.rect.width);
        _evilRectSize = new Point((int)EvilObjectTexture.rect.height, (int)EvilObjectTexture.rect.width);

    }
    public void Update()

    {
        _g1 = (float)GoodObject.transform.position.x;
        _g2 = (float)GoodObject.transform.position.y;

        _e1 = (float)EvilObject.transform.position.x;
        _e2 = (float)EvilObject.transform.position.y;

        RectangleF goodSpriteRect = new RectangleF(_g1,
            _g2, (float)_goodRectSize.X, (float)_goodRectSize.Y);
        RectangleF evilSpriteRect = new RectangleF(_e1,
            _e2, (float)_evilRectSize.X, (float)_evilRectSize.Y);


        if (goodSpriteRect.IntersectsWith(evilSpriteRect))
        {
            _spriteGoodTexture.color = UnityEngine.Color.red;
           _spriteEvilTexture.color = UnityEngine.Color.red;
           _spriteEvilTexture.GetComponent<SpriteRenderer>().color = new UnityEngine.Color(255, 255, 0, 100);
        }

    }
}