using UnityEngine;
using TMPro;

public class HintTextController : MonoBehaviour
{
    public TMP_Text hintText;
    public GameObject backgroundObject;
    private bool isHintVisible = false;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        hintText.enabled = false; // Hide the hint text initially
        backgroundObject.SetActive(false); // Hide the background initially
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {   
            audioManager.PlaySFX(audioManager.hintSound);
            isHintVisible = !isHintVisible; // Toggle the visibility of the hint text and its background
            hintText.enabled = isHintVisible;
            backgroundObject.SetActive(isHintVisible);
        }
    }
}
