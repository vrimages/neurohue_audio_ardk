using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip clip1;
    public AudioClip clip2;
    public AudioClip clip3;


    private GameObject sound1;
    private GameObject sound2;
    private GameObject sound3;

    public GameObject soundPrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    private void OnTriggerEnter(Collider cam){

        if(cam.gameObject.tag == "MainCamera")
        {
            
            Vector3 sourcePos = this.transform.position;
    
            Vector3 sound1Pos = new Vector3(sourcePos.x + .5f, sourcePos.y, sourcePos.z);
            sound1 = Instantiate(soundPrefab, sound1Pos, Quaternion.identity);
            sound1.GetComponent<AudioSource>().clip = clip1;
            sound1.GetComponent<AudioSource>().Play();

            Vector3 sound2Pos = new Vector3(sourcePos.x - .5f, sourcePos.y, sourcePos.z);
            sound2 = Instantiate(soundPrefab, sound2Pos, Quaternion.identity);
            sound2.GetComponent<AudioSource>().clip = clip2;
            sound2.GetComponent<AudioSource>().Play();


            Vector3 sound3Pos = new Vector3(sourcePos.x, sourcePos.y, sourcePos.z + .5f);
            sound3 = Instantiate(soundPrefab, sound3Pos, Quaternion.identity);
            sound3.GetComponent<AudioSource>().clip = clip3;
            sound3.GetComponent<AudioSource>().Play();
        }

    }
    
}
