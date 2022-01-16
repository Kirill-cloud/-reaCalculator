namespace АreaCalculator
{
    public class Example
    {
        public void DontKnownAtCompile()
        {
            // Не уверен что правильно понял условие "Вычисление площади фигуры без знания типа фигуры в compile-time", 
            // Вот как я представляю:

            List<IHaveArea> haveAreas = new();

            haveAreas.Add(new Triangle((3,4,5)));
            haveAreas.Add(new Circle(5));

            foreach (var item in haveAreas)
            {
                _ = item.GetArea;
            }
        }
    }
}