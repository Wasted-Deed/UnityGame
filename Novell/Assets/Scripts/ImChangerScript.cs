using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImChangerScript : MonoBehaviour
{
    
    private int frameIndex;
    public Sprite[] sprites;
    [SerializeField] private Image imChanger;

 public void Start()
 {
     imChanger.sprite = sprites[0];
 }
 public void FixedUpdate()
 {
      Debug.Log(frameIndex);
      imChanger.sprite = sprites[frameIndex];
 }
 public void NextFrame()
  {
     
     if (frameIndex < sprites.Length-1)
     {
       
      frameIndex ++;
      
     }
     else
      frameIndex = 0;
         
  }
}
