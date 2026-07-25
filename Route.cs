namespace lab_1;

public class Route(IReadOnlyList<IRouteSegment> segments, double maxSped)
{
    private IReadOnlyList<IRouteSegment>  _segments = segments;
    private double _maxSped = maxSped;
    public void Simulate(Train train)
    {
        double time = 0;
        foreach (IRouteSegment segment in _segments)
        {
            var segres = segment.Pass(train);
            if (segres._result == false)
            {
                Console.WriteLine("no");
                break;
            }
            time += segres._time;
        }

        if (_maxSped > train.Speed)
        {
            Console.WriteLine("no");
        }
    }
    
}