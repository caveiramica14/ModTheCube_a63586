using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    Material material;
    float alpha;

    void Start()
    {
        transform.position = new Vector3(5, 3, -6);
        transform.localScale = Vector3.one * 2.4f;
        
        material = Renderer.material;

        Color[] colors = {
            new Color(0f, 0.3f, 0.5f, 1f),
            new Color(0.5f, 0f, 0.1f, 1f),
            new Color(0.2f, 0f, 0.5f, 1f)
        };

        material.color = colors[Random.Range(0, colors.Length)];
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 20.0f * Time.deltaTime, 0.0f);

        alpha = Mathf.PingPong(Time.time, 1);

        Color c = material.color;
        c.a = alpha;
        material.color = c;
    }
}