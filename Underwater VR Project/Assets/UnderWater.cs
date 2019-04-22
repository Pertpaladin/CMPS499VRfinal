using UnityEngine;
using System.Collections;

public class UnderWater : MonoBehaviour
{
    public float waterHeight;

    [SerializeField] bool isUnderwater;

    public Color normalColor;
    public Color underwaterColor;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((transform.position.y < waterHeight) != isUnderwater)
        {
            isUnderwater = transform.position.y < waterHeight;
            if (isUnderwater) SetUnderwater();
            if (!isUnderwater) SetNormal();
        }
    }

    void SetNormal()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = normalColor;
        RenderSettings.fogDensity = 0.01f;

    }

    void SetUnderwater()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = underwaterColor;
        RenderSettings.fogDensity = 0.02f;

    }
}
