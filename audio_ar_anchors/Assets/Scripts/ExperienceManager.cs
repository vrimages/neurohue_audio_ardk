using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

using Niantic.ARDK.Extensions;

public class ExperienceManager : MonoBehaviour
{
    public GameObject sessionManager;

    public GameObject arMesh;

    public ARCameraPositionHelper helper;
    public ARRenderingManager renderManage;
    public ARDepthManager depthManage;

    private GameObject cylinder;

    private GameObject sound1;
    private GameObject sound2;
    private GameObject sound3;

    public GameObject soundPrefab;

    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;

    public GameObject cylPrefab;


    void Start(){
        SessionOff();
    }

    public void SessionOff(){
        sessionManager.SetActive(false);
        arMesh.SetActive(false);
        helper.enabled = false;
        renderManage.enabled = false;
        depthManage.enabled = false;
    }

    public void SessionOn(){
        sessionManager.SetActive(true);
        arMesh.SetActive(true);
        helper.enabled = true;
        renderManage.enabled = true;
        depthManage.enabled = true;
    }

    public void ShowSounds(){
        cylinder = GameObject.Find("Cylinder(Clone)");
        //cylinder = Instantiate(cylPrefab, new Vector3(0,0,0), Quaternion.identity);
        Vector3 cylPos = cylinder.transform.position;
        //cylinder.transform.position = new Vector3(cylPos.x, cylPos.y+1, cylPos.z);
        Vector3 sound1Pos = new Vector3(cylPos.x + 2, cylPos.y+1, cylPos.z);
        sound1 = Instantiate(soundPrefab, sound1Pos, Quaternion.identity);
        sound1.GetComponent<AudioSource>().clip = clip1;
        sound1.GetComponent<AudioSource>().Play();

        Vector3 sound2Pos = new Vector3(cylPos.x - 2, cylPos.y+1, cylPos.z);
        sound2 = Instantiate(soundPrefab, sound2Pos, Quaternion.identity);
        sound2.GetComponent<AudioSource>().clip = clip2;
        sound2.GetComponent<AudioSource>().Play();

        Vector3 sound3Pos = new Vector3(cylPos.x, cylPos.y+1, cylPos.z + 2);
        sound3 = Instantiate(soundPrefab, sound3Pos, Quaternion.identity);
        sound3.GetComponent<AudioSource>().clip = clip3;
        sound3.GetComponent<AudioSource>().Play();

    }


    public void HideSounds(){
        sound1.SetActive(false);
        sound2.SetActive(false);
        sound3.SetActive(false);
    }



    /*

    public GameObject cylinder2;
    public TextMeshProUGUI text;


    public ARHitTester2 arhit;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Submit()
    {
        cylPos = arhit.cylinder.transform;
        Instantiate(cylinder2, new Vector3(cylPos.x, cylPos.y, cylPos.z + 5f), Quaternion.identity);
    }*/
}
