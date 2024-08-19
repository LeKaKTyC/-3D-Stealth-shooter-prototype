﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


    public static class Utilities
    {
        public static int playerDeaths = 0;

        public static string UpdateDeathCount (ref int countReference)
        {
            countReference++;
            return "Next time you'll be at # " + countReference;
        }

        public static void RestartLevel()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;

            Debug.Log("Player Deaths: " + playerDeaths);
            string message = UpdateDeathCount(ref playerDeaths);
            Debug.Log("Player Deaths: " + playerDeaths);
        }

        public static bool RestartLevel(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);
            Time.timeScale = 1.0f;
            return true;
        }


    }
    
  