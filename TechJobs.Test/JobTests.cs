
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
            Assert.IsFalse(job1.Id == job2.Id);
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
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            Assert.IsTrue(job3.ToString().StartsWith(Environment.NewLine));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string expected = $"{Environment.NewLine}ID: {job3.Id}" +
                $"{Environment.NewLine}Name: Product tester" +
                $"{Environment.NewLine}Employer: ACME" +
                $"{Environment.NewLine}Location: Desert" +
                $"{Environment.NewLine}Position Type: Quality control" +
                $"{Environment.NewLine}Core Competency: Persistence" +
                $"{Environment.NewLine}";

            Assert.AreEqual(expected, job3.ToString());
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            job4.Name = "";
            job4.EmployerName.Value = null;
            job4.EmployerLocation.Value = "";
            job4.JobType.Value = null;
            job4.JobCoreCompetency.Value = "";

            string expected = $"{Environment.NewLine}ID: {job4.Id}" +
                $"{Environment.NewLine}Name: “Data not available”" +
                $"{Environment.NewLine}Employer: “Data not available”" +
                $"{Environment.NewLine}Location: “Data not available”" +
                $"{Environment.NewLine}Position Type: “Data not available”" +
                $"{Environment.NewLine}Core Competency: “Data not available”" +
                $"{Environment.NewLine}";

            Assert.AreEqual(expected, job4.ToString());
        }

    }
}

