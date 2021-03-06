﻿using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StringsAndChars : MonoBehaviour
{
   public string wordToSpell;
   public string introMessage;
   public char singleCharacter;
   public GameObject speechBubble;
   public TextMeshProUGUI speechBubbleText;

   private void Start()
   {
      print("single character = " + (int)singleCharacter);
   }

   private void Update()
   {
      // spell our word
      if (Input.GetKeyDown(KeyCode.Return))
      {
         StartCoroutine(SpellWord());
      }
      
      // show char in console
      
   }

   private IEnumerator SpellWord()
   {
      if (!speechBubble.activeSelf)
      {
         speechBubble.SetActive(true);
      }

      // say intro text
      speechBubbleText.text = introMessage;

      // wait for three seconds
      yield return new WaitForSeconds(3f);
      
      // spell the word, iterating over each letter
      for (int i = 0; i < wordToSpell.Length; i++)
      {
         
         speechBubbleText.text = wordToSpell[i].ToString();
         yield return new WaitForSeconds(.25f);
      }
      
      speechBubble.SetActive(false);
   }
}
