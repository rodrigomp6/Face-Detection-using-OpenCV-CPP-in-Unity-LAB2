using System;
using UnityEngine;

public static class RiddleManager
{
    public static int errorCount = 0;
    private static int guessingPosition = 0;
    private static String riddle = "gaap";


    public static Boolean tryLetter(Char letter)
    {
        if (riddle[guessingPosition].Equals(letter))
        {
            Debug.Log("Match: " + letter);
            guessingPosition++;
            return true;
        }
        return false;
    }

}
