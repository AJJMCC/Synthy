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

    public GameObject[] SmolBuilds;
    public GameObject SmolBuildOrigin;

    public float SmolBuildTime1;
    public float SmolBuildTime2;
    private float CurrentSmolBuildTime;

    public GameObject[] MedBuilds;
    public GameObject MedBuildOrigin;

    public float MedBuildTime1;
    public float MedBuildTime2;
    private float CurrentMedBuildTime;

    // Use this for initialization
    void Start () {
        CurrentTreeTime = TreeTime;
        CurrentLightTime = LightTime;
        CurrentSmolBuildTime = Random.Range(SmolBuildTime1,SmolBuildTime2);
        CurrentMedBuildTime = Random.Range(MedBuildTime1, MedBuildTime2);
    }
	
	// Update is called once per frame
	void Update () {
        CurrentTreeTime -= Time.deltaTime;
        CurrentLightTime -= Time.deltaTime;
        CurrentSmolBuildTime -= Time.deltaTime;
        CurrentMedBuildTime -= Time.deltaTime;

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
            Instantiate(SmolBuilds[Random.Range(0, SmolBuilds.Length)], SmolBuildOrigin.transform.position, SmolBuildOrigin.transform.rotation);
            CurrentSmolBuildTime = Random.Range(SmolBuildTime1, SmolBuildTime2);
        }

        if (CurrentMedBuildTime <= 0)
        {
            Instantiate(MedBuilds[Random.Range(0, MedBuilds.Length)], MedBuildOrigin.transform.position, MedBuildOrigin.transform.rotation);
            CurrentMedBuildTime = Random.Range(MedBuildTime1, MedBuildTime2);
        }
	}
}
