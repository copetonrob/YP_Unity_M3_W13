using UnityEngine;
using UnityEngine.UI;

public class UltimateHex : MonoBehaviour
{
    //Ссылка на префаб эффекта
    public GameObject HexEffectPrefab;
    //Ссылка на префаб утки
    public GameObject Duck;
    //Ссылка на иконку способности
    public Image SpellIcon;
    //Время перезарядки
    public float Cooldown = 10f;

    float _timer = 0f;

    void Update()
    {
        //Обновляем таймер и иконку
        _timer += Time.deltaTime;
        UpdateUltimateIcon();

        //Если нажата клавиша способности и таймер больше времени перезарядки
        if (Input.GetKeyDown(KeyCode.???) && _timer >= ???)
        {
            CastHex();
        }
    }
    
    void CastHex()
    {
        //Находим всех врагов
        EnemyHealth[] enemies = FindObjectsOfType<???>();
        //Проходим по всем врагам
        foreach (EnemyHealth enemy in enemies)
        {
            //Уничтожаем врага, создаем на месте врага эффект превращения и утку
            Destroy(???);
            Instantiate(HexEffectPrefab, enemy.transform.position, Quaternion.identity);
            Instantiate(Duck, enemy.transform.position, enemy.transform.rotation);
        }
        //Сбрасываем таймер
        _timer = ???;
    }

    void UpdateUltimateIcon()
    {
        //находим текущий процент времени перезарядки (значение от 0 до 1)
        float fillAmount = _timer / Cooldown;
        //Параметр SpellIcon.fillAmount отвечает за заполнение иконки способности
        SpellIcon.fillAmount = fillAmount;
    }
}
