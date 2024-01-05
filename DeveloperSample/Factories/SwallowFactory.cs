using DeveloperSample.Enums;
using DeveloperSample.Models;

namespace DeveloperSample.Factories;

   public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new(swallowType);
    }