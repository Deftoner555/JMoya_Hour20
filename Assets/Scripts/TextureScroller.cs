using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float speed = .5f;

    Renderer renderer1;
    float offset;
    
    void Start()
    {
        renderer1 = GetComponent<Renderer>();
    }

    void Update()
    {
        //Increase offset based on time
        offset += Time.deltaTime * speed;
        //Keep offset b/w 0 and 1
        if (offset > 1)
            offset -= 1;
        //apply the offset to the material
        renderer1.material.mainTextureOffset = new Vector2(0, offset);
    }
}
