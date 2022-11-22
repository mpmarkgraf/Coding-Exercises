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

    public interface ISwallowFactory
    {
        ISwallow GetSwallow(SwallowType swallowType);
    }

    public class SwallowFactory : ISwallowFactory
    {
        public ISwallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public interface ISwallow
    {
        SwallowType Type { get; }
        SwallowLoad Load { get; }
        void ApplyLoad(SwallowLoad load);
        double GetAirspeedVelocity();
    }

    public class Swallow : ISwallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            switch(Type)
            {
                case SwallowType.African:
                    switch(Load)
                    {
                        case SwallowLoad.None:
                            return 22;
                        case SwallowLoad.Coconut:
                            return 18;
                    }
                    break;
                case SwallowType.European:
                    switch (Load)
                    {
                        case SwallowLoad.None:
                            return 20;
                        case SwallowLoad.Coconut:
                            return 16;
                    }
                    break;
            }

            throw new InvalidOperationException();
        }
    }
}