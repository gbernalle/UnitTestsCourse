namespace UnitTestsCourse.Tests
{
    public static class WorldsDumbestFunctionTests
    {
        // Naming Convention -- ClassName_MethodName_ExpectedResult
        public static void WorldsDumbestFunction_ReturnsTestIfZero_ReturnString()
        {
            try
            {
                // Arrange - Go get your variables, whatever you need, your classes, go get functions
                int num = 0;
                WorldsDumbestFunction worldsDumbest = new WorldsDumbestFunction();

                // Act -  Execute this function
                string result = worldsDumbest.ReturnsTestIfZero(num);

                // Assert - Whatever ever is returned is it what you want.
                if( result == "Yep, is zero")
                {
                    Console.WriteLine("Passed: WorldsDumbestFunction.ReturnsTestIfZero_ReturnsString");
                }else
                {
                    Console.WriteLine("FAILED: WorldsDumbestFunction.ReturnsTestIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
