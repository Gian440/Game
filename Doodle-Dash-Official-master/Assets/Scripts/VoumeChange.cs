using UnityEngine;

public class VoumeChange : MonoBehaviour
{
    //Refers to audio souyrce component
    private AudioSource audioSrc;

    //Music volume variable that will be modified by dragging slider knob
    private float musicVolume = 1f;

    //Use this for initialization
    void Start()
    {
        //Assign audio source compent to control it
        audioSrc = GetComponent<AudioSource>();
    }

    //Update is called once per frame
    void Update()
    {
        //Setting vloume option of Audio Source to be equal to music version
        audioSrc.volume = musicVolume;
    }

    //Method that is called by slider game object
    //This method takes vol value passed by slider and sets it as musicValue
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }
}