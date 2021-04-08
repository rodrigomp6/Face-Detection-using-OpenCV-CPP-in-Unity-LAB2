using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableLampRiddleBehaviour : MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject _plagueDoc;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _plagueDoc = GameObject.Find("PlagueDoctor");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (RiddleManager.errorCount >= 3)
            {
                _plagueDoc.transform.position = new Vector3(-9.13f, -12.37f, 3.654f);
                _plagueDoc.GetComponent<AudioSource>().Play();
            }
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.name.Equals("BP_Table_Lamp_6"))
                {
                    if (RiddleManager.tryLetter('a'))
                        _audioSource.Play();
                    else
                        RiddleManager.errorCount++;
                }
            }

        }


    }
}
