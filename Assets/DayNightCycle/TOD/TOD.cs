using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TOD : MonoBehaviour
{
    // Start is called before the first frame update
    public float slider = 0.0F;
    public float slider2 = 0.0F;
    private float Tod;

    public Light sun;

    public float speed = 50;

    public bool gui = true;
    public Color NightFogColor;
    public Color DuskFogColor;
    public Color MorningFogColor;
    public Color MiddayFogColor;
    public Color NightAmbientLight;
    public Color DuskAmbientLight;
    public Color MorningAmbientLight;
    public Color MiddayAmbientLight;
    public Color NightTint;
    public Color DuskTint;
    public Color MorningTint;
    public Color MiddayTint;
    public Color SunNight;
    public Color SunDay;
    public Material SkyBoxMaterial1;
    public Material SkyBoxMaterial2;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {

        if (slider >= 1.0)
        {
            slider = 0;
        }

        if (gui)
        {
            slider = GUI.HorizontalSlider(new Rect(25, 25, 100, 30), slider, 0.0F, 1.0F);

        }
        float Hour = slider * 24;
        float Tod = slider2 * 24;
        sun.transform.localEulerAngles = new Vector3((slider * 360) - 90, 0, 0);
        slider = slider + Time.deltaTime / speed;
        sun.color = Color.Lerp(SunNight, SunDay, slider * 2);


        if (slider < 0.5)
        {
            slider2 = slider;
        }
        if (slider > 0.5)
        {
            slider2 = (1 - slider);
        }
        sun.intensity = (slider2 - 0.2F) * 1.70F;


        if (Tod < 4)
        {
            //it is Night
            RenderSettings.skybox = SkyBoxMaterial1;
            RenderSettings.skybox.SetFloat("_Blend", 0);
            SkyBoxMaterial1.SetColor("_Tint", NightTint);
            RenderSettings.ambientLight = NightAmbientLight;
            RenderSettings.fogColor = NightFogColor;
        }
        else if (Tod < 6)
        {
            //it is Dusk

            RenderSettings.skybox = SkyBoxMaterial1;
            RenderSettings.skybox.SetFloat("_Blend", 0);
            RenderSettings.skybox.SetFloat("_Blend", (Tod / 2) - 2);
            SkyBoxMaterial1.SetColor("_Tint", Color.Lerp(NightTint, DuskTint, (Tod / 2) - 2));
            RenderSettings.ambientLight = Color.Lerp(NightAmbientLight, DuskAmbientLight, (Tod / 2) - 2);
            RenderSettings.fogColor = Color.Lerp(NightFogColor, DuskFogColor, (Tod / 2) - 2);

        }
        else if (Tod < 8)
        {
            RenderSettings.skybox = SkyBoxMaterial2;
            RenderSettings.skybox.SetFloat("_Blend", 0);
            RenderSettings.skybox.SetFloat("_Blend", (Tod / 2) - 3);
            SkyBoxMaterial2.SetColor("_Tint", Color.Lerp(DuskTint, MorningTint, (Tod / 2) - 3));
            RenderSettings.ambientLight = Color.Lerp(DuskAmbientLight, MorningAmbientLight, (Tod / 2) - 3);
            RenderSettings.fogColor = Color.Lerp(DuskFogColor, MorningFogColor, (Tod / 2) - 3);
            //it is Morning

        }
        else if (Tod < 10)
        {
            //it is getting Midday

            RenderSettings.ambientLight = MiddayAmbientLight;
            RenderSettings.skybox = SkyBoxMaterial2;
            RenderSettings.skybox.SetFloat("_Blend", 1);
            SkyBoxMaterial2.SetColor("_Tint", Color.Lerp(MorningTint, MiddayTint, (Tod / 2) - 4));
            RenderSettings.ambientLight = Color.Lerp(MorningAmbientLight, MiddayAmbientLight, (Tod / 2) - 4);
            RenderSettings.fogColor = Color.Lerp(MorningFogColor, MiddayFogColor, (Tod / 2) - 4);
        }
    }
}
