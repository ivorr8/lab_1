namespace lab_1;

public class PowerPath(int force, double distance) : IRouteSegment
{
    public SegmentResult Pass(Train train)
    {
        train.ApplyForce(force);
        return new SegmentResult(true, train.CalculateTravelTime(distance));
    }
}