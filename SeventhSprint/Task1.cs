public static double EvaluateSumOfElementsOddPositions(double[] inputData) =>
        inputData.Where((x, y) => y % 2 != 0).Sum();
