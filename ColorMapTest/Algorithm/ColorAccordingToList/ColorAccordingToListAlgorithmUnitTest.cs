namespace ColorMapTest.Algorithm.ColorAccordingToList
{
    using ColorMapTest.BasicTest.AlgorithmBase.ColorAccordingToList;
    using NUnit.Framework;
    using TestDataStructure.ColorAccordingToList;

    public class ColorAccordingToListAlgorithmUnitTest : ColorAccordingToListAlgorithmBase
    {
        [Test]
        [TestCaseSource("DataForColoring")]
        public void PerformCololoring(ColorAccordingToListData input)
        {
            // Arrange 

            // Act 
            Algorithm.SetData(new ColorMap.DataStructure.ColorAccordingToList.ColorAccordingToListData()
            {
                Input = input.Input
            });
            var output = Algorithm.Run().GetData().ListOfLettersAndCorespondingColors;
            
            // Assert
            foreach (var expectedItem in input.Expected)
            {
                var outputValue = output[expectedItem.Key];

                Assert.AreEqual(expectedItem.Value, outputValue);
            }
        }
    }
}
