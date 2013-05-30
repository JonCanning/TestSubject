namespace TestSubject
{
    public class TestSubject<T> where T : class
    {
        readonly NSubstituteAutoMocker<T> autoMocker;

        public TestSubject()
        {
            autoMocker = new NSubstituteAutoMocker<T>();
        }

        public T ClassUnderTest
        {
            get
            {
                return autoMocker.ClassUnderTest;
            }
        }

        public TDependency Get<TDependency>() where TDependency : class
        {
            return autoMocker.Get<TDependency>();
        }

        public void Inject<TDependency>(TDependency obj)
        {
            autoMocker.Inject(obj);
        }
    }
}