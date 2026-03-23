using UnityEngine;
using TMPro;

public class showHP : MonoBehaviour
{
    public string playerTag = "Hero"; //กำหนดแท็กของตัวละครที่ต้องการแสดง HP

    private playerStat playerStat; //ตัวแปรเพื่อเก็บข้อมูลสเตตัสของตัวละคร จาก script playerStat
    private TMP_Text hpText; //ตัวแปรเพื่อเก็บข้อมูลของ TextMeshPro ที่จะแสดง HP

    void Start()
    {
        hpText = GetComponent<TMP_Text>(); //ค้นหา TextMeshPro ที่อยู่บน GameObject เดียวกันกับ script นี้

        GameObject p = GameObject.FindGameObjectWithTag(playerTag); //ค้นหา GameObject ที่มีแท็กที่กำหนดไว้ (ในที่นี้คือ "Hero")
        if (p != null) //ถ้าพบ GameObject ที่มีแท็กนั้น ให้เก็บข้อมูลสเตตัสของตัวละครจาก script playerStat
        {
            playerStat = p.GetComponent<playerStat>();
        }
        else //ถ้าไม่พบ GameObject ที่มีแท็กนั้น ให้แสดงข้อความว่า "Player not found" บน TextMeshPro
        {
            hpText.text = "Player not found";
        }
    }

    void Update() //ในทุกๆ เฟรม ให้ตรวจสอบว่ามีข้อมูลสเตตัสของตัวละครหรือไม่ ถ้ามี ให้แสดง HP ของตัวละครบน TextMeshPro ในรูปแบบ "HP : [ค่า HP]"
    {
        if (playerStat == null) return; //ถ้าไม่มีข้อมูลสเตตัสของตัวละคร ให้หยุดทำงาน

        hpText.text = "HP : " + playerStat.hp.ToString(); //อัพเดตข้อความบน TextMeshPro ให้แสดงค่า HP ของตัวละคร โดยใช้ ToString() เพื่อแปลงค่า HP เป็นข้อความ
    }

}
