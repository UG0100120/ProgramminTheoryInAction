using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{


    public TMP_InputField nameInputfield, addressInputfeild, phoneInputfield;
    public Button nameBtn, addressBtn, phoneBtn;
    public TextMeshProUGUI messageText;
    private void Start()
    {
        nameBtn.onClick.AddListener(delegate { SendData(nameInputfield.text.ToString()); });
        addressBtn.onClick.AddListener(delegate { SendData(nameInputfield.text.ToString() ,addressInputfeild.text.ToString()); });
        phoneBtn.onClick.AddListener(delegate { SendData(nameInputfield.text.ToString(),addressInputfeild.text.ToString(),phoneInputfield.text.ToString()); });

    }
    public void SendData(string _name)
    {
        messageText.text = _name.ToString();
    }
    public void SendData(string _name,string _address)
    {
        messageText.text = _name + " " + _address.ToString();
    }
    public void SendData(string _name,string _address,string _phone)
    {
        messageText.text = _name + " " + _address + " " + _phone.ToString();

    }
}
