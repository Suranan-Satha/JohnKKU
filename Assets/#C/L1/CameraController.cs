using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //กำหนดว่าจะหมุนรอบ อะไร
    public float distance = 6f; //ระยะห่างจากเป้าหมาย
    public float rotationSpeed = 3f; //ความเร็วในการหมุน

    private float mouseX;   //เก็บค่าการหมุนในแนวนอน
    private float mouseY;   //เก็บค่าการหมุนในแนวตั้ง

    void LateUpdate() 
    {
        if (target == null) return; //ถ้าไม่มีเป้าหมายให้หมุนรอบ ให้หยุดทำงาน

        mouseX += Input.GetAxis("Mouse X") * rotationSpeed; //เพิ่มค่าการหมุนในแนวนอนตามการเคลื่อนไหวของเมาส์
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed; //เพิ่มค่าการหมุนในแนวตั้งตามการเคลื่อนไหวของเมาส์ (ลบเพราะต้องการให้หมุนขึ้นเมื่อเมาส์เคลื่อนขึ้น)

        mouseY = Mathf.Clamp(mouseY, 10f, 60f); //จำกัดมุมหมุนในแนวตั้งเพื่อป้องกันการหมุนเกินไป
         
        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0); //สร้างการหมุนจากค่าที่ได้จากเมาส์
        Vector3 position = target.position - (rotation * Vector3.forward * distance); //คำนวณตำแหน่งของกล้องโดยการหมุนเวกเตอร์ไปข้างหน้าและคูณด้วยระยะห่างจากเป้าหมาย

        transform.position = position; //อัพเดตตำแหน่งของกล้อง
        transform.LookAt(target.position); //ทำให้กล้องมองไปที่เป้าหมาย
    }
}