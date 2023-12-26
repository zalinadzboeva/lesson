using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Lesson
    {
        public string label;
        public int number;
        public int weekNumber;
        public string weekDay;
        public string groupNumber;

        private static int counter = 0;

        public Lesson()
        {
            label = Convert.ToChar('A' + counter).ToString();
            number = new Random().Next(1, 5); 
            weekNumber = new Random().Next(0, 3); 
            weekDay = "понедельник";
            groupNumber = (new Random().Next(11, 14)).ToString(); 

            counter = counter + 1;

            
        }
        public Lesson(string Label, int Number, int WeekNumber, string WeekDay, string GroupNumber)
        {
            label = Label;
            number = Number;
            weekNumber = WeekNumber;
            weekDay = WeekDay;
            groupNumber = GroupNumber;
        }
        public override string ToString()
        {
            string weekNumberString;
            if (weekNumber==0)
            {
                weekNumberString = "каждую неделю";
            }
            else if(weekNumber == 1)
            {
                weekNumberString = " по первой неделе";
            }
            else
            {
                weekNumberString = "по второй неделе";
            }
            return $"{label}, {number} пара {weekDay}, {groupNumber} группа, {weekNumberString}";
        }
    }
    public class Schedule
    {
        private string Name;
        public List<Lesson> listLesson;

        public Schedule(string name)
        {
            Name = name;
            listLesson = new List<Lesson>();
        }
        public void Add(Lesson lesson)
        {
            listLesson.Add(lesson);
        }
        public void ToString()
        {
            string result = "";
            for (int i = 0; i < listLesson.Count; i++)
            {
                result += $"{i + 1}. {listLesson[i].ToString()}\n";
            }
            Console.WriteLine(result) ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lesson lessonA = new Lesson();
            Lesson lessonB = new Lesson();
            Console.WriteLine(lessonA.ToString());
            Console.WriteLine(lessonB.ToString());

            Schedule schedule = new Schedule("Факультет информационных технологий");

            Lesson lessonMatan = new Lesson("Матанализ", 1, 0, "вторник", "21");
            Lesson lessonAlgebra = new Lesson("Алгебра", 2, 1, "вторник", "21");
            Console.WriteLine(lessonMatan.ToString());
            Console.WriteLine(lessonAlgebra.ToString());

            schedule.Add(lessonMatan);
            schedule.Add(lessonAlgebra);

            schedule.ToString();
        }
    }
}
