////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

using UnityEngine;
using UnityEngine.EventSystems;

public class UIEventSounds : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler
{
    //public AK.Wwise.Event OnPointerDownSound;
    //public AK.Wwise.Event OnPointerUpSound;
    //public AK.Wwise.Event OnPointerEnterSound;
    //public AK.Wwise.Event OnPointerExitSound;
    [Header("Audio")]
    public AudioClip ButtonEnterSound;
    public AudioClip ButtonOverSound;
    private AudioSource audio_source;

    public void Start()
    {
        audio_source = GameObject.Find("Menus").GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        audio_source.PlayOneShot(ButtonEnterSound);
        //OnPointerDownSound.Post(gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audio_source.PlayOneShot(ButtonOverSound);
        //OnPointerEnterSound.Post(gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //OnPointerExitSound.Post(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //OnPointerUpSound.Post(gameObject);
    }
}