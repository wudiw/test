using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


[System.Serializable]
public class Student
{
    public string name;
    public int age;
    public int score;
}


[System.Serializable]
public class StudentList
{
    //声明一个装学生的表
    public List<Student> list = new List<Student>();
}


public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        Student s1 = new Student();
        Student s2 = new Student();
        StudentList s3 = new StudentList();
        s1.name = "张三";
        s1.age = 18;
        s2.name = "李四";
        s2.age = 22;
        s3.list.Add(s1);
        s3.list.Add(s2);
        //用tojson把s3这个类转换为json文件
        // string json= JsonUtility.ToJson(s3,true);
        //Debug.Log(json);


        string path = @"D:\Desktop\1.txt";
        //读取桌面的json文件
            using (StreamReader sr = new StreamReader(path))
            {
                  string str = sr.ReadToEnd();
                  StudentList s4= JsonUtility.FromJson<StudentList>(str);
            s1 = s4.list[0];
            s2 = s4.list[1];
            print(s2.age);
            }    
          
    }  
}
