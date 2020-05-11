////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;
﻿using UnityEngine.Audio;
using System.Collections;

public class SliderControlledRTPC : MonoBehaviour
{
    public AudioMixer gameMixer;

    public void SetMasterVol(float value)
    {
        gameMixer.SetFloat("masterVol", value);
    }

    public void SetMusicVol(float value)
    {
        gameMixer.SetFloat("musicVol", value);
    }

    public void SetSFXVol(float value)
    {
        gameMixer.SetFloat("sfxVol", value);
    }

    public void SetDialogVol(float value)
    {
        gameMixer.SetFloat("dialogVol", value);
    }
}
