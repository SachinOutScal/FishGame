using UnityEngine;
using System.Collections;

public class UnderWaterEffect : MonoBehaviour {

	//This script enables underwater effects. Attach to main camera.

	//Define variable
	public int underwaterLevel = 7;
	private bool defaultFog;
	private Color defaultFogColor;
	private float defaultFogDensity;
	private Material defaultSkybox;
	//The scene's default fog settings

	private Material noSkybox;
    private void Awake()
    {

	defaultFog = RenderSettings.fog;
	defaultFogColor = RenderSettings.fogColor;
	defaultFogDensity = RenderSettings.fogDensity;
	defaultSkybox = RenderSettings.skybox;
	}
    void Start () {
		//Set the background color
		//Camera.main.backgroundColor = new Color(0.22f, 0.64f, 0.77f, 0.6f);
		RenderSettings.fog = true;
		RenderSettings.fogColor = new Color(0.22f, 0.64f, 0.77f, 0.6f);
		RenderSettings.fogDensity = 0.045f;
		RenderSettings.skybox = noSkybox;
	}

	void Update () {
		
	}
}