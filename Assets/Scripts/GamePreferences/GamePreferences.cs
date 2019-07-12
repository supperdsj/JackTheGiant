using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences {
    public static string EasyDifficulty = "EasyDifficulty";
    public static string MediumDifficulty = "MediumDifficulty";
    public static string HardDifficulty = "HardDifficulty";

    public static string EasyDifficultyScore = "EasyDifficultyScore";
    public static string MediumDifficultyScore = "MediumDifficultyScore";
    public static string HardDifficultyScore = "HardDifficultyScore";

    public static string EasyDifficultyCoinScore = "EasyDifficultyCoinScore";
    public static string MediumDifficultyCoinScore = "MediumDifficultyCoinScore";
    public static string HardDifficultyCoinScore = "HardDifficultyCoinScore";

    public static string IsMusicOn = "IsMusicOn";

    public static void SetEasyDifficultyState(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficulty, difficulty);
    }

    public static void SetMediumDifficultyState(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficulty, difficulty);
    }

    public static void SetHardDifficultyState(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.HardDifficulty, difficulty);
    }

    public static void GetEasyDifficultyState(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
    }

    public static void GetMediumDifficultyState(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
    }

    public static void GetHardDifficultyState(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
    }
    //----
    public static void SetEasyDifficultyScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyScore, difficulty);
    }

    public static void SetMediumDifficultyScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyScore, difficulty);
    }

    public static void SetHardDifficultyScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyScore, difficulty);
    }

    public static void GetEasyDifficultyScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.EasyDifficultyScore);
    }

    public static void GetMediumDifficultyScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.MediumDifficultyScore);
    }

    public static void GetHardDifficultyScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.HardDifficultyScore);
    }
    //----
    public static void SetEasyDifficultyCoinScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.EasyDifficultyCoinScore, difficulty);
    }

    public static void SetMediumDifficultyCoinScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.MediumDifficultyCoinScore, difficulty);
    }

    public static void SetHardDifficultyCoinScore(int difficulty) {
        PlayerPrefs.SetInt(GamePreferences.HardDifficultyCoinScore, difficulty);
    }

    public static void GetEasyDifficultyCoinScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoinScore);
    }

    public static void GetMediumDifficultyCoinScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoinScore);
    }

    public static void GetHardDifficultyCoinScore(int difficulty) {
        PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoinScore);
    }
    
    public static void SetMusicState(int state) {
        PlayerPrefs.SetInt(GamePreferences.IsMusicOn, state);
    }
    public static void GetMusicState(int state) {
        PlayerPrefs.GetInt(GamePreferences.IsMusicOn );
    }
}
