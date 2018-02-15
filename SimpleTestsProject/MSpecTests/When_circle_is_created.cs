using Machine.Specifications;
using SimpleTestsProject;

namespace MSpecTests
{
    [Subject(typeof(Circle))]
    public class When_circle_is_created
    {
        private static Point center;
        private static Circle circle;

        private Establish context = () =>
        {
            center = new Point(0, 0);
            circle = new Circle(center, 10);
        };

        private It should_correctly_calculate_square = () => circle.GetSquare().ShouldEqual(314); 

        private It should_correctly_calculate_length = () => circle.GetLength().ShouldEqual(62.8); 
    }
}
