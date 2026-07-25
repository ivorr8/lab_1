namespace lab_1;

public class OrdinaryPath(double distance) : IRouteSegment
{
    public SegmentResult Pass(Train train)
    { 
        return train.CalculateTravelTime(distance);
    }
}