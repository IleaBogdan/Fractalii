internal class KochItem
{
    public Point BeginPoint { get; set; }
    public Point EndPoint { get; set; }
    public int Level { get; set; }

    public KochItem(Point begin, Point end, int level)
    {
        BeginPoint = begin;
        EndPoint = end;
        Level = level;
    }

    public static KochItem operator ++(KochItem item)
    {
        return new KochItem(item.BeginPoint, item.EndPoint, item.Level + 1);
    }
}