using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject MuzzleFlash;
    public GameObject HitMarkerPrefab;
    
    private ParticleSystem Particle;
    bool isMuzzleFlashActive = false;

    public AudioSource ShootSound;
    bool isShootSoundActive = true;
    public byte Ammunition = 20;

    public bool isCoinCollected;


    // Start is called before the first frame update
    void Start()
    {
        AttachObjectReferences();
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void AttachObjectReferences()
    {
        Particle = MuzzleFlash.GetComponent<ParticleSystem>();
    }

    public void Fire()
    {
        if (Input.GetMouseButton(0) && Ammunition > 0)
        {
            --Ammunition;

            if (!Particle.isPlaying)
                Particle.Play();

            if (!ShootSound.isPlaying)
                ShootSound.Play();

            RaycastHit hitInfo;
            Ray raycastOrigin = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            // Ray raycastOrigin = Camera.main.ScreenPointToRay(new Vector3((Screen.width * 0.5f), (Screen.height * 0.5f), 0));

            if (Physics.Raycast(raycastOrigin, out hitInfo, Mathf.Infinity))
            {
                Instantiate(HitMarkerPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Debug.Log(hitInfo.transform.name);

                if (hitInfo.transform.name == "Wooden_Crate")
                {
                    Destroy(hitInfo.transform.gameObject);
                }

            }
        }
        else
        {
            if (Particle.isPlaying)
                Particle.Stop();

            if (ShootSound.isPlaying)
                ShootSound.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Coin")
            isCoinCollected = true;            
    }
}
