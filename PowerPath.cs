namespace lab_1;

public class PowerPath(double force, double distance) : IRouteSegment
{
    public SegmentResult Pass(Train train)
    {
        train.ApplyForce(force);
        return train.CalculateTravelTime(distance);
    }
}