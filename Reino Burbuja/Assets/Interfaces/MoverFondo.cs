using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverFondo : MonoBehaviour
{
    public RawImage img;
    public float x;
    private float time;
    public float max;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time<=max)
        {
            img.uvRect = new Rect(img.uvRect.position + new Vector2(x, 0) * Time.deltaTime, img.uvRect.size);
            time += Time.deltaTime;
        }
        else if (time <= 2*max)
        {
            img.uvRect = new Rect(img.uvRect.position - new Vector2(x, 0) * Time.deltaTime, img.uvRect.size);
            time += Time.deltaTime;
        }
        else
        {
            time = 0;
        }

    }
}
