using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public Transform objectSpawnPosition;
   public GameObject[] objectsToSpawn;
   public string exampleWord;
   public char singleCharacter;
   
   private int[] scores = new int[3];

   public void SpawnObject(int objectIndex)
   {
      Instantiate(objectsToSpawn[objectIndex], objectSpawnPosition.position, Quaternion.identity);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         SpellEachLetter();
      }
   }

   private void SpellEachLetter()
   {
      for (int i = 0; i < exampleWord.Length; i++)
      {
         print(exampleWord[i]+"\n");
      }
   }
}
