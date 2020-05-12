using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveEnviromentMusic : MonoBehaviour
{
    public AudioSource father;
    public AudioClip music;
    public AudioClip nightmusic;
    public AudioClip song;
    public AudioClip currentsong;
    // Start is called before the first frame update
    void Start()
    {
        song = music;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.TimeOfDay > 20 || GameManager.TimeOfDay < 6)
        {
            song = nightmusic;     
        }
        else
        {
            song = music;
        }
        

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && currentsong != song)
        {
            father.loop = true;
            father.clip = song;
            father.Play();
            currentsong = song;
        }
    }
}
