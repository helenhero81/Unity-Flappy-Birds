using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationspeed = 1f;
    // start is called before the first frame update
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationspeed * Time.deltaTime, 0);
    }
}