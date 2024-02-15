using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackgroud2D : MonoBehaviour
{
    public float _scrollSpeed;

    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * _scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        _renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
