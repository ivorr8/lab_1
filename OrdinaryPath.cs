namespace lab_1;

public class OrdinaryPath(double distance) : IRouteSegment
{
    public SegmentResult Pass(Train train)
    {
        var time = train.CalculateTravelTime(distance);
        return new SegmentResult(true,  time);
    }
}