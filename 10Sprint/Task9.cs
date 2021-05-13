public interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }
    public class TeamLead : ILead, IProgrammer
    {
        public void CreateSubTask()
        {

        }
        public void AssignTask()
        {

        }
        public void WorkOnTask()
        {

        }
    }
    public class Manager : ILead
    {
        public void CreateSubTask()
        {

        }
        public void AssignTask()
        {

        }

        public void WorkOnTask()
        {

        }
    }
    public interface IProgrammer
    {
        void WorkOnTask();
    }
    class Programmer : IProgrammer
    {

        public void WorkOnTask()
        {

        }
    }
