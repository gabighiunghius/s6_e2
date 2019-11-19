using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema6._2
{


//    Problem 1. Student class
//Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.Use an enumeration for the specialties, universities and faculties.
//Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators ==and !=.
    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, string adress, string email, int phone, string course, int sSN, string university, string faculty, string speciality)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Adress = adress;
            Email = email;
            Phone = phone;
            Course = course;
            SSN = sSN;
            University = university;
            Faculty = faculty;
            Speciality = speciality;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int SSN { get; set; }
        public string Adress { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Speciality { get; set; }
        public string University { get; set; }
        public string Faculty { get; set; }
        
        public enum Universities
        {
            Cuza, Asachi

        }
        public enum Faculties
        {
            FEAA, Biology, Automatics
        }
        public enum Specialities
        {
            Economy, Management, CTI
          
        }

        public override bool Equals(object param)
        {
            Student student = param as Student;
           
            if (student == null)
                return false;
            
            if (!Object.Equals(this.FirstName, student.FirstName))
                return false;
            
            if (this.MiddleName != student.MiddleName)
                return false;
            return true;
        }

        public override string ToString()
        {
            return "Student: " + FirstName + " " + MiddleName+ " " + LastName;
        }

        public static bool operator ==(Student student1,
                                  Student student2)
        {
            return Student.Equals(student1, student2);
        }
        public static bool operator !=(Student student1,
                              Student student2)
        {
            return !(Student.Equals(student1, student2));
        }
     



        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ MiddleName.GetHashCode();
        }

//        Problem 2. ICloneable
//Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
        public object Clone()
        {
            Student oldStud = this;
            Student newStud = new Student(oldStud.FirstName, oldStud.MiddleName, oldStud.LastName,
                oldStud.Adress, oldStud.Email, oldStud.Phone, oldStud.Course,
                oldStud.SSN, oldStud.University, oldStud.Faculty, oldStud.Speciality);
            return newStud;
        }

        //        Problem 3. IComparable
        //Implement the IComparable<Student> interface to compare students by names(as first criteria, in lexicographic order) 
        //            and by social security number(as second criteria, in increasing order).

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                int myOutput = 0;

                myOutput = string.Compare(this.FirstName, otherStudent.FirstName);
                
                return myOutput;
            }
            if (this.SSN != otherStudent.SSN)
            {
                return (this.SSN - otherStudent.SSN);
            }
            return 0;
        }



    }
}

