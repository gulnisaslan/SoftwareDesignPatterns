using System;
using System.Collections.Generic;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediator = new Mediator();
            Teacher teacher = new Teacher(mediator);
            teacher.TeacherName="Engin";
            mediator.Teacher=teacher;
            
            Student student = new Student(mediator);
            student.Name="Derin";
            
            Student student1 = new Student(mediator);
            student1.Name="Salih";

          

            

        }
    }
    abstract class CourseMember
    {
        
         protected Mediator Mediator;
         public CourseMember(Mediator mediator){
             Mediator=mediator;
         }
        
    }
     class Teacher : CourseMember
     {
         public string TeacherName { get; set; }
          public Teacher(Mediator mediator) : base(mediator)
          {
          }

          public void RecieveQuestion(string question, Student student)
          {
              Console.WriteLine($"Teacher recieved a question from {student.Name},{question}");
          }
          public void SendNewImage(string url){
              Console.WriteLine($"Teacher changed slide : {url}");
              Mediator.UpdateImage(url);

          }
          public void AnswerQuestion(string answer ,Student student){
              Console.WriteLine($"Teacher answered question {student.Name}, {answer}");
          }
     }
     class Student : CourseMember
     {
          public Student(Mediator mediator) : base(mediator)
          {
          }

          public string Name { get; set; }

          public void RecieveImage(string url)
          {
              Console.WriteLine($"Student received image : {url}");
          }

          public void RecieveAnswer(string answer)
          {
               Console.WriteLine($"Student received answer {answer}");
          }
     }
     class Mediator
    {
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } 
        public void UpdateImage(string url){
            foreach(var student in Students){
                student.RecieveImage(url);
            }
        }
        public void SendQuestion(string question,Student student)
        {
            Teacher.RecieveQuestion(question,student);
        }
          public void SendAnswer(string answer,Student student )
        {
            
            student.RecieveAnswer(answer);
        }
        
        

    }
}
