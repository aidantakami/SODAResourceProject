﻿using System;

[Serializable]
public class IntReference
{
    public bool useConstant = true;
    public int constantValue;
    public IntVariable variable;

    public IntReference()
    { }

    public IntReference(int value)
    {
        useConstant = true;
        constantValue = value;
    }

    public int Value
    {
        get { return useConstant ? constantValue : variable.value; }
    }

    
}