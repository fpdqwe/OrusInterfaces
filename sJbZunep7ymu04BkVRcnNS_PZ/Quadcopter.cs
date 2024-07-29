using sJbZunep7ymu04BkVRcnNS_PZ.Interfaces;

namespace sJbZunep7ymu04BkVRcnNS_PZ
{
	public class Quadcopter : IFlyingRobot, IChargeable
	{
		//Default quadcopter components
		private static readonly List<string> _components = new List<string> {"rotor1","rotor2","rotor3","rotor4"};
		public void Charge()
		{
			Console.WriteLine("Charging...");
			Thread.Sleep(3000);
			Console.WriteLine("Charged!");
		}

		public List<string> GetComponents()
		{
			return _components;
		}

		public string GetInfo()
		{
			throw new NotImplementedException();
		}

		public string GetRobotType()
		{
			return "Robot type is quadcopter";
		}
	}
}
