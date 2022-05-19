using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;

public class WindAnim : MonoBehaviour
{
    [SerializeField]
    private Vector3 from;
    [SerializeField]
    private Vector3 to;
    [SerializeField]
    private float duration=.5f;
    [SerializeField]
    private Transform target;
    void Start()
    {
        target.localRotation = Quaternion.Euler(from);
        target.DORotate(to, duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
