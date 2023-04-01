﻿using TechJobsOOAutoGraded6;
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        //Testing Objects
        //initalize your testing objects here
        Job job1;
        Job job2;
        Job job3;
        Job job4;

        [TestInitialize]
        public void Init()
        {
            job1 = new Job();
            job2 = new Job();
            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Console.WriteLine(job1.Id);
            Console.WriteLine(job2.Id);
            Console.WriteLine(job3.Id);
            Console.WriteLine(job4.Id);
            Assert.AreNotEqual(job1.Id, job2.Id);
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.ToString());
            Assert.AreEqual("Desert", job3.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", job3.JobType.ToString());
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.AreNotEqual(job3, job4);
        }

    }
}

