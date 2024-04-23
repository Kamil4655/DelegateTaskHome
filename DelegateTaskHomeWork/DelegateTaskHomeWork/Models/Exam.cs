using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTaskHomeWork.Models
{
    internal class Exam
    {
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }



        private int _examDuration;

        public int ExamDuration
        {
            get { return _examDuration; }
            set { _examDuration = value; }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public Exam(int examduraxtion,string subject,DateTime start)
        {
            _examDuration = examduraxtion;
            _subject = subject;
            StartDate = start;
            EndDate = start.AddMinutes(examduraxtion);
        }


        public void Start()
        {
            StartDate = DateTime.Now;
        }


    }
}

