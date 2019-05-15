using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadCustardFactory(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadBullring(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadCustardAR(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadBullringAr(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
