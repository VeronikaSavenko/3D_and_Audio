using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BallSound : MonoBehaviour
{
    public AudioClip bounceSound; // ���� �������
    public float minImpactVelocity = 0.5f; // �������� ��������, � ��� ���������� ����

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // �������� ���� �����
        if (collision.relativeVelocity.magnitude > minImpactVelocity)
        {
            audioSource.PlayOneShot(bounceSound);
        }
    }
}
