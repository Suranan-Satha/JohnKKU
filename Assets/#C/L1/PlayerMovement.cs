using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; //ใช้กำหนดความเร็วในการเคลื่อนที่
    private Rigidbody rb; //ควบคุมฟิสิกส์ของตัวละคร

    void Start()
    {
        rb = GetComponent<Rigidbody>(); //ดึงมาใช้
    }

    void Update() //รับค่าจากคีย์บอร์ด
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); //ฮอริซอลทัล อ่านค่าแกน X จาก keyboard a /d
        float moveVertical = Input.GetAxis("Vertical"); // เวอร์ทิคัล อ่านค่าแกน Z จาก keyboard w /s

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //กำหนดทิศทางการเคลื่อนที่
        rb.AddForce(movement * speed); //เพิ่มแรงให้ตัวละครตามทิศทาง และ ความเร็วที่กำหนด


    }



}