using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sun_mover : MonoBehaviour
{
    public Gradient AmbientColor;
    public Gradient DirectionalColor;
    public Gradient FogColor;
    // References
    public Light DirectionalLight;

    public float TOD;

    // Update is called once per frame
    void Update()
    {
        TOD += Time.deltaTime / 100;
        TOD %= 1;
        UpdateLighting(TOD);
    }

    void UpdateLighting(float time)
    {
        RenderSettings.ambientLight = AmbientColor.Evaluate(time);
        RenderSettings.fogColor = FogColor.Evaluate(time);
        DirectionalLight.color = DirectionalColor.Evaluate(time);
        transform.localRotation = Quaternion.Euler(new Vector3((time * 360f) - 90f, 170f, 0));
    }
    
}
