using DipTestingExercises;

namespace DipTestingExercisesTests
{
    public class FakeMotorVehicle : MotorVehicle
    {
        public FakeMotorVehicle(IPerson pDriver, int pMax, int pCurrent, int pLitresPerKM) : base(pDriver, pMax, pCurrent, pLitresPerKM) { }
    }
}
