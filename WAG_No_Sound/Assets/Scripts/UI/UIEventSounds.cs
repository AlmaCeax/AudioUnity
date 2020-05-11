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
        audio_source = GetComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //OnPointerDownSound.Post(gameObject);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        audio_source.clip = ButtonEnterSound;
        audio_source.Play();
        //OnPointerEnterSound.Post(gameObject);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //audio_source.clip = MenuOpenSound;
        //audio_source.Play();
        //OnPointerExitSound.Post(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        //OnPointerUpSound.Post(gameObject);
    }
}