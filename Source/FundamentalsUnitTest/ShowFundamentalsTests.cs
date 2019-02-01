using System;
using System.Collections.Generic;
using Avtec.DevMorningFix.BusinessCases.Impl;
using FundamentalsUnitTest;
using NSubstitute;
using NUnit.Framework;

namespace Avtec.DevMorningFix.FundamentalsUnitTest
{
    [TestFixture]
    internal class ShowFundamentalsTests
    {
        [Test]
        public void OutputNotSet()
        {
            // Arrange
            var repository = Substitute.For<IFundamentalRepository>();
            var subject = new ShowFundamentals(repository);
            subject.SetOutput(null);

            // Act
            // Assess
            Assert.Throws<InvalidOperationException>(subject.Execute);
        }

        [Test]
        public void ResultNotNull()
        {
            // Arrange
            var repository = Substitute.For<IFundamentalRepository>();
            var list = new List<DevFixFundamental>();
            repository.GetAllFundamentals().Returns(list);

            var subject = new ShowFundamentals(repository);

            var output = new MockOutput();
            output.Fundamentals = null;
            subject.SetOutput(output);

            // Act
            subject.Execute();

            // Assess
            Assert.IsNotNull(output.Fundamentals);
        }
    }
}