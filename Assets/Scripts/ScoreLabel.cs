using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreLabel : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI _goldLabel;
  [SerializeField] private int _gold;

  private void Start()
  {
    _goldLabel.text = Convert.ToString(_gold);
  }

  public int Gold
  {
    get => _gold;
    set => _gold = value;
  }
}
