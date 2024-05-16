using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI interactableText;
    [SerializeField] public TextMeshProUGUI keyCounter;
    [SerializeField] public TextMeshProUGUI storyText1;
    [SerializeField] public TextMeshProUGUI storyText2;

    private float sayac1;

    private void Start()
    {
        storyText1.gameObject.SetActive(false);
        storyText2.gameObject.SetActive(false);

    }
    private void FixedUpdate()
    {
        sayac1 += Time.deltaTime;
        if (sayac1 > 1)
        {
            storyText1.gameObject.SetActive(true);
        }
        if (sayac1 > 6)
        {
            storyText1.gameObject.SetActive(false);
            storyText2.gameObject.SetActive(true);
        }
        if (sayac1 > 11)
        {
            storyText2.gameObject.SetActive(false);
        }
    }
}
