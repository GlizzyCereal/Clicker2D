using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class Clicker : MonoBehaviour
{
    [Header("Animation settings")]
    public float scale = 1.3f;
    public float duration = 0.1f;
    public Ease ease;

    private int clicks = 0;
    public TextMeshProUGUI pointsText;
    private AudioSource clickSound; // Change this line

    private void Start()
    {
        clickSound = GetComponent<AudioSource>(); // Add this line
    }

    private void OnMouseDown()
    {
        clicks++;
        UIManager.instance.UpdateClicks(clicks);
        transform
            .DOScale(1, duration)
            .ChangeStartValue(scale * Vector3.one)
            .SetEase(ease);

        clickSound.Play();
    }
}