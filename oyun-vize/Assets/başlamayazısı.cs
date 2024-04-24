using UnityEngine;
using TMPro; // TextMeshPro kullanmak için bu satırı ekleyin
using System.Collections;

public class HideTextAfterDelay : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro; // TextMeshPro bileşenini bağlayacağınız alan
    public float delayInSeconds = 5f; // Gecikme süresi

    // Başlangıçta Coroutine başlatıyoruz
    void Start()
    {
        StartCoroutine(HideTextCoroutine());
    }

    // Coroutine ile belirlenen süre sonra metni temizliyoruz
    IEnumerator HideTextCoroutine()
    {
        // Belirtilen süre kadar bekle
        yield return new WaitForSeconds(delayInSeconds);

        // TextMeshPro bileşeninin metnini boş yap
        if (textMeshPro != null)
        {
            textMeshPro.text = string.Empty; // Metni temizle
        }
    }
}
