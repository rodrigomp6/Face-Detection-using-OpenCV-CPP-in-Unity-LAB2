using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class RecorderRiddleBehavior : MonoBehaviour
{
    private AudioSource _audioSource;
    private GameObject _plagueDoc;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _plagueDoc = GameObject.Find("PlagueDoctor");
    }

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
                if (hit.transform.name.Equals("BP_Book_Inspection9_4"))
                {
                    if (RiddleManager.tryLetter('g'))
                        _audioSource.Play();
                    else
                        RiddleManager.errorCount++;
                }

            }
        }
    }

}

