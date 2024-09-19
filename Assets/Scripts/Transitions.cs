using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transitions : MonoBehaviour
{
    [SerializeField] private Animator transitionsAnimator;
    [SerializeField] private Button firstPageNext;
    [SerializeField] private Button secondPagePrevious;
    [SerializeField] private Button secondPageNext;
    [SerializeField] private Button lastPagePrevious;

    private const string FirstToSecond = "FirstToSecond";
    private const string SecondToFirst = "SecondToFirst";
    private const string SecondToLast = "SecondToLast";
    private const string LastToSecond = "LastToSecond";

    private void Start()
    {
        firstPageNext.onClick.AddListener(() => SetTransition(FirstToSecond));
        secondPagePrevious.onClick.AddListener(() => SetTransition(SecondToFirst));
        secondPageNext.onClick.AddListener(() => SetTransition(SecondToLast));
        lastPagePrevious.onClick.AddListener(() => SetTransition(LastToSecond));
    }

    private void SetTransition(string currentTransition)
    {
        transitionsAnimator.SetBool(FirstToSecond, false);
        transitionsAnimator.SetBool(SecondToFirst, false);
        transitionsAnimator.SetBool(SecondToLast, false);
        transitionsAnimator.SetBool(LastToSecond, false);

        transitionsAnimator.SetBool(currentTransition, true);
    }
}
