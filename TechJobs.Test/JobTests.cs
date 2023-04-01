using TechJobsOOAutoGraded6;
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

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith($"{Environment.NewLine}"));
            Assert.IsTrue(job3.ToString().EndsWith($"{Environment.NewLine}"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string testStrJob4 = $"{Environment.NewLine}" +
                $"ID: {job4.Id}{Environment.NewLine}" +
                $"Name: Product tester{Environment.NewLine}" +
                $"Employer: ACME{Environment.NewLine}" +
                $"Location: Desert{Environment.NewLine}" +
                $"Position Type: Quality control{Environment.NewLine}" +
                $"Core Competency: Persistence{Environment.NewLine}";
            Assert.AreEqual(testStrJob4, job4.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            job3.Name = "";
            job3.EmployerName.Value = "";
            job3.EmployerLocation.Value = null;
            job3.JobType.Value = "";
            job3.JobCoreCompetency.Value = null;

            string testStrJob3 = $"{Environment.NewLine}" +
                $"ID: {job3.Id}{Environment.NewLine}" +
                $"Name: Data not available{Environment.NewLine}" +
                $"Employer: Data not available{Environment.NewLine}" +
                $"Location: Data not available{Environment.NewLine}" +
                $"Position Type: Data not available{Environment.NewLine}" +
                $"Core Competency: Data not available{Environment.NewLine}";
            Assert.AreEqual(testStrJob3, job3.ToString());
        }

    }
}

