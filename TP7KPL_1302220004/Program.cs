// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TP7KPL_1302220004
{

    class Course
    {
        public String kode { get; set; }
        public String nama { get; set; }
    }

    internal class KuliahMahasiswa1302223014
    {
        class CourseData
        {
            public List<Course> courses { get; set; }
        }

        public static void ReadJSON()
        {
            string jsonString = File.ReadAllText("C:\\Users\\fauzan\\Desktop\\KPL\\TP7KPL_1302220004");
            CourseData dataJson = JsonSerializer.Deserialize<CourseData>(jsonString);

            int i = 1;
            foreach (var course in dataJson.courses)
            {
                Console.WriteLine($"MK {i} {course.kode} - {course.nama}");
                i++;
            }
        }
    }
}

