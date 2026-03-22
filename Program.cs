namespace Kse.Algorithms.Assignment2 {
	public class Program {
		static void Main(string[] args) {
			var optionsToGenerate = new MapGeneratorOptions()
			{
				Height = 10,
				Width = 100,
				Seed = 1,
			};
			
			var point = new Point(0, 0);
			var point1 = new Point(38, 4);
			var point2 = new Point(98, 8);
			var list = new List<Point> {point, point1, point2};
			
			var generator = new MapGenerator(optionsToGenerate);
			string[,]? map = generator.Generate();
			new MapPrinter().Print(map, list);
		}
	}
}
