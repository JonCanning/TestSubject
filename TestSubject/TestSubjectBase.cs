
namespace TestSubject
{
    public abstract class TestSubjectBase<T> where T : class
    {
        protected readonly TestSubject<T> TestSubject;

        protected TestSubjectBase()
        {
            TestSubject = new TestSubject<T>();
        }
    }
}
