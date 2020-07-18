using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using Jess.Sample.GoogleProtoBuf;
using Jess.Sample.ProtoBufNet;
using System;
using Xunit;
using Xunit.Abstractions;

namespace Jess.Sample.ProtoBuf.Benchmarks
{
    public class UnitTest1
    {

        ITestOutputHelper outputHelper;
        public UnitTest1(ITestOutputHelper output)
        {
            this.outputHelper = output;
        }

        [Fact]
        public void te1()
        {
            var id = ProtoBufHandler.UseFileStreamDeserialize();
            outputHelper.WriteLine(id.ToString());
        }

        [Fact]
        public void b2()
        {
            var id = ProtoBufNetHandler.UseFileStreamDeserialize();
            outputHelper.WriteLine(id.ToString());
        }



        [Fact]
        public void BenchmarkTest()
        {
            //ManualConfig
            //BenchmarkRunner.Run<Class1>();

            //BenchmarkRunner.Run<MemoryStreamProtoBufTest>(new DebugInProcessConfig());

            //BenchmarkRunner.Run<FileStreamProtoSerializeTest>(new DebugInProcessConfig());
            //BenchmarkRunner.Run<FileStreamProtoDeserializeTest>(new DebugInProcessConfig());

            BenchmarkRunner.Run<FileStreamProtoSerialize_Complex_Test>(new DebugInProcessConfig());
            BenchmarkRunner.Run<FileStreamProtoDeserialize_Complex_Test>(new DebugInProcessConfig());

        }
    }
}
