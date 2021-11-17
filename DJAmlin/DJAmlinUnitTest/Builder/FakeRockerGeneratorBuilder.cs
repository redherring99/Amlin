using DJAmlin.Modules;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;

namespace DJAmlinUnitTest.Builder
{
    public class FakeRockerGeneratorBuilder : BuilderBase<IRockGenerator>
    {
        private string Result;

        public FakeRockerGeneratorBuilder WithResult( string result)
        {
            this.Result = result;
            return this;
        }

        public override IRockGenerator Build()
        {
            this.Fake.Generate().Returns(Result);
            return this.Fake;
        }
    }
}