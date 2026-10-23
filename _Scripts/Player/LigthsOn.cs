using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LigthsOn : MonoBehaviour
{
    public Animator _animator;

      
      


    public void Ligths()
    {

        _animator.Play("LigthsOn");

    }


  public void moreIntensity(){
     
           
           _animator.Play("MoreRange");

   }

   


}
