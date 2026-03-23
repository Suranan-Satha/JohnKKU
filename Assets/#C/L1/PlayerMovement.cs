using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {

        float moveHorizontal = Input.GetAxis("Horizontal"); //อ่านค่าแกน X จาก keyboard a /d
        float moveVertical = Input.GetAxis("Vertical"); // อ่านค่าแกน Z จาก keyboard w /s

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //สร้าง เวกเตอร์ทิศทาง 3 มิติ X = ซ้าย/ขวา Y = 0(ไม่ขึ้น / ลง) Z = หน้า / หลัง
        rb.AddForce(movement * speed); //เพิ่มแรงให้ตัวละครตามทิศทาง × ความเร็ว


    }



}