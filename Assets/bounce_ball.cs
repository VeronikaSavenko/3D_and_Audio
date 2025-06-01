using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallSound : MonoBehaviour
{
    public AudioClip bounceSound; // звук відскоку
    public float minImpactVelocity = 0.5f; // мінімальна швидкість, з якої починається звук

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Перевірка сили удару
        if (collision.relativeVelocity.magnitude > minImpactVelocity)
        {
            audioSource.PlayOneShot(bounceSound);
        }
    }
}
