using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanOfResponsibility;


public abstract class RewardHandler
{
    private RewardHandler _nextHandler;

    public virtual string HandleReward(Customer request)
    {
        if(_nextHandler != null)
        {
            return _nextHandler.HandleReward(request);
        }
        else
        {
            return $"{request.FirstName} {request.LastName} will not give any reward";
        }
        
    }

    public RewardHandler SetNext(RewardHandler handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }
}

public class FirstClassReward : RewardHandler
{
    public override string HandleReward(Customer request)
    {

        if(request.Score > 70 && request.Score <= 100)
        {
            return $"{request.FirstName} {request.LastName} will give first class reward";
        }

        return base.HandleReward(request);
    }
}

public class SecondClassReward : RewardHandler
{
    public override string HandleReward(Customer request)
    {

        if (request.Score > 50 && request.Score <= 70)
        {
            return $"{request.FirstName} {request.LastName} will give second class reward";
        }

        return base.HandleReward(request);
    }
}

public class ThirdClassReward : RewardHandler
{
    public override string HandleReward(Customer request)
    {

        if (request.Score > 0 && request.Score <= 50)
        {
            return $"{request.FirstName} {request.LastName} will give third class reward";
        }

        return base.HandleReward(request);
    }
}

