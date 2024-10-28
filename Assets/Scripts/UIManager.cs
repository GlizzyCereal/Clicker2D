using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public TextMeshProUGUI clickText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            Debug.LogWarning("UIManager already exists. Deleting duplicate.");
        }
    }
    public void UpdateClicks(int clicks)
    {
        clickText.text = clicks.ToString();
    }
}
