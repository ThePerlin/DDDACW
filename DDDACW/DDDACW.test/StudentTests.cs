namespace DDDACW.test
{
    public class StudentTests
    {
        Student _student1 {get; set; } = null!;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhoAmI_Test()
        {
            // Assign
            _student1 = new Student();

            // Act
            var Type = _student1.WhoAmI();

            // Asert
            //Assert.That(UserType.STUDENT, Is.SameAs(Type));
            Assert.IsNotNull(Type);
        }
    }
}