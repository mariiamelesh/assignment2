namespace Kse.Algorithms.Assignment2 {
	public class Program {
		static void Main(string[] args) {
			var optionsToGenerate = new MapGeneratorOptions()
			{
				Height = 10,
				Width = 100,
			};
			var generator = new MapGenerator(optionsToGenerate);
			string[,]? map = generator.Generate();
			new MapPrinter().Print(map);
		}
	}
}
