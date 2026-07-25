namespace lab_1;

public class Station(double time, double maxSped) : IRouteSegment
{
    private readonly double _maxSped = maxSped;

    public SegmentResult Pass(Train train)
    {
        if (_maxSped < train.GetSpeed())
        {
            return new SegmentResult(false, 0);
        }

        double localSpeed = train.GetSpeed();
        train.Stop();
        train.SetSpeed(localSpeed);
        return new SegmentResult(true, time);
    }
}