using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KC_20_Gimalova_course_work
{
    internal class DataBank
    {
        public static string filePath;
        public static string testFilePath;
        //текущая дата для БД
        public static DateTime date = DateTime.Now;
        //кол-во правильных ответов
        public static int correctAnswer;
    }
}
