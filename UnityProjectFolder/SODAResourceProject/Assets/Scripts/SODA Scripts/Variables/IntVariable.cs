﻿using UnityEngine;

[CreateAssetMenu(fileName = "IntVariable", menuName = "SODA Variables/IntVariable")]
public class IntVariable : SODAVariable
{

    public int value;

    public IntVariable() {}

    public IntVariable(IntVariable i) {
        value = i.value;
    }

    public IntVariable(int v) {
        value = v;
    }

    public void SetValue(int v)
    {
        value = v;
    }

    public void SetValue(IntVariable v)
    {
        value = v.value;
    }

    public void ModValue(int amount)
    {
        value += amount;
    }

    public void ModValue(IntVariable amount)
    {
        value += amount.value;
    }

    

    public override string ToString() {
        return "" + value;
    }

    public static implicit operator int(IntVariable reference)
    {
        return reference.value;
    }
    
    //Operator incrementer commands
    public static IntVariable operator ++(IntVariable a) { a.value += 1; return a; }
    public static IntVariable operator --(IntVariable a) { a.value -= 1; return a; }
    

    //Operator commands for 2 IntVariables
    public static bool operator > (IntVariable a, IntVariable b) => (a.value > b.value);
    public static bool operator < (IntVariable a, IntVariable b) => (a.value < b.value);
    public static bool operator >= (IntVariable a, IntVariable b) => (a.value >= b.value);
    public static bool operator <= (IntVariable a, IntVariable b) => (a.value <= b.value);


    //Operator commands for int variable and int
    public static bool operator > (IntVariable a, int b) => (a.value > b);
    public static bool operator < (IntVariable a, int b) => (a.value < b);
    public static bool operator >= (IntVariable a, int b) => (a.value >= b);
    public static bool operator <= (IntVariable a, int b) => (a.value <= b);

    
}