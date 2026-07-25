namespace lab_1;

public abstract class Train(double mass, double force, double quality)
{
    private double _maxForce = force;
    private double _speed = 0;
    private double _acceleration = 0;

    public ApplyForceResult ApplyForce(double force)
    {
        if (force > _maxForce)
        {
            return new ApplyForceResult(false);
        }
        else
        {
            _maxForce = force;
            _acceleration = force / mass;
            return new ApplyForceResult(true);
        }
    }

    public SegmentResult CalculateTravelTime(double distance)
    {
        if (_speed == 0 && _acceleration == 0)
        {
            return new SegmentResult(false, 0);
        }
        var lastDistance = distance;
        double lastTime = 0;
        var lastSpeed = _speed;
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

        _speed = lastSpeed;
        return new SegmentResult(true, lastTime);
    }
    
    public void Stop()
    {
        _speed = 0;
        _acceleration = 0;
    }
    
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
    
    public double GetSpeed(){
        return _speed;}
    
    
} 