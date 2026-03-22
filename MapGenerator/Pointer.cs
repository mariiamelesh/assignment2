namespace Kse.Algorithms.Assignment2
{
    public struct Point
    {
        public int Column { get; }
        public int Row { get; }

        public Point(int column, int row)
        {
            Column = column;
            Row = row;
        }
		
		public static bool operator ==(Point point1, Point point2) 
		{
			return point1.Column == point2.Column && point1.Row == point2.Row;
		}

		public static bool operator !=(Point point1, Point point2) 
		{
			return !(point1 == point2);
		}
    }
}