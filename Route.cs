namespace lab_1;

public class Route(IReadOnlyList<IRouteSegment> segments, double maxSped)
{
    private readonly IReadOnlyList<IRouteSegment>  _segments = segments;
    private readonly double _maxSped = maxSped;
    public RouteResult Simulate(Train train)
    {
        double time = 0;
        foreach (IRouteSegment segment in _segments)
        {
            var segres = segment.Pass(train);
            if (!segres.Result)
            {
                return new RouteResult(false, 0);
            }
            time += segres.Time;
        }

        return _maxSped < train.Speed ? new RouteResult(false, 0) : new RouteResult(true, time);
    }
    
}