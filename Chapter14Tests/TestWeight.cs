using System;
using System.IO.IsolatedStorage;
using System.Net.Mail;
using System.Threading.Channels;
using Chapter14;
using Xunit.Abstractions;

namespace TestProject01
{
    
    public class TestWeight
    {
        private readonly ITestOutputHelper _output;

        public TestWeight(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void Constractor_DefualtValues()
        {
            Weight weight = new Weight();

            Console.Out.WriteLine(weight.GetGram());
            Console.Out.WriteLine(weight.GetKilo());

        }
        [Fact]
        public void Constractor_TotalGram()
        {
            Weight weight = new Weight(3256);

            Assert.Equal(3, weight.GetKilo());
            Assert.Equal(256, weight.GetGram());

            _output.WriteLine($"weight.Kilo:{weight.GetKilo()}, weight.Gram:{weight.GetGram()}");


        }

        [Fact]
        public void EqualWeit_LessReturnFalse()
        {
            Weight weight1 = new Weight(2150);
            Weight weight2 = new Weight(2150);


            Assert.False(weight1.Less(weight2));
        } 
    }
}