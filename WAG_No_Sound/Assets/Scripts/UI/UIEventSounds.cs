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
    private AudioClip ButtonEnterSound;
    private AudioClip ButtonExitSound;
    private AudioClip ButtonOverSound;
    private AudioSource audio_source;

    public void Start()
    {
        audio_source = GameObject.Find("Menus").GetComponent<AudioSource>();
        ButtonEnterSound = GameObject.Find("Menus").GetComponent<Menu>().ButtonEnterSound;
        ButtonExitSound = GameObject.Find("Menus").GetComponent<Menu>().ButtonCloseSound;
        ButtonOverSound = GameObject.Find("Menus").GetComponent<Menu>().ButtonOverSound;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        audio_source.clip = ButtonOverSound;
        audio_source.Play();
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
        audio_source.clip = ButtonExitSound;
        audio_source.Play();
        //OnPointerExitSound.Post(gameObject);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        audio_source.clip = ButtonOverSound;
        audio_source.Play();
        //OnPointerUpSound.Post(gameObject);
    }
}