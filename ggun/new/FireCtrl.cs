using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class FireCtrl : MonoBehaviour
{
    public bool showController = false;
    public InputDeviceCharacteristics controllerCharacteristics;
    public List<GameObject> controllerPrefabs;
    public GameObject handModelPrefab;
    
    private InputDevice targetDevice;
    private GameObject spawnedController;
    private GameObject spawnedHandModel;
    public GameObject ray;
    public GameObject bullet;
    
    public Transform firePos;

    public AudioSource source;
    public AudioClip clip;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandPresence2.targetDevice.TryGetFeatureValue(CommonUsages.trigger, out float triggerValue);
        if (triggerValue >= 0.9F)
        {
            Debug.Log("ok");
            Invoke("Fire", 0.1f);
            source.PlayOneShot(clip);

        } 
    }

    private void Fire()
    {
        Instantiate(bullet, firePos.position, firePos.rotation);
        
    }


}
