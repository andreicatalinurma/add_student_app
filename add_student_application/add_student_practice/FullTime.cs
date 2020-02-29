using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_ass
{
    /**************************************************************************************************
    *full time class which contains the details for full time employee
    * base class
    * ************************************************************************************************/
    class FullTime
    {
        protected string emName;
        protected string emCourse;
        protected int emClassRoom;
        public FullTime()
        {
            emName = "";
            emCourse = "";
            emClassRoom = 0;
        }
        public FullTime(string emName, string emCourse, int emClassRoom)
        {
            this.emName = emName;
            this.emCourse = emCourse;
            this.emClassRoom = emClassRoom;
        }

        protected void setName(String name)
        {
            emName = name;
        }

        protected void setCourse(String Course)
        {
            emCourse = Course;
        }
        protected void setClassRoom(int ClassRoom)
        {
            emClassRoom = ClassRoom;
        }

        public virtual void printF_T_TeachearInfo()
        {
            Console.WriteLine("\n\tName: {0}\n\tCourse: {1}\n\tClassRoom: {2}", emName, emCourse, emClassRoom);
        }

        public virtual void GetInfo()
        {
            Console.Write("\n\tTime Table: ");
            Console.WriteLine("\tMonday to Friday from 09:00 till 18:00");
        }
    }
}
