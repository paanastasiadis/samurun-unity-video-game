﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public bool isShown = false;
    public Text scoreText;
    public Image backgroundImg;
    private float transition = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isShown)
            return;

        transition += Time.deltaTime;
        backgroundImg.color = Color.Lerp(new Color(0, 0, 0, 0),Color.black,transition);
    }

    public  void ToggleEndMenu(float score)
    {
        gameObject.SetActive(true);
        scoreText.text = ((int)score).ToString();
        isShown = true;

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
