namespace lab_1;

public abstract class Train(int mass, int force, int quality)
{
    private int _maxForce = force;
    public double Speed = 0;
    private int _acceleration = 0;

    public void ApplyForce(int force)
    {
        if (force > _maxForce)
        {
            Console.WriteLine("не могу");
        }
        else
        {
            _maxForce = force;
            _acceleration = force / mass;
        }
    }

    public double CalculateTravelTime(double distance)
    {
        if (Speed == 0 && _acceleration == 0)
        {
            Console.WriteLine("не могу");
        }
        var lastDistance = distance;
        double lastTime = 0;
        var lastSpeed = Speed;
        while (lastDistance > 0)
        {
            var newSpeed = lastSpeed + _acceleration * quality;
            if (newSpeed < 0)
            {
                Console.WriteLine("не могу");
            }
            var collectDistance =newSpeed * quality;
            lastDistance = lastDistance - collectDistance;
            lastTime += quality;
            lastSpeed = newSpeed;
        }

        Speed = lastSpeed;
        return lastTime;
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