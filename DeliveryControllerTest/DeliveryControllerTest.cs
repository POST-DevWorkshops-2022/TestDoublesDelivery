using System;
using System.Collections.Generic;
using DeliverySystem;
using FluentAssertions;
using FluentAssertions.Extensions;
using Moq;
using Xunit;

namespace DeliveryControllerTest
{
    public class DeliveryControllerTest
    {
        private static readonly Location Vienna = new Location(48.2084878F, 16.372076F);
        private static readonly Location Linz = new Location(48.30694F, 14.285830000000033F);

        [Fact]
        public void WhenDeliveredThenMessageWithDeliveryTimeIsSent()
        {
        }
    }
}