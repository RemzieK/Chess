namespace ChessLogic
{
    public class Direction
    {
        public readonly static Direction Up = new Direction(-1, 0);
        public readonly static Direction Down = new Direction(1, 0);
        public readonly static Direction Right = new Direction(0, 1);
        public readonly static Direction Left = new Direction(0, -1);
        //diagonals
        public readonly static Direction UpRight = Up + Right;
        public readonly static Direction UpLeft = Up + Left;
        public readonly static Direction DownRigth = Down + Right;
        public readonly static Direction DownLeft = Down + Left;

        public int RowDelta { get; }
        public int ColumnDelta { get; }

        public Direction(int rowDelta, int columnDelta)
        {
            RowDelta = rowDelta;
            ColumnDelta = columnDelta;
        }

        public static Direction operator +(Direction a, Direction b)
        {
            return new Direction(a.RowDelta + b.RowDelta, a.ColumnDelta + b.ColumnDelta);
        }
        public static Direction operator *(int scalar, Direction dir)
        {
            return new Direction(scalar * dir.RowDelta, scalar * dir.ColumnDelta);
        }
    }
}
