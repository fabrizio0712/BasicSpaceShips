using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject boss;
    [SerializeField] GameObject button;
    [SerializeField] GameObject victory;
    [SerializeField] GameObject defeat;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!player.active) 
        {
            defeat.SetActive(true);
            button.SetActive(true);
        }
        if (!boss.active) 
        {
            button.SetActive(true);
            victory.SetActive(true);
        }
    }
    public void OpenLvl(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
