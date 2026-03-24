using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; //วัตถุที่กล้องจะหมุนรอบ
    public float distance = 6f; //ระยะห่างของกล้องจากเป้าหมาย
    public float rotationSpeed = 3f; //ความเร็วในการหมุน

    private float mouseX;  
    private float mouseY;  

    void LateUpdate() 
    {
        if (target == null) return;

        mouseX += Input.GetAxis("Mouse X") * rotationSpeed; 
        mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed; 
        //รับค่าขยับเมาส์ เพื่อหมุนซ้าย-ขวา และขึ้น-ลง

        mouseY = Mathf.Clamp(mouseY, 10f, 60f);
        //จำกัดมุมหมุนในแนวตั้ง เพื่อป้องกันกล้องหมุนเกินไป

        Quaternion rotation = Quaternion.Euler(mouseY, mouseX, 0); 
        Vector3 position = target.position - (rotation * Vector3.forward * distance);
        //คำนวณการหมุน และตำแหน่งของกล้องโดยให้กล้องอยู่รอบตัวละครตามระยะที่กำหนด

        transform.position = position; 
        transform.LookAt(target.position);
        //ทำให้กล้องมองไปที่ตัวละครตลอดเวลา
    }
}