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

    public static int GetEasyDifficultyState() {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficulty);
    }

    public static int GetMediumDifficultyState() {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficulty);
    }

    public static int GetHardDifficultyState() {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficulty);
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

    public static int GetEasyDifficultyScore() {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyScore);
    }

    public static int GetMediumDifficultyScore() {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyScore);
    }

    public static int GetHardDifficultyScore() {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyScore);
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

    public static int GetEasyDifficultyCoinScore() {
        return PlayerPrefs.GetInt(GamePreferences.EasyDifficultyCoinScore);
    }

    public static int GetMediumDifficultyCoinScore() {
        return PlayerPrefs.GetInt(GamePreferences.MediumDifficultyCoinScore);
    }

    public static int GetHardDifficultyCoinScore() {
        return PlayerPrefs.GetInt(GamePreferences.HardDifficultyCoinScore);
    }
    
    public static void SetMusicState(int state) {
        PlayerPrefs.SetInt(GamePreferences.IsMusicOn, state);
    }
    public static int GetMusicState() {
        return PlayerPrefs.GetInt(GamePreferences.IsMusicOn );
    }
}
