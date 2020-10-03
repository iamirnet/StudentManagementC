using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagement.Bit;
using StudentManagement.Bit.Student;

namespace StudentManagement
{
    class Controller
    {
        public void ShowList(List<MainStudent> students, int action = 0)
        {
            Menu menu = new Menu();
            if(action != 1)
                foreach (MainStudent st in students.OrderBy(p => p.Number))
                {
                    Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                        st.Number, st.Name, st.Study, st.Level, st.Lessons.Count, st.Scores, st.Average);
                }
            switch (action)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Clear();
                        Sort(students);
                        break;
                    case 2:
                        Add(students);
                        break;
                    case 3:
						Console.WriteLine("Please Enter Student ID:");
						UInt64 id = UInt64.Parse(Console.ReadLine());
						MainStudent student = students.Find(x => x.Number == id);
                        Edit(students, student);
                        break;
                    case 4:
                        Delete(students);
                        break;
                    case 5:
                        Console.Clear();
                        Show(students);
                        break;
                    default:
                        Console.WriteLine("\n!!!please choose from the items!!!");
                        Console.ReadKey();
                        break;
                }
                menu.Student();
                action = int.Parse(Console.ReadLine());
                Console.Clear();
                ShowList(students, action);

        }
		
        public void Sort(List<MainStudent> students, int sort = 1)
        {
            Menu menu = new Menu();
            
                switch (sort)
                {
                    case 1:
                        foreach (MainStudent student in students.OrderBy(p => p.Number))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    case 2:
                        foreach (MainStudent student in students.OrderBy(p => p.Name))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    case 3:
                        foreach (MainStudent student in students.OrderBy(p => p.Study))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    case 4:
                        foreach (MainStudent student in students.OrderBy(p => p.Level))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    case 5:
                        foreach (MainStudent student in students.OrderBy(p => p.Scores))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    case 6:
                        foreach (MainStudent student in students.OrderBy(p => p.Average))
                        {
                            Console.WriteLine("ID : {0} | FullName : {1} | Study : {2} | Level : {3} | Lessons : {4} | Scores : {5} | Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
                        }
                        break;
                    default:
                        Console.WriteLine("\n!!!please choose from the items!!!");
                        Console.ReadKey();
                        break;
                }
                menu.Sort();
                sort = int.Parse(Console.ReadLine());
                Console.Clear();
                Sort(students, sort);

        }
		
        public void Show(List<MainStudent> students)
        {
            Console.WriteLine("Please Enter Student ID:");
            UInt64 id = UInt64.Parse(Console.ReadLine());
            MainStudent student = students.Find(x => x.Number == id);
            Console.WriteLine("Student Info:\n ID : {0} \n FullName : {1} \n Study : {2} \n Level : {3} \n Lessons : {4} \n Scores : {5} \n Average : {6}",
                                student.Number, student.Name, student.Study, student.Level, student.Lessons.Count, student.Scores, student.Average);
            Console.WriteLine("Student Lessons:");
            foreach (Lesson lesson in student.Lessons)
            {
                Console.WriteLine(" Name : {0} | Code : {1} | Unit : {2} | Score : {3}",
                                lesson.Name, lesson.Code, lesson.Unit, lesson.Score);
            }

        }
		
        public void Delete(List<MainStudent> students)
        {
            Console.WriteLine("Please Enter Student ID:");
            UInt64 id = UInt64.Parse(Console.ReadLine());
            var delst = students.Find(p => p.Number == id);
			students.Remove(delst);
            Console.WriteLine("Student Removed");
			Console.ReadKey();
        }
		
		public void Add(List<MainStudent> students)
        {
			MainStudent student = new MainStudent();
            Console.WriteLine("Please Enter Student ID:");
            student.Number = UInt64.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Student Full Name:");
            student.Name = Console.ReadLine();
            Console.WriteLine("Please Enter Student Study:");
            student.Study = Console.ReadLine();
            Console.WriteLine("Please Enter Student Level:");
            student.Level = Console.ReadLine();
			students.Add(student);
            Console.WriteLine("Student Added");
			Console.ReadKey();
        }

        public void Edit(List<MainStudent> students, MainStudent student, int order = 0)
        {
            Menu menu = new Menu();
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Please Enter Student ID:");
                    student.Number = UInt64.Parse(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Please Enter Student Full Name:");
                    student.Name = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Please Enter Student Study:");
                    student.Study = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Please Enter Student Level:");
                    student.Level = Console.ReadLine();
                    break;
                case 5:
                    Lessons(students, student);
                    break;
                default:
                    Console.WriteLine("\n!!!please choose from the items!!!");
                    Console.ReadKey();
                    break;
            }
            menu.EditStudent();
            order = int.Parse(Console.ReadLine());
            Console.Clear();
            Edit(students, student, order);
        }
        public void Lessons(List<MainStudent> students, MainStudent student, int order = 0)
        {
            Menu menu = new Menu();
            foreach (Lesson lesson in student.Lessons)
            {
                Console.WriteLine(" Name : {0} | Code : {1} | Unit : {2} | Score : {3}",
                                lesson.Name, lesson.Code, lesson.Unit, lesson.Score);
            }
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    AddLesson(student.Lessons);
                    break;
                case 2:
                    Console.WriteLine("Please Enter Lesson Code:");
                    int code = int.Parse(Console.ReadLine());
                    Lesson lesson = student.Lessons.Find(x => x.Code == code);
                    EditLesson(student.Lessons, lesson);
                    break;
                default:
                    Console.WriteLine("\n!!!please choose from the items!!!");
                    Console.ReadKey();
                    break;
            }
            menu.Lessons();
            order = int.Parse(Console.ReadLine());
            Console.Clear();
            Lessons(students, student, order);
        }

        private void EditLesson(List<Lesson> lessons, Lesson lesson, int order = 0)
        {
            Menu menu = new Menu();
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Please Enter Lesson Name:");
                    lesson.Name = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Please Enter Lesson Code:");
                    lesson.Code = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Please Enter Lesson Unit:");
                    lesson.Unit = int.Parse(Console.ReadLine());
                    break;
                case 4:
                    score:  Console.WriteLine("Please Enter Lesson Score:");
                    int score = int.Parse(Console.ReadLine());
                    if (score < 0 || score > 20)
                        goto score;
                    else
                        lesson.Score = score;
                    break;
                default:
                    Console.WriteLine("\n!!!please choose from the items!!!");
                    Console.ReadKey();
                    break;
            }
            menu.EditLesson();
            order = int.Parse(Console.ReadLine());
            Console.Clear();
            EditLesson(lessons, lesson, order);
        }

        private void AddLesson(List<Lesson> lessons)
        {
            Lesson lesson = new Lesson();
            Console.WriteLine("Please Enter Lesson Name:");
            lesson.Name = Console.ReadLine();
            Console.WriteLine("Please Enter Lesson Code:");
            lesson.Code = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Lesson Unit:");
            lesson.Code = int.Parse(Console.ReadLine());
            score2: Console.WriteLine("Please Enter Lesson Score:");
            int score = int.Parse(Console.ReadLine());
            if (score < 0 || score > 20)
                goto score2;
            else
                lesson.Score = score;
            lessons.Add(lesson);
            Console.WriteLine("Lesson Added");
            Console.ReadKey();
        }

        public void Average(List<MainStudent> students, int order = 0)
        {
            int count = 0, avarge = 0;
            Menu menu = new Menu();
            switch (order)
            {
                case 0:
                    break;
                case 1:
                    foreach (MainStudent student in students)
                    {
                        count++;
                        avarge += student.Average;
                    }
                    break;
                case 2:
                    menu.Study();
                    order = int.Parse(Console.ReadLine());
                    foreach (MainStudent student in students)
                    {
                        if(student.Study == "Computer")
                        {
                            count++;
                            avarge += student.Average;
                        }
                    }
                    break;
                case 3:
                    menu.Level();
                    order = int.Parse(Console.ReadLine());
                    foreach (MainStudent student in students)
                    {
                        if (student.Level == "Bachelor" && order == 1)
                        {
                            count++;
                            avarge += student.Average;
                        }
                        else if (student.Level == "Masters" && order == 2)
                        {
                            count++;
                            avarge += student.Average;
                        }
                        else if (student.Level == "Doctorate" && order == 3)
                        {
                            count++;
                            avarge += student.Average;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("\n!!!please choose from the items!!!");
                    Console.ReadKey();
                    break;
            }
            if(order > 0)
            {
                avarge = avarge / count;
                Console.WriteLine("Count: {0} | Average: {1}", count, avarge);
                Console.ReadKey();
                Console.Clear();
            }
            menu.Average();
            order = int.Parse(Console.ReadLine());
            Console.Clear();
            Average(students, order);

        }

    }
}
