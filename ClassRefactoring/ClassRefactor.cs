using System;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        private readonly SwallowType Type;
        private SwallowLoad Load;

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirSpeed()
        {
            if (Type == SwallowType.African && Load == SwallowLoad.None)
            {
                return 22;
            }
            else if (Type == SwallowType.African && Load == SwallowLoad.Coconut)
            {
                return 18;
            }
            else if (Type == SwallowType.European && Load == SwallowLoad.None)
            {
                return 20;
            }
            else if (Type == SwallowType.European && Load == SwallowLoad.Coconut)
            {
                return 16;
            }
            else {
                throw new InvalidOperationException();
            }
        }
    }
}