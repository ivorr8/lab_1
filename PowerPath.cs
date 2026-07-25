namespace lab_1;

public class PowerPath(double force, double distance) : IRouteSegment
{
    public SegmentResult Pass(Train train)
    {
       var result =  train.ApplyForce(force);
       return !result.Result ? new SegmentResult(false, 0) : train.CalculateTravelTime(distance);
    }
}