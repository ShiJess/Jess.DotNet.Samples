using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Google.Protobuf;
using Jess.Sample.GoogleProtoBuf;
using Jess.Sample.ProtoBufNet;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Jess.Sample.ProtoBuf.Benchmarks
{
    //[ClrJob(baseline: true)]
    //[RPlotExporter, RankColumn]
    //[PlainExporter]

    //[SimpleJob(RuntimeMoniker.Net472, baseline: true)]
    //[SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [MarkdownExporterAttribute.GitHub, RankColumn]
    public class MemoryStreamProtoBufTest
    {
        [Fact]
        [Benchmark(Description = "Google.ProtoBuf使用MemoryStream")]
        public void a()
        {
            ProtoBufHandler.SimplestUse();
        }

        [Fact]
        [Benchmark(Description = "Google.ProtoBuf使用MemoryStream嵌套CodedOutputStream")]
        public void a1()
        {
            ProtoBufHandler.MemoryNestOutputStream();
        }

        [Fact]
        [Benchmark(Description = "protobuf-net使用MemoryStream")]
        public void b()
        {
            ProtoBufNetHandler.SimplestUse();
        }
    }
}