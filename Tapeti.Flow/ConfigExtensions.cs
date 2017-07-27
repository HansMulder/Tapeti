﻿namespace Tapeti.Flow
{
    public static class ConfigExtensions
    {
        public static TapetiConfig WithFlow(this TapetiConfig config, IFlowRepository<Default.FlowState> flowRepository)
        {
            config.Use(new FlowMiddleware(flowRepository));
            return config;
        }
    }
}
