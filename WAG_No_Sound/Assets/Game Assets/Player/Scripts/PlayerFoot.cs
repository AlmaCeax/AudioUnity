////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFoot : MonoBehaviour
{
    public MaterialChecker materialChecker;
    public AK.Wwise.Event FootstepSound;

    #region private variables
    private bool inWater;
    #endregion

    public void PlayFootstepSound()
    {
        if (!inWater)
        {
            materialChecker.CheckMaterial(gameObject); //This also sets the material if a SoundMaterial is found!
        }

        int sound_type = (int)materialChecker.GetMaterial();
        int sound_index = 0;
        if (PlayerManager.Instance.isSprinting)
            sound_index = Random.Range(0, PlayerManager.Instance.runFootstepClips[sound_type].myList.Count);
        else
            sound_index = Random.Range(0, PlayerManager.Instance.walkFootstepClips[sound_type].myList.Count);

        PlayerManager.Instance.playerAudio.PlayOneShot(PlayerManager.Instance.runFootstepClips[sound_type].myList[sound_index]);
        //FootstepSound.Post(gameObject);
    }

    public void EnterWaterZone()
    {
        inWater = true;
    }

    public void ExitWaterZone()
    {
        inWater = false;
    }

}
