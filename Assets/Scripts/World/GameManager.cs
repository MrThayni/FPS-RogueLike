using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public GameObject canvasObject;
    public TextMeshProUGUI ammoText;
    public TextMeshProUGUI healthText;
    public int health = 100;

    public static GameManager Instance {  get; private set; }
    public int gunAmmo = 10;

    public void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        //ammoText = canvasObject.transform.Find("AmmoScript").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        ammoText.text = gunAmmo.ToString();
        healthText.text = health.ToString();
    }

}
