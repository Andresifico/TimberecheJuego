using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class OptionsMenu : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;
    [SerializeField] private TextMeshProUGUI _sliderText2;
    [SerializeField] private TextMeshProUGUI _MenuText;
    int N;

    void Start()
    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0");
            _sliderText2.text = v.ToString("0");
        });
    }
    public void SetSize()
    {
        N = int.Parse(_sliderText.text);
        Debug.Log(N);
        _MenuText.text = N.ToString();

    }

}
