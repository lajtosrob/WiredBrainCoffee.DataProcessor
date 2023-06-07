using WiredBrainCoffee.DataProcessor.Parsing;

namespace WiredBrainCoffee.DataProcessorTests
{
    public class UnitTest1
    {
        [Fact]

        public void SajatTeszt()
        {
            //ARRANGE
            string[] csvLines = new[]
            {
                "UjKave;12/08/2023 18:06:04 PM"
            };

            //ACT

            var machineDataItems = CsvLineParser.Parse( csvLines );

            //ASSERT

            Assert.Equal("UjKave", machineDataItems[0].CoffeeType);

        }
        public void Test1()
        {
            //ARRANGE
            string[] csvLines = new[] { "Latte;10/27/2022 8:06:04 AM",
                                        "Espresso;10/27/2022 10:06:04 AM",
                                        "Capuccino;10/27/2022 18:06:04 PM",
            };

            //ACT
            var machineDataItems = CsvLineParser.Parse(csvLines);


            //ASSERT
            //Assert.Equal(3, machineDataItems.Length);

            
            Assert.NotNull(machineDataItems);
            //Assert.Single(machineDataItems);
            Assert.Equal("Latte", machineDataItems[0].CoffeeType);

            Assert.Equal("Espresso", machineDataItems[1].CoffeeType);
            Assert.Equal("Capuccino", machineDataItems[2].CoffeeType);

            //Assert.Equal(new DateTime(2022,10,27,8,6,4), machineDataItems[0].CreatedAt);
            Assert.Equal(true, machineDataItems.Any(x => x.CoffeeType == "Latte"));

        }
    }
}