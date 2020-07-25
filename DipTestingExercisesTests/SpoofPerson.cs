using DipTestingExercises;

namespace DipTestingExercisesTests
{
    public class SpoofPerson : IPerson
    {
        public string name;

        public SpoofPerson() {
            name = "FakeName";
        }

        public SpoofPerson(string _name)
        {
            name = _name;
        }

        public string getGender()
        {
            return "FakeGender";
        }

        public string getName()
        {
            return name;
        }
    }
}
