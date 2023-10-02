using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HudLogic : MonoBehaviour
{
    private TextMeshProUGUI _text;
    [SerializeField] private PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        Debug.Log("HudLogic");
    }

    // Update is called once per frame
    void Update()
    {
        _text.text = playerData.currentLife + "";
    }
}
