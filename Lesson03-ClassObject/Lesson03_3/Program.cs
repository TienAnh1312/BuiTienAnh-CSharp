﻿namespace Lesson03_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo đối tượng
            StudentModel action = new StudentModel();
            //gọi phương thức lấy các sinh viên 
            List<Student> listall = action.GetStudents();
            //hiển thị
            foreach (Student item in listall)
            {
                item.Display();
            }
            // gọi phiowng thức lấy sinh viên theo Id
            Student st = action.GetStudents(2);
            //hiên thị 
            st.Display();
            //gọi phương thức lấy sinh viên  có tuổi từ 25- 30
            List<Student> listage = action.GetStudents(25, 30);
            //hiển thị
            foreach (var item in listage)
            {
                item.Display();
            }
        }
    }
}
