﻿namespace SXA.Feature.SecurityHeaders.Pipelines.BuildSecurityHeaders
{
    public abstract class BuildSecurityHeadersProcessor 
    {
        public abstract void Process(BuildSecurityHeadersArgs args);
    }
}