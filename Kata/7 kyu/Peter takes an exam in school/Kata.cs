// Peter takes an exam in school
// https://www.codewars.com/kata/564b0f24c685f1befa000081

namespace codewars.com.Kata._8_kyu.Peter_takes_an_exam_in_school
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public string Name { get; set; }
        public double Grade { get; set; }
    }

    public class Kata
    {
        public static List<string> PassedStudentList(List<Student> gradeList, int acceptanceGrade)
        {
            var passed = gradeList.Where(v => v.Grade >= acceptanceGrade);
            var res = passed.Select(v => v.Name).ToList();
            res.Sort();
            return res;
        }
    }
}