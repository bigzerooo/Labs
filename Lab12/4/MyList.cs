using System;
using System.Collections.Generic;
using System.Text;

namespace _4
{
    class MyList//subscriber
    {
        List<Job> jobs;
        public void Add(Job job)
        {
            jobs.Add(job);
            job.Delete += Remove;//Обработка события
        }
        public void Remove(Job job)
        {
            jobs.Remove(job);
        }   
        public void PassWeek()
        {
            for (int i = 0; i < jobs.Count; i++)
                jobs[i].Update();
        }
        public void Status()
        {
            for (int i = 0; i < jobs.Count; i++)
                jobs[i].Info();
        }
        public MyList()
        {
            jobs = new List<Job>();
        }

    }
}
