using UnityEngine;

public class InteractableEvent : MonoBehaviour
{
    public Animator animator; // Reference to the Animator component
    public AudioSource audioSource; // Reference to the AudioSource component
    public string agonyAnimation = "agony";
    public string laughingAnimation = "laugh";
    public AudioClip agonySound; // Placeholder for agony sound
    public AudioClip laughingSound; // Placeholder for laughing sound

    private bool isAgony = true; // Track current state

    void Start()
    {
        // Ensure the correct initial animation and sound
        PlayAgony();
    }

    public void TriggerEvent()
    {
        if (isAgony)
        {
            PlayLaughing();
        }
        else
        {
            PlayAgony();
        }
    }

    private void PlayAgony()
    {
        animator.Play(agonyAnimation);
        audioSource.clip = agonySound;
        audioSource.Play();
        isAgony = true;
    }

    private void PlayLaughing()
    {
        animator.Play(laughingAnimation);
        audioSource.clip = laughingSound;
        audioSource.Play();
        isAgony = false;
    }
}
