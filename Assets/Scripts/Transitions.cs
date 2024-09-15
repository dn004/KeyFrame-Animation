using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Transitions : MonoBehaviour
{
    public Animator transitionsAnimator;
    public Button FirstPageNext;
    public Button SecondPagePrevious;
    public Button SecondPageNext;  
    public Button LastPagePrevious;

    void Start()
    {
        FirstPageNext.onClick.AddListener(() => First2Second());
        SecondPagePrevious.onClick.AddListener(() => Second2First());
        SecondPageNext.onClick.AddListener(() => Second2Last());
        LastPagePrevious.onClick.AddListener(() => Last2Second());
    }

    public void First2Second()
    {
        transitionsAnimator.SetBool("FirstToSecond", true);
        transitionsAnimator.SetBool("SecondToFirst", false);
        transitionsAnimator.SetBool("SecondToLast", false);
        transitionsAnimator.SetBool("LastToSecond", false);
    }

    public void Second2First()
    {
        transitionsAnimator.SetBool("SecondToFirst", true);
        transitionsAnimator.SetBool("FirstToSecond", false);
        transitionsAnimator.SetBool("SecondToLast", false);
        transitionsAnimator.SetBool("LastToSecond", false);
    }

    public void Second2Last()
    {
        transitionsAnimator.SetBool("SecondToLast", true);
        transitionsAnimator.SetBool("FirstToSecond", false);
        transitionsAnimator.SetBool("SecondToFirst", false);
        transitionsAnimator.SetBool("LastToSecond", false);
    }

    public void Last2Second()
    {
        transitionsAnimator.SetBool("LastToSecond", true);
        transitionsAnimator.SetBool("FirstToSecond", false);
        transitionsAnimator.SetBool("SecondToFirst", false);
        transitionsAnimator.SetBool("SecondToLast", false);
    }
}
