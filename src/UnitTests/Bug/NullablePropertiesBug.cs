﻿using Xunit;
using Should;

namespace AutoMapper.UnitTests.Bug
{
    public class NullablePropertiesBug
    {
        public class Source { public int? A { get; set; } }
        public class Target { public int? A { get; set; } }

        [Fact]
        public void Example()
        {
            Mapper.Reset();
            Mapper.CreateMap<Source, Target>();

            var d = Mapper.Map(new Source { A = null }, new Target { A = 10 });

            d.A.ShouldBeNull();
        }
    }
}