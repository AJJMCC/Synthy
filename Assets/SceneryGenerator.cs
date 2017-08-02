using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneryGenerator : MonoBehaviour {

    public GameObject Tree;
    public GameObject TreeGenSpot;

    public float TreeTime;
    private float CurrentTreeTime;

    public GameObject Light;
    public GameObject LightOrigin;

    public float LightTime;
    private float CurrentLightTime;

    public GameObject SmolBuild;
    public GameObject SmolBuildOrigin;

    public float SmolBuildTime;
    private float CurrentSmolBuildTime;

    // Use this for initialization
    void Start () {
        CurrentTreeTime = TreeTime;
        CurrentLightTime = LightTime;
      CurrentSmolBuildTime = SmolBuildTime;
	}
	
	// Update is called once per frame
	void Update () {
        CurrentTreeTime -= Time.deltaTime;
        CurrentLightTime -= Time.deltaTime;
        CurrentSmolBuildTime -= Time.deltaTime;
        if (CurrentTreeTime <= 0)
        {
            Instantiate(Tree, TreeGenSpot.transform.position, TreeGenSpot.transform.rotation);
            CurrentTreeTime = TreeTime;
        }

        if (CurrentLightTime <= 0)
        {
            Instantiate(Light, LightOrigin.transform.position, LightOrigin.transform.rotation);
            CurrentLightTime = LightTime;
        }

        if (CurrentSmolBuildTime <= 0)
        {
            Instantiate(SmolBuild, SmolBuildOrigin.transform.position, SmolBuildOrigin.transform.rotation);
            CurrentSmolBuildTime = SmolBuildTime;
        }
	}
}
