////////////////////////////////////////////////////////////////////////
//
// Copyright (c) 2018 Audiokinetic Inc. / All Rights Reserved
//
////////////////////////////////////////////////////////////////////////

﻿using UnityEngine;
using System.Collections;

public enum SoundMatType
{
    DIRT,
    GRASS,
    RUBBLE,
    SAND,
    STONE,
    WATER,
    WOOD,
    CRYSTAL
}
public class SoundMaterial : MonoBehaviour
{
    public SoundMatType material;
}
