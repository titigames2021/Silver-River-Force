using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{

    public Animator _animator;
    // Start is called before the first frame update
    


    public void FadeIn()
    {
        _animator.Play("FadeIn");
    }

    public void FadeOut()
    {
        _animator.Play("FadeOut");
    }

    public void FadeInOut()
    {

        _animator.Play("FadeInOut");
    }



}
