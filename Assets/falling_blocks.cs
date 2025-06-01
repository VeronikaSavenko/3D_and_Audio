using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class FallingBlockSound : MonoBehaviour
{
    public AudioClip impactSound;
    public float minImpactVelocity = 0.5f;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Удар достатньо сильний?
        if (collision.relativeVelocity.magnitude > minImpactVelocity)
        {
            audioSource.PlayOneShot(impactSound);
        }
    }
}
