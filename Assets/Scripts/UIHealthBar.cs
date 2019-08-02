using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    public static UIHealthBar instance { get; private set; }
    public RubyController rubyController;

    public Text healthText;
    
    void Awake()
    {
        instance = this;

    }

    void Start()
    {
        SetValue(rubyController.health);
    }

    public void SetValue(int value)
    {
        healthText.text = value + " / " + rubyController.maxHealth;
    }
}
