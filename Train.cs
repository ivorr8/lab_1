namespace lab_1;

public class Train(double mass, double force, double quality)
{
    private readonly double  _maxForce = force;
    public double Speed { get; private set; }= 0;
    private double _acceleration = 0;

    public ApplyForceResult ApplyForce(double force)
    {
        if (force > _maxForce)
        {
            return new ApplyForceResult(false);
        }
        else
        {
            _acceleration = force / mass;
            return new ApplyForceResult(true);
        }
    }

    public SegmentResult CalculateTravelTime(double distance)
    {
        if (Speed == 0 && _acceleration == 0)
        {
            return new SegmentResult(false, 0);
        }
        var lastDistance = distance;
        double lastTime = 0;
        var lastSpeed = Speed;
        while (lastDistance > 0)
        {
            var newSpeed = lastSpeed + _acceleration * quality;
            if (newSpeed < 0)
            {
                return new SegmentResult(false, 0);
            }
            var collectDistance =newSpeed * quality;
            lastDistance = lastDistance - collectDistance;
            lastTime += quality;
            lastSpeed = newSpeed;
        }

        Speed = lastSpeed;
        return new SegmentResult(true, lastTime);
    }
    
    public void Stop()
    {
        Speed = 0;
        _acceleration = 0;
    }
    
    public void SetSpeed(double speed)
    {
        Speed = speed;
    }
} 