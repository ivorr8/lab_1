namespace lab_1;

public class ApplyForceResult(bool result)
{
    private bool _result = result;
}

public class SegmentResult(bool result, double time)
{
    public readonly bool Result = result;
    public readonly double Time = time;
}

public class RouteResult(bool result, double time)
{
    private bool _result = result;
    private double _time = time;
}