using sJbZunep7ymu04BkVRcnNS_PZ.Interfaces;

namespace sJbZunep7ymu04BkVRcnNS_PZ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var copter = new Quadcopter();
			Console.WriteLine("Quadcopter components" + copter.GetComponents());
			copter.Charge();
			Console.WriteLine(copter.GetRobotType());
			Console.WriteLine(copter.GetInfo());
		}
	}
}
