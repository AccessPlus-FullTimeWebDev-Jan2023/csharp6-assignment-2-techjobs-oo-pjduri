using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechJobsOOAutoGraded6
{
    public abstract class Samples
    {
        // TODO: Task 2 uncomment the code block below to test task 2
        //sample Locations for TestTask2 tests 2 and 3
        public static Location testLocation1 = new Location("Desert");
        public static Location testLocation2 = new Location("Desert");

        //sample Core Competencies for TestTask2 test 4
        public static CoreCompetency testComp1 = new CoreCompetency("Persistence");
        public static CoreCompetency testComp2 = new CoreCompetency("Persistence");

        //sample Position Types for TestTask2 tests 6 and 7
        public static PositionType testPosition1 = new PositionType("Quality Control");
        public static PositionType testPosition2 = new PositionType("Quality Control");
        // TODO: Task 2 uncomment the code block above to test task 2


        // TODO: Task 3 uncomment the code block below to test task 3
        public static Job testJob1 = new Job();
        public static Job testJob2 = new Job();
        public static Job testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        public static Job testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        // TODO: Task 3 uncomment the code block above to test task 3

        //TODO: Task 4 uncomment the code block below to test task 4
        public static Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        public static Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
        public static Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
        //TODO: Task 4 uncomment the code block above to test task 4
    }
}
