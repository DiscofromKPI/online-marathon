public class Student : IEquatable<Student>
    {
        public int Id { get; }
        public string Name { get; }

        public Student(int id, string name) => (Id, Name) = (id, name);

        public static HashSet<Student> GetCommonStudents(List<Student> l1, List<Student> l2)
        {
            return l1.Intersect(l2).ToHashSet();
        }

        public bool Equals(Student other)
        {
            if (other is null) return false;
            return this.Name == other.Name && this.Id == other.Id;
        }
        public override bool Equals(object obj) => Equals(obj as Student);
        public override int GetHashCode()
        {
            return (Name, Id).GetHashCode();
        }
    }
