using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{
    SpriteRenderer rend1;
    bool isActive;

    // Start is called before the first frame update
    void Start()
    {
        rend1 = GetComponent<SpriteRenderer>();
        StartCoroutine("FadeOut");
    }

    // Update is called once per frame
    IEnumerator FadeOut()
    {
        //// credits: Alexander Zotov https://www.youtube.com/watch?v=oNz4I0RfsEg
        for (float f = 1f; f >= -0.05f; f -= 0.05f)
        {
            Color col = rend1.material.color;
            col.a = f;
            rend1.material.color = col;
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void startFading()
    {
        StartCoroutine("FadeOut");
    }
}
