using System;
using System.Numerics;
using System.Xml.Linq;

namespace TechJobsOOAutoGraded6
{
    public class RunTechJobs
    {
        public void RunProgram()
        {
            // TODO: Task 4: Remove this line to uncomment the RunProgram method once you complete the Job class

                Job job1 = Samples.job1;
                Job job2 = Samples.job2;
                Job job3 = Samples.job3;

                List<Job> jobs = new List<Job>();
                    jobs.Add(job1);
                    jobs.Add(job2);
                    jobs.Add(job3);

                foreach (Job job in jobs)
                {
                    Console.WriteLine(job);
                }

            // TODO: Task 4: Remove this line to uncomment the RunProgram method once you complete the Job class */

        }
    }
}

