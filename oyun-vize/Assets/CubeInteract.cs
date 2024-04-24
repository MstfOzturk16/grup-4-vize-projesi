using UnityEngine;
using TMPro;

public class CollisionLogger : MonoBehaviour
{
    // TextMeshPro metin bile�eni
    public TextMeshProUGUI textComponent; // Inspector'dan TextMeshPro nesnesini atay�n

    private void OnTriggerEnter(Collider other)
    {
        // �arp��man�n di�er nesnesinin ad�n� al�yoruz
        string objectName = other.name;

        // TextMeshPro bile�eninde nesnenin ad�n� yazd�r�yoruz
        textComponent.text = $"�arp��ma ger�ekle�ti: {objectName}";

        // Ayr�ca, hata ay�klama konsolunda da yazd�rabilirsiniz
        Debug.Log($"�arp��ma ger�ekle�ti: {objectName}");
    }
}
