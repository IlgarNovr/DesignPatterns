namespace DP_SOLID
{
    class OpenClosed
    {
        public abstract class Subject
        {
            public Subject(int id, string name, int credit, int lcount)
            {
                Id = id;
                Name = name;
                Credit = credit;
                LessonCount = lcount;

            }
            public int Id { get; set; }

            public string Name { get; set; }

            public double Credit { get; set; }

            public int LessonCount { get; set; }
            public abstract double GetLimit();
        }

        public class Match : Subject
        {
            public Match(int id, string name, int credit, int lcount) : base(id, name, credit, lcount) { }

            public override double GetLimit() => LessonCount * 0.25;
        }

        public class IT : Subject
        {
            public IT(int id, string name, int credit, int lcount) : base(id, name, credit, lcount) { }

            public override double GetLimit() => LessonCount * 0.3;
        }

        public class Phisics : Subject
        {
            public Phisics(int id, string name, int credit, int lcount) : base(id, name, credit, lcount) { }

            public override double GetLimit() => LessonCount * 0.15;
        }
    }    
}
