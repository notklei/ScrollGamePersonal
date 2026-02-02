using UnityEngine;

public class ScrollBG : MonoBehaviour
{
    public GameObject Square;
    public Material MaterialBG;
    float speed;
    void Start()
    {
        Square.transform.localEulerAngles = new Vector3 (0f, 0f, 30f);
        speed = 2f;

    }

     void Update()
    {
        //Square.transform.position = new Vector3(Square.transform.position.x + speed * Time.deltaTime, Square.transform.position.y, Square.transform.position.z);
        MaterialBG.mainTextureOffset = new Vector2(MaterialBG.mainTextureOffset.x + speed * Time.deltaTime, MaterialBG.mainTextureOffset.y);
    }
}
