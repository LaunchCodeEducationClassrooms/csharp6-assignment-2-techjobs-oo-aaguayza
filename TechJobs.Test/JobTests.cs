
namespace TechJobs.Tests
{
    [TestClass]
    public class JobTests
    {
        Job job1;
        Job job2;
        Job job3;
        Job job4;
        Job job5;
        string testString;
        //Testing Objects
        //initalize your testing objects here
        [TestInitialize]
        public void Testjobs()
        {
            job1 = new Job();

            job2 = new Job();

            job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            job5 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));
           
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsFalse(job1.Id == job2.Id);
            Assert.IsTrue(job2.Id - job1.Id == 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual("Product tester", job3.Name);
            Assert.AreEqual("ACME", job3.EmployerName.Value);
            Assert.AreEqual("Desert", job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job3.JobType.Value);
            Assert.AreEqual("Persistence", job3.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestToStringStartsAndEndsWithNewLine()
        {
            string testString = job3.ToString();
            //\r\n for new line
            Assert.IsTrue(testString.StartsWith("\n"));
            Assert.IsTrue(testString.EndsWith("\n"));
        }

        [TestMethod]
        public void TestToStringContainsCorrectLabelsAndData()
        {
            string testString = job4.ToString();
            Assert.AreEqual($"\nID: {job4.Id}\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", testString);
        }

        [TestMethod]
        public void TestToStringHandlesEmptyField()
        {
            string testString = job5.ToString();
            Assert.AreEqual($"\nID: {job5.Id}\nName: Data not available\nEmployer: Data not available\nLocation: Data not available\nPosition Type: Data not available\nCore Competency: Data not available\n", testString);
        }
    }
}

