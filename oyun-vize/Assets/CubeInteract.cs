using UnityEngine;
using TMPro;

public class CollisionLogger : MonoBehaviour
{
    // TextMeshPro metin bileþeni
    public TextMeshProUGUI textComponent; // Inspector'dan TextMeshPro nesnesini atayýn

    private void OnTriggerEnter(Collider other)
    {
        // Çarpýþmanýn diðer nesnesinin adýný alýyoruz
        string objectName = other.name;

        // TextMeshPro bileþeninde nesnenin adýný yazdýrýyoruz
        textComponent.text = $"Çarpýþma gerçekleþti: {objectName}";

        // Ayrýca, hata ayýklama konsolunda da yazdýrabilirsiniz
        Debug.Log($"Çarpýþma gerçekleþti: {objectName}");
    }
}
