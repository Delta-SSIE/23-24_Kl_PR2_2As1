class Vector2D
{
    public int X { get; set; }
    public int Y { get; set; }

    public Vector2D(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Vector2D operator +(Vector2D point1, Vector2D point2)
    {
        return new Vector2D(point1.X + point2.X, point1.Y + point2.Y);
    }
    public static bool operator ==(Vector2D point1, Vector2D point2)
    {
        return point1.X == point2.X && point1.Y == point2.Y;
    }
    public static bool operator !=(Vector2D point1, Vector2D point2)
    {
        return !(point1 == point2);
    }

}